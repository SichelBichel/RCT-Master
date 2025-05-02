using System.Net.Sockets;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Xml.Serialization;
using System.Security.Cryptography;

namespace RCT_Master
{
    internal static class Program
    {
        public static Form1 form;

        public static string hostName = "EnterTargetHostname";
        public static string serverIp = "127.0.0.1";
        public static int serverPort = 65535;
        public static string token = "12345";
        public static string hashKey = "c71ee8230724cc1eef15740fba8506a2";



        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            form = new Form1();
            Application.Run(form);
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
                        form.Text = ("RTC Master: " + hostName);
                        form.LogToFile("[LOG READ CONTENT] " + serverIp + ":" + serverPort + ":" + token + ":" + hostName + "[LOG READ CONTENT]");
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
                    form.LogToFile("[CFG WRITE CONTENT] " + serverIp + ":" + serverPort + ":" + token + ":" + hostName + "[CFG WRITE CONTENT]");
                }
                form.AppendSuccess("config.xml saved!");
            }
            catch (Exception ex)
            {
                form.AppendError("CFG save error: " + ex.Message);
            }
        }





    }
}