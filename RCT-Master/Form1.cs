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

        private async void PostInit()
        {

            await Task.Delay(100);
            reload_CFG(null, null);

        }
        private void save_CFG(object sender, EventArgs e)
        {
            AppendBlankText("Saving CFG...");
            Config config = new Config
            {
                HostName = richTextHostname.Text,
                SlaveIP = richTextSlaveIP.Text,
                SlavePort = int.Parse(richTextSlavePort.Text),
                Token = richTextToken.Text
            };
            Program.SaveConfigFile(config, "config.xml");
        }

        private void reload_CFG(object sender, EventArgs e)
        {
            AppendBlankText("Reloading CFG...");
            Config config = Program.LoadConfig("config.xml");

            if (config != null)
            {
                richTextHostname.Text = config.HostName;
                richTextSlaveIP.Text = config.SlaveIP;
                richTextSlavePort.Text = config.SlavePort.ToString();
                richTextToken.Text = config.Token;
                AppendSuccess("CFG loaded and applied");
            }
            else
            {
                AppendError("CFG not loaded");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void AppendError(string errorText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.Red;
            ConsoleOutput.AppendText(errorText + "\n");
        }
        public void AppendSuccess(string successText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.LightGreen;
            ConsoleOutput.AppendText(successText + "\n");
        }
        public void AppendInfoText(string infoText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.LightYellow;
            ConsoleOutput.AppendText(infoText + "\n");
        }
        public void AppendBlankText(string blankText)
        {
            ConsoleOutput.SelectionColor = System.Drawing.Color.White;
            ConsoleOutput.AppendText(blankText + "\n");
        }

    }
}
