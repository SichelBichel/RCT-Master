namespace RCT_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConsoleOutput.SelectionColor = Color.Green;
            ConsoleOutput.AppendText("TST Applied\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsoleOutput.SelectionColor = Color.Red;
            ConsoleOutput.AppendText("TST LOADED\n");
        }
    }
}
