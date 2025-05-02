using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace RCT_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PostInit();
        }




        private async void PostInit()
        {
            AppendInfoText("Waiting for PostInit...");
            await Task.Delay(1000);
            reload_CFG(null, null);
            testButton(null, null);
            AppendSuccess("Post Init successful!");
            postPostInit();

        }

        private async void postPostInit()
        {
            await Task.Delay(1000);
            AppendInfoText("\n--[========|========|==RCT Online==|========|========]--\n");

        }



        //##############################
        //       Save/Load
        //##############################

        private void save_CFG(object sender, EventArgs e)
        {
            AppendInfoText("Saving config.xml ...");
            Config config = new Config
            {
                HostName = richTextHostname.Text,
                SlaveIP = richTextSlaveIP.Text,
                SlavePort = int.Parse(richTextSlavePort.Text),
                Token = richTextToken.Text
            };
            Program.SaveConfigFile(config, "config.xml");
        }

        private async void reload_CFG(object sender, EventArgs e)
        {
            AppendInfoText("Reloading config.xml ...");
            Config config = Program.LoadConfig("config.xml");

            if (config != null)
            {
                richTextHostname.Text = config.HostName;
                richTextSlaveIP.Text = config.SlaveIP;
                richTextSlavePort.Text = config.SlavePort.ToString();
                richTextToken.Text = config.Token;
            }
            else
            {
                await Task.Delay(50);
                AppendInfoText("Generating new config.xml ...");
                await Task.Delay(100);
                AppendSuccess("config.xml Generated!");
                save_CFG(null, null);
            }
        }





        //##############################
        //         General Settings
        //##############################
        private void testConnection(object sender, EventArgs e)
        {
            Program.SendMessage("[RCT]ConnectionTest[RCT]");
        }

        private void buttonClearConsole(object sender, EventArgs e)
        {
            ConsoleOutput.Clear();
            AppendWarning("Console cleared!");
        }

        private void openWebsite(object sender, EventArgs e)
        {
            string url = "https://rehoga-interactive.com/";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                AppendError(url + ex.Message);
            }
        }



        //##############################
        //         RichText Append
        //##############################
        public void AppendError(string errorText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.Red;
            ConsoleOutput.AppendText(errorText + "\n");
        }
        public void AppendWarning(string warningText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.Yellow;
            ConsoleOutput.AppendText(warningText + "\n");
        }
        public void AppendSuccess(string successText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.LightGreen;
            ConsoleOutput.AppendText(successText + "\n");
        }
        public void AppendInfoText(string infoText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.White;
            ConsoleOutput.AppendText(infoText + "\n");
        }

        //only for output message - single use
        public void AppendMessageText(string messageText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.LightGreen;
            ConsoleOutput.AppendText(messageText);
        }


        //##############################
        //         WriteToLog
        //##############################

        private void LogToFile(string message)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RTC_Master_log.txt");
            string timeStampedMessage = $"[{DateTime.Now:yyy-MouseMove-DeviceDpi HH:MouseMove:ss}] {message}";
            File.AppendAllText(logFilePath, timeStampedMessage + Environment.NewLine);
        }











        //Deprecated but Bricking:
        private void testButton(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void richTextSlavePort_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

    }
}
