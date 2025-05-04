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
            Program.coreInit();
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
            AppendInfoText("Saving MasterConfig.xml ...");
            Config config = new Config
            {
                HostName = richTextHostname.Text,
                SlaveIP = richTextSlaveIP.Text,
                SlavePort = int.Parse(richTextSlavePort.Text),
                Token = richTextToken.Text,
                WanMode = WanCheckBox.Checked,

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
                EventButton14Content = eventButton14.Tag != null ? eventButton14.Tag.ToString() : "empty",

                EventButton15Name = eventButton15.Text,
                EventButton15Content = eventButton15.Tag != null ? eventButton15.Tag.ToString() : "empty",

                EventButton16Name = eventButton16.Text,
                EventButton16Content = eventButton16.Tag != null ? eventButton16.Tag.ToString() : "empty",

                EventButton17Name = eventButton17.Text,
                EventButton17Content = eventButton17.Tag != null ? eventButton17.Tag.ToString() : "empty",

                EventButton18Name = eventButton18.Text,
                EventButton18Content = eventButton18.Tag != null ? eventButton18.Tag.ToString() : "empty",

                EventButton19Name = eventButton19.Text,
                EventButton19Content = eventButton19.Tag != null ? eventButton19.Tag.ToString() : "empty",

                EventButton20Name = eventButton20.Text,
                EventButton20Content = eventButton20.Tag != null ? eventButton20.Tag.ToString() : "empty",

                EventButton21Name = eventButton21.Text,
                EventButton21Content = eventButton21.Tag != null ? eventButton21.Tag.ToString() : "empty",

                EventButton22Name = eventButton22.Text,
                EventButton22Content = eventButton22.Tag != null ? eventButton22.Tag.ToString() : "empty",

                EventButton23Name = eventButton23.Text,
                EventButton23Content = eventButton23.Tag != null ? eventButton23.Tag.ToString() : "empty",

                EventButton24Name = eventButton24.Text,
                EventButton24Content = eventButton24.Tag != null ? eventButton24.Tag.ToString() : "empty",

                EventButton25Name = eventButton25.Text,
                EventButton25Content = eventButton25.Tag != null ? eventButton25.Tag.ToString() : "empty",

                EventButton26Name = eventButton26.Text,
                EventButton26Content = eventButton26.Tag != null ? eventButton26.Tag.ToString() : "empty",

                EventButton27Name = eventButton27.Text,
                EventButton27Content = eventButton27.Tag != null ? eventButton27.Tag.ToString() : "empty",

                EventButton28Name = eventButton28.Text,
                EventButton28Content = eventButton28.Tag != null ? eventButton28.Tag.ToString() : "empty",

                EventButton29Name = eventButton29.Text,
                EventButton29Content = eventButton29.Tag != null ? eventButton29.Tag.ToString() : "empty",

                EventButton30Name = eventButton30.Text,
                EventButton30Content = eventButton30.Tag != null ? eventButton30.Tag.ToString() : "empty",

                EventButton31Name = eventButton31.Text,
                EventButton31Content = eventButton31.Tag != null ? eventButton31.Tag.ToString() : "empty",

                EventButton32Name = eventButton32.Text,
                EventButton32Content = eventButton32.Tag != null ? eventButton32.Tag.ToString() : "empty",

            };
            Program.SaveConfigFile(config, "MasterConfig.xml");
        }

        private async void reload_CFG(object sender, EventArgs e)
        {
            AppendInfoText("Reloading MasterConfig.xml ...");
            Config config = Program.LoadConfig("MasterConfig.xml", false);

            if (config != null)
            {
                richTextHostname.Text = config.HostName;
                richTextSlaveIP.Text = config.SlaveIP;
                richTextSlavePort.Text = config.SlavePort.ToString();
                richTextToken.Text = config.Token;
                WanCheckBox.Checked = config.WanMode;
            }
            else
            {
                await Task.Delay(50);
                AppendInfoText("Generating new MasterConfig.xml ...");
                await Task.Delay(100);
                AppendSuccess("MasterConfig.xml Generated!");
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
                if (File.Exists("MasterConfig.xml"))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "MasterConfig.xml",
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


        private void inputHelp(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("help.txt"))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "help.txt",
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
                    AppendWarning("info file not found!");
                }
            }
            catch (Exception ex)
            {
                AppendError(ex.ToString());
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
        public void AppendReadbackText(string readbackText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.Cyan;
            ConsoleOutput.AppendText(readbackText);

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
            eventButton1.Text = config.EventButton1Name;
            eventButton1.Tag = config.EventButton1Content;
            HighlightIfAssigned(eventButton1);

            eventButton2.Text = config.EventButton2Name;
            eventButton2.Tag = config.EventButton2Content;
            HighlightIfAssigned(eventButton2);

            eventButton3.Text = config.EventButton3Name;
            eventButton3.Tag = config.EventButton3Content;
            HighlightIfAssigned(eventButton3);

            eventButton4.Text = config.EventButton4Name;
            eventButton4.Tag = config.EventButton4Content;
            HighlightIfAssigned(eventButton4);

            eventButton5.Text = config.EventButton5Name;
            eventButton5.Tag = config.EventButton5Content;
            HighlightIfAssigned(eventButton5);

            eventButton6.Text = config.EventButton6Name;
            eventButton6.Tag = config.EventButton6Content;
            HighlightIfAssigned(eventButton6);

            eventButton7.Text = config.EventButton7Name;
            eventButton7.Tag = config.EventButton7Content;
            HighlightIfAssigned(eventButton7);

            eventButton8.Text = config.EventButton8Name;
            eventButton8.Tag = config.EventButton8Content;
            HighlightIfAssigned(eventButton8);

            eventButton9.Text = config.EventButton9Name;
            eventButton9.Tag = config.EventButton9Content;
            HighlightIfAssigned(eventButton9);

            eventButton10.Text = config.EventButton10Name;
            eventButton10.Tag = config.EventButton10Content;
            HighlightIfAssigned(eventButton10);

            eventButton11.Text = config.EventButton11Name;
            eventButton11.Tag = config.EventButton11Content;
            HighlightIfAssigned(eventButton11);

            eventButton12.Text = config.EventButton12Name;
            eventButton12.Tag = config.EventButton12Content;
            HighlightIfAssigned(eventButton12);

            eventButton13.Text = config.EventButton13Name;
            eventButton13.Tag = config.EventButton13Content;
            HighlightIfAssigned(eventButton13);

            eventButton14.Text = config.EventButton14Name;
            eventButton14.Tag = config.EventButton14Content;
            HighlightIfAssigned(eventButton14);

            eventButton15.Text = config.EventButton15Name;
            eventButton15.Tag = config.EventButton15Content;
            HighlightIfAssigned(eventButton15);

            eventButton16.Text = config.EventButton16Name;
            eventButton16.Tag = config.EventButton16Content;
            HighlightIfAssigned(eventButton16);

            eventButton17.Text = config.EventButton17Name;
            eventButton17.Tag = config.EventButton17Content;
            HighlightIfAssigned(eventButton17);

            eventButton18.Text = config.EventButton18Name;
            eventButton18.Tag = config.EventButton18Content;
            HighlightIfAssigned(eventButton18);

            eventButton19.Text = config.EventButton19Name;
            eventButton19.Tag = config.EventButton19Content;
            HighlightIfAssigned(eventButton19);

            eventButton20.Text = config.EventButton20Name;
            eventButton20.Tag = config.EventButton20Content;
            HighlightIfAssigned(eventButton20);

            eventButton21.Text = config.EventButton21Name;
            eventButton21.Tag = config.EventButton21Content;
            HighlightIfAssigned(eventButton21);

            eventButton22.Text = config.EventButton22Name;
            eventButton22.Tag = config.EventButton22Content;
            HighlightIfAssigned(eventButton22);

            eventButton23.Text = config.EventButton23Name;
            eventButton23.Tag = config.EventButton23Content;
            HighlightIfAssigned(eventButton23);

            eventButton24.Text = config.EventButton24Name;
            eventButton24.Tag = config.EventButton24Content;
            HighlightIfAssigned(eventButton24);

            eventButton25.Text = config.EventButton25Name;
            eventButton25.Tag = config.EventButton25Content;
            HighlightIfAssigned(eventButton25);

            eventButton26.Text = config.EventButton26Name;
            eventButton26.Tag = config.EventButton26Content;
            HighlightIfAssigned(eventButton26);

            eventButton27.Text = config.EventButton27Name;
            eventButton27.Tag = config.EventButton27Content;
            HighlightIfAssigned(eventButton27);

            eventButton28.Text = config.EventButton28Name;
            eventButton28.Tag = config.EventButton28Content;
            HighlightIfAssigned(eventButton28);

            eventButton29.Text = config.EventButton29Name;
            eventButton29.Tag = config.EventButton29Content;
            HighlightIfAssigned(eventButton29);

            eventButton30.Text = config.EventButton30Name;
            eventButton30.Tag = config.EventButton30Content;
            HighlightIfAssigned(eventButton30);

            eventButton31.Text = config.EventButton31Name;
            eventButton31.Tag = config.EventButton31Content;
            HighlightIfAssigned(eventButton31);

            eventButton32.Text = config.EventButton32Name;
            eventButton32.Tag = config.EventButton32Content;
            HighlightIfAssigned(eventButton32);

        }




        //Deprecated but Bricking:
        private void testButton(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void richTextSlavePort_TextChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e) { }
        //Brick end

        private void buttonAction1(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton1.Tag.ToString());
        }

        private void buttonAction2(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton2.Tag.ToString());
        }

        private void buttonAction3(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton3.Tag.ToString());
        }

        private void buttonAction4(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton4.Tag.ToString());
        }

        private void buttonAction5(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton5.Tag.ToString());
        }

        private void buttonAction6(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton6.Tag.ToString());
        }

        private void buttonAction7(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton7.Tag.ToString());
        }

        private void buttonAction8(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton8.Tag.ToString());
        }

        private void buttonAction9(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton9.Tag.ToString());
        }

        private void buttonAction10(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton10.Tag.ToString());
        }

        private void buttonAction11(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton11.Tag.ToString());
        }

        private void buttonAction12(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton12.Tag.ToString());
        }

        private void buttonAction13(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton13.Tag.ToString());
        }

        private void buttonAction14(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton14.Tag.ToString());
        }
        private void buttonAction15(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton15.Tag.ToString());
        }

        private void buttonAction16(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton16.Tag.ToString());
        }
        private void buttonAction17(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton17.Tag.ToString());
        }

        private void buttonAction18(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton18.Tag.ToString());
        }

        private void buttonAction19(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton19.Tag.ToString());
        }

        private void buttonAction20(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton20.Tag.ToString());
        }

        private void buttonAction21(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton21.Tag.ToString());
        }

        private void buttonAction22(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton22.Tag.ToString());
        }

        private void buttonAction23(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton23.Tag.ToString());
        }

        private void buttonAction24(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton24.Tag.ToString());
        }

        private void buttonAction25(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton25.Tag.ToString());
        }

        private void buttonAction26(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton26.Tag.ToString());
        }

        private void buttonAction27(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton27.Tag.ToString());
        }

        private void buttonAction28(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton28.Tag.ToString());
        }

        private void buttonAction29(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton29.Tag.ToString());
        }

        private void buttonAction30(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton30.Tag.ToString());
        }

        private void buttonAction31(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton31.Tag.ToString());
        }

        private void buttonAction32(object sender, EventArgs e)
        {
            Program.SendMessage(eventButton32.Tag.ToString());
        }



        private void inputWanChanged(object sender, EventArgs e)
        {
            MessageBox.Show("WAN Mode: \n\nOn: Invalid Responses are filtered \nOff: Invalid Responses are displayed ", "RCT", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }






        private async void delCFG(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset the configuration?",
                "Reset Config",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
            {
                AppendInfoText("Reset cancelled by user.");
                return;
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MasterConfig.xml");

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                AppendInfoText("Config deleted.");
            }
            else
            {
                AppendWarning("MasterConfig.xml does not exist.");
            }

            await Task.Delay(250);

            Config defaultConfig = CreateDefaultConfig();
            Program.SaveConfigFile(defaultConfig, "MasterConfig.xml");
            await Task.Delay(200);
            reload_CFG(null, null);
        }

        private Config CreateDefaultConfig()
        {
            return new Config
            {
                HostName = "HostName",
                SlaveIP = "127.0.0.1",
                SlavePort = 65000,
                Token = "12345",
                WanMode = false,

                EventButton1Name = "none",
                EventButton1Content = "empty",
                EventButton2Name = "none",
                EventButton2Content = "empty",
                EventButton3Name = "none",
                EventButton3Content = "empty",
                EventButton4Name = "none",
                EventButton4Content = "empty",
                EventButton5Name = "none",
                EventButton5Content = "empty",
                EventButton6Name = "none",
                EventButton6Content = "empty",
                EventButton7Name = "none",
                EventButton7Content = "empty",
                EventButton8Name = "none",
                EventButton8Content = "empty",
                EventButton9Name = "none",
                EventButton9Content = "empty",
                EventButton10Name = "none",
                EventButton10Content = "empty",
                EventButton11Name = "none",
                EventButton11Content = "empty",
                EventButton12Name = "none",
                EventButton12Content = "empty",
                EventButton13Name = "none",
                EventButton13Content = "empty",
                EventButton14Name = "none",
                EventButton14Content = "empty",
                EventButton15Name = "none",
                EventButton15Content = "empty",
                EventButton16Name = "none",
                EventButton16Content = "empty",
                EventButton17Name = "none",
                EventButton17Content = "empty",
                EventButton18Name = "none",
                EventButton18Content = "empty",
                EventButton19Name = "none",
                EventButton19Content = "empty",
                EventButton20Name = "none",
                EventButton20Content = "empty",
                EventButton21Name = "none",
                EventButton21Content = "empty",
                EventButton22Name = "none",
                EventButton22Content = "empty",
                EventButton23Name = "none",
                EventButton23Content = "empty",
                EventButton24Name = "none",
                EventButton24Content = "empty",
                EventButton25Name = "none",
                EventButton25Content = "empty",
                EventButton26Name = "none",
                EventButton26Content = "empty",
                EventButton27Name = "none",
                EventButton27Content = "empty",
                EventButton28Name = "none",
                EventButton28Content = "empty",
                EventButton29Name = "none",
                EventButton29Content = "empty",
                EventButton30Name = "none",
                EventButton30Content = "empty",
                EventButton31Name = "none",
                EventButton31Content = "empty",
                EventButton32Name = "none",
                EventButton32Content = "empty"
            };
        }


        private void HighlightIfAssigned(Button button)
        {
            string content = button.Tag?.ToString() ?? "";

            if (!string.Equals(content, "empty", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(content, "none", StringComparison.OrdinalIgnoreCase))
            {
                button.BackColor = Color.Aqua;
            }
            else
            {
                button.BackColor = Color.White;
            }

        }


        private void inputUpdate(object sender, EventArgs e)
        {
            AppendWarning("\nAutomatic Updates are not available yet.\n Please visit:\n https://rehoga-interactive.com/remote-control-terminal \n and crosscheck the version number\n");
            AppendError("ALWAYS UPDATE SLAVES TOO!! DIFFERENT VERSIONS CAN CAUSE ISSUES");
        }

    }
}
