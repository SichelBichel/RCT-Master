using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;

namespace RCT_Master
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static Form1 form;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            form = new Form1();
            Application.Run(form);
            




            // Slave Data
            string hostName = "Testserver";
            string serverIp = "127.0.0.1";
            int serverPort = 5000;

            string token = "1234";
            string app = "NotePad";
            form.Text = ("RCT Master:" + hostName);

            SendMessage(serverIp, serverPort, token, app);
        }

        public static void SendMessage(string serverIp, int serverPort, string token, string app)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIp, serverPort))
                {
                    NetworkStream stream = client.GetStream();
                    string message = $"{token}-{app}";
                    byte[] data = Encoding.UTF8.GetBytes(message);

                    // send
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine($"Msg Sent: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

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
                        return config;
                    }
                }
                else
                {
                    form.AppendSuccess("CFG loaded");
                    return null;
                }
            }
            catch (Exception ex)
            {
                form.AppendError("CFG read error: " + ex.Message);
                return null;
            }
        }


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
                }
                form.AppendSuccess("CFG saved");
            }
            catch (Exception ex)
            {
                form.AppendError("CFG save error: " + ex.Message);
            }
        }



    }
}