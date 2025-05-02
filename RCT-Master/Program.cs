using System.Net.Sockets;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Net;

namespace RCT_Master
{
    internal static class Program
    {
        public static Form1 form;

        public static string hostName = "EnterTargetHostname";
        public static string serverIp = "127.0.0.1";
        public static int serverPort = 65535;
        public static int readbackPort = 1;
        public static string token = "12345";
        public static string hashKey = "c71ee8230724cc1eef15740fba8506a2";
        private static TcpListener readbackListener;
        private static Thread listenerThread;
        private static bool listenerRunning = false;
        private static CancellationTokenSource listenerCancelToken;


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            form = new Form1();
            Application.Run(form);
        }


        public static async void coreInit()
        {
            await Task.Delay(500);
            Program.InitReadback();
        }


        //##############################
        //         Message Handler
        //##############################
        public static void SendMessage(string content)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIp, serverPort))
                {


                    NetworkStream stream = client.GetStream();
                    string message = $"{hashKey}-{token}-{content}";

                    string encryptedMessage = CryptoCore.Encrypt(message);


                    byte[] data = Encoding.UTF8.GetBytes(encryptedMessage);

                    // send
                    stream.Write(data, 0, data.Length);
                    form.AppendMessageText("Message Sent: ");
                    form.AppendInfoText(content);
                }
            }
            catch (Exception ex)
            {
                form.AppendError($"Error: {ex.Message}");
            }
        }





        //##############################
        //         Read/Write
        //##############################
        //CFG Loader
        public static Config LoadConfig(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(Config));

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        Config config = (Config)serializer.Deserialize(reader);
                        form.AppendSuccess("config.xml loaded and applied!");
                        hostName = config.HostName;
                        serverIp = config.SlaveIP;
                        serverPort = config.SlavePort;
                        token = config.Token;
                        readbackPort = config.SlavePort + 1;
                        form.Text = ("RCT-Master: " + hostName);
                        form.LogToFile("[LOG READ CONTENT] " + serverIp + ":" + serverPort + ":" + token + ":" + hostName + "[LOG READ CONTENT]");
                        form.LoadButtonConfigs(config);
                        RestartReadback();
                        return config;
                    }
                }
                else
                {
                    form.AppendWarning("config.xml not existing");
                    return null;
                }
            }
            catch (Exception ex)
            {
                form.AppendError("config.xml read error: " + ex.Message);
                return null;
            }
        }

        //CFG Writer
        public static void SaveConfigFile(Config config, string fileName)
        {
            try
            {
                string rootPath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(rootPath, fileName);
                XmlSerializer serializer = new XmlSerializer(typeof(Config));

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, config);
                    hostName = config.HostName;
                    serverIp = config.SlaveIP;
                    serverPort = config.SlavePort;
                    token = config.Token;
                    // Die Buttons auslesen und in die Config setzen


                    form.LogToFile("[CFG WRITE CONTENT] " + serverIp + ":" + serverPort + ":" + token + ":" + hostName + "[CFG WRITE CONTENT]");
                }
                form.AppendSuccess("config.xml saved!");
            }
            catch (Exception ex)
            {
                form.AppendError("CFG save error: " + ex.Message);
            }
        }







        //##############################
        //         Readback Listener
        //##############################

        public static async Task InitReadback()
        {
            if (listenerRunning) return;

            listenerRunning = true;
            listenerCancelToken = new CancellationTokenSource();

            await Task.Run(() => ReadbackListener(serverIp, readbackPort, listenerCancelToken.Token));
        }

        public static async Task ReadbackListener(string ipAddress, int port, CancellationToken cancellationToken)
        {
            try
            {
                readbackListener = new TcpListener(IPAddress.Any, port);
                readbackListener.Start();

                form.Invoke(new Action(() =>
                {
                    form.AppendSuccess($"Listener online at {ipAddress}:{port}");
                }));

                while (!cancellationToken.IsCancellationRequested)
                {
                    if (!readbackListener.Pending())
                    {
                        await Task.Delay(100, cancellationToken);
                        continue;
                    }

                    using (TcpClient client = await readbackListener.AcceptTcpClientAsync())
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken);

                        if (bytesRead == 0) continue;

                        string encryptedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        string decryptedMessage = CryptoCore.Decrypt(encryptedMessage);

                        string[] parts = decryptedMessage.Split('-');
                        string parsedMessage;
                        string responseMessage;

                        if (parts.Length == 3)
                        {
                            string hash = parts[0];
                            string token = parts[1];
                            string content = parts[2];

                            parsedMessage = $"Hash: {hash}, Token: {token}, Content: {content}";
                            responseMessage = CryptoCore.Encrypt($"ACK-{content}");
                        }
                        else
                        {
                            parsedMessage = $"Invalid Format: {decryptedMessage}";
                            responseMessage = CryptoCore.Encrypt("ERR-InvalidFormat");
                        }

                        byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
                        await stream.WriteAsync(responseData, 0, responseData.Length, cancellationToken);

                        form.Invoke(new Action(() =>
                        {
                            form.AppendReadbackText("[READBACK]: ");
                            form.AppendInfoText(parsedMessage);
                        }));
                    }
                }
            }
            catch (OperationCanceledException)
            {
                LogInfo("Listener canceled.");
            }
            catch (Exception ex)
            {
                LogError($"Listener error: {ex.Message}");
            }
            finally
            {
                try { readbackListener?.Stop(); } catch { }

                listenerRunning = false;
                readbackListener = null;

                LogInfo("Listener stopped.");
            }
        }


        public static async Task RestartReadback()
        {
            try
            {
                listenerCancelToken?.Cancel();
                await Task.Delay(500); // Give time for listener to stop

                await InitReadback();

                form.Invoke(new Action(() =>
                {
                    form.AppendSuccess("Listener restarted successfully.");
                }));
            }
            catch (Exception ex)
            {
                form.Invoke(new Action(() =>
                {
                    form.AppendError($"Error restarting listener: {ex.Message}");
                }));
            }
        }

        private static void LogError(string message)
        {
            form.Invoke(new Action(() => form.AppendError(message)));
        }

        private static void LogInfo(string message)
        {
            form.Invoke(new Action(() => form.AppendInfoText(message)));
        }


    }
}


