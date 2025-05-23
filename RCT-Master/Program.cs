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
        public static string SelectedConfigName = "MasterConfig.xml";
        public static string ConfigsDirectory => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configs");
        public static string hostName = "EnterTargetHostname";
        public static string serverIp = "127.0.0.1";
        public static int serverPort = 65534;
        public static int readbackPort = 1;
        public static string token = "12345";
        public static string hashKey = "c71ee8230724cc1eef15740fba8506a2";
        public static bool WanMode = false;
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
        //         Profile Management
        //##############################
        public static string GetSelectedConfigPath()
        {
            return Path.Combine(ConfigsDirectory, SelectedConfigName);
        }

        public static void EnsureConfigFolderExists()
        {
            if (!Directory.Exists(ConfigsDirectory))
            {
                Directory.CreateDirectory(ConfigsDirectory);
            }
        }

        public static void SaveLastProfile(string name)
        {
            File.WriteAllText(Path.Combine(ConfigsDirectory, "last.txt"), name);
        }

        public static string LoadLastProfile()
        {
            string file = Path.Combine(ConfigsDirectory, "last.txt");
            return File.Exists(file) ? File.ReadAllText(file) : null;
        }

        //##############################
        //         Message Handler
        //##############################
        public static void SendMessage(string content)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    // Set the timeout
                    IAsyncResult result = client.BeginConnect(serverIp, serverPort, null, null);
                    bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(800));

                    if (!success)
                    {
                        form.AppendError("Connection timed out (800ms).");
                        return;
                    }

                    client.EndConnect(result);

                    if (!string.IsNullOrEmpty(content) && content != "empty" && content != "none")
                    {
                        NetworkStream stream = client.GetStream();
                        string message = $"{hashKey}-{token}-{content}";

                        string encryptedMessage = CryptoCore.Encrypt(message);
                        byte[] data = Encoding.UTF8.GetBytes(encryptedMessage);

                        stream.Write(data, 0, data.Length);
                        form.AppendMessageText("Command sent: ");
                        form.AppendInfoText(content);
                    }
                    else
                    {
                        form.AppendWarning("Function not assigned.");
                    }
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
        public static Config LoadConfig(string filePath, bool silentMode)
        {
            try
            {
                if (File.Exists(filePath))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(Config));

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        Config config = (Config)serializer.Deserialize(reader);
                        hostName = config.HostName;
                        serverIp = config.SlaveIP;
                        if (silentMode == false)
                        {
                            form.Invoke(new Action(() => form.AppendSuccess($"{SelectedConfigName} loaded and applied!")));
                        }
                        serverPort = config.SlavePort;
                        token = config.Token;
                        readbackPort = config.SlavePort + 1;
                        WanMode = config.WanMode;
                        form.Text = ("RCT-Master: " + hostName);
                        form.LogToFile("[LOG READ CONTENT] " + serverIp + ":" + serverPort + ":" + token + ":" + hostName + "[LOG READ CONTENT]");
                        form.LoadButtonConfigs(config);
                        RestartReadback();
                        return config;
                    }
                }
                else
                {
                    form.AppendWarning("MasterConfig.xml not existing");
                    return null;
                }
            }
            catch (Exception ex)
            {
                form.AppendError("MasterConfig.xml read error: " + ex.Message);
                return null;
            }
        }

        //CFG Writer
        public static async void SaveConfigFile(Config config, string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, config);
                    hostName = config.HostName;
                    serverIp = config.SlaveIP;
                    serverPort = config.SlavePort;
                    token = config.Token;
                    WanMode = config.WanMode;
                    form.LogToFile("[CFG WRITE CONTENT] " + serverIp + ":" + serverPort + ":" + token + ":" + hostName + "[CFG WRITE CONTENT]");
                }

                form.AppendSuccess("Config saved!");
                await Task.Delay(200);
                LoadConfig(filePath, true);
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
                        var remoteIp = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                        if (remoteIp != Program.serverIp)
                        {
                            if (WanMode == false)
                            {
                                form.Invoke(new Action(() =>
                                {
                                    form.AppendWarning($"ignored message from unauthorized IP: {remoteIp}");
                                }));
                            }
                            continue; 
                        }


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
                            string incomingToken = parts[1];
                            string content = parts[2];

                            if (incomingToken == Program.token)
                            {
                                parsedMessage = content;
                                responseMessage = CryptoCore.Encrypt($"ACK-{content}");

                                form.Invoke(new Action(() =>
                                {
                                    form.AppendReadbackText(serverIp + ": ");
                                    form.AppendInfoText(parsedMessage);
                                }));
                            }
                            else
                            {

                                    parsedMessage = $"Invalid token received";
                                    responseMessage = CryptoCore.Encrypt("ERR-InvalidToken");


                                if (WanMode == false)
                                {
                                    form.Invoke(new Action(() =>
                                    {
                                        form.AppendWarning(parsedMessage);
                                    }));
                                }
                            }
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {
                //LogInfo("Listener canceled.");
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
                await Task.Delay(500);

                await InitReadback();

                form.Invoke(new Action(() =>
                {
                    //form.AppendSuccess("Listener restarted successfully.");
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


