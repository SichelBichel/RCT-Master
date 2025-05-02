using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace RCT_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            LogToFile("\n\n ---------- NEW SESSION ---------- \n\n");
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
                Token = richTextToken.Text,

        EventButton1Name = eventButton1.Text,
        EventButton1Content = eventButton1.Tag != null ? eventButton1.Tag.ToString() : "empty",

        EventButton2Name = eventButton2.Text,
        EventButton2Content = eventButton2.Tag != null ? eventButton2.Tag.ToString() : "empty",

        EventButton3Name = eventButton3.Text,
        EventButton3Content = eventButton3.Tag != null ? eventButton3.Tag.ToString() : "empty",

        EventButton4Name = eventButton4.Text,
        EventButton4Content = eventButton4.Tag != null ? eventButton4.Tag.ToString() : "empty",

        EventButton5Name = eventButton5.Text,
        EventButton5Content = eventButton5.Tag != null ? eventButton5.Tag.ToString() : "empty",

        EventButton6Name = eventButton6.Text,
        EventButton6Content = eventButton6.Tag != null ? eventButton6.Tag.ToString() : "empty",

        EventButton7Name = eventButton7.Text,
        EventButton7Content = eventButton7.Tag != null ? eventButton7.Tag.ToString() : "empty",

        EventButton8Name = eventButton8.Text,
        EventButton8Content = eventButton8.Tag != null ? eventButton8.Tag.ToString() : "empty",

        EventButton9Name = eventButton9.Text,
        EventButton9Content = eventButton9.Tag != null ? eventButton9.Tag.ToString() : "empty",

        EventButton10Name = eventButton10.Text,
        EventButton10Content = eventButton10.Tag != null ? eventButton10.Tag.ToString() : "empty",

        EventButton11Name = eventButton11.Text,
        EventButton11Content = eventButton11.Tag != null ? eventButton11.Tag.ToString() : "empty",

        EventButton12Name = eventButton12.Text,
        EventButton12Content = eventButton12.Tag != null ? eventButton12.Tag.ToString() : "empty",

        EventButton13Name = eventButton13.Text,
        EventButton13Content = eventButton13.Tag != null ? eventButton13.Tag.ToString() : "empty",

        EventButton14Name = eventButton14.Text,
        EventButton14Content = eventButton14.Tag != null ? eventButton14.Tag.ToString() : "empty"

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

        private void openLog(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "log.txt",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                AppendError(ex.ToString());
            }
        }

        private void openCFG(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("config.xml"))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "config.xml",
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        AppendError(ex.ToString());
                    }
                }
                else
                {
                    reload_CFG(null, null);
                }
            }
            catch (Exception ex)
            {
                AppendError(ex.ToString());
            }
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
            LogToFile("[Error] " + errorText);
        }
        public void AppendWarning(string warningText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.Yellow;
            ConsoleOutput.AppendText(warningText + "\n");
            LogToFile($"[Warning] " + warningText);
        }
        public void AppendSuccess(string successText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.LightGreen;
            ConsoleOutput.AppendText(successText + "\n");
            LogToFile($"[Success] " + successText);
        }
        public void AppendInfoText(string infoText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.White;
            ConsoleOutput.AppendText(infoText + "\n");
            LogToFile($"[Info] " + infoText);
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

        public void LogToFile(string message)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
            string timeStampedMessage = $"[{DateTime.Now:yyy-MM-DD HH:mm:ss}] {message}";
            File.AppendAllText(logFilePath, timeStampedMessage + Environment.NewLine);
        }






        //##############################
        //         ButtonInit
        //##############################

        public void LoadButtonConfigs(Config config)
        {
            // Buttons mit den Namen und Inhalten aus der Konfiguration befüllen
            eventButton1.Text = config.EventButton1Name;
            eventButton1.Tag = config.EventButton1Content;

            eventButton2.Text = config.EventButton2Name;
            eventButton2.Tag = config.EventButton2Content;

            eventButton3.Text = config.EventButton3Name;
            eventButton3.Tag = config.EventButton3Content;

            eventButton4.Text = config.EventButton4Name;
            eventButton4.Tag = config.EventButton4Content;

            eventButton5.Text = config.EventButton5Name;
            eventButton5.Tag = config.EventButton5Content;
            

            // ... und so weiter für alle anderen Buttons
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
