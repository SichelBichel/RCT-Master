using System.Net.Sockets;
using System.Text;

namespace RCT_Master
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            // Slave Data
            string serverIp = "127.0.0.1";
            int serverPort = 5000;

            string token = "1234";
            string app = "NotePad";

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
    }
}