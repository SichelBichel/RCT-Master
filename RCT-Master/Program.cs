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

            // Beispiel: Server-Ip und -Port
            string serverIp = "127.0.0.1";
            int serverPort = 5000;

            string token = "1234";
            string app = "NotePad";

            // Nachricht senden
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

                    // Nachricht senden
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine($"Nachricht gesendet: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }
    }
}