namespace RCT_Master
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextSlaveIP = new RichTextBox();
            richTextSlavePort = new RichTextBox();
            panel1 = new Panel();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            richTextHostname = new RichTextBox();
            label3 = new Label();
            richTextToken = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            ConsoleOutput = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            button17 = new Button();
            button18 = new Button();
            button3 = new Button();
            label7 = new Label();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button12 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextSlaveIP
            // 
            richTextSlaveIP.BackColor = SystemColors.InfoText;
            richTextSlaveIP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextSlaveIP.ForeColor = Color.White;
            richTextSlaveIP.Location = new Point(27, 204);
            richTextSlaveIP.Name = "richTextSlaveIP";
            richTextSlaveIP.Size = new Size(130, 31);
            richTextSlaveIP.TabIndex = 0;
            richTextSlaveIP.Text = "255.255.255.255";
            // 
            // richTextSlavePort
            // 
            richTextSlavePort.BackColor = SystemColors.InfoText;
            richTextSlavePort.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextSlavePort.ForeColor = Color.White;
            richTextSlavePort.Location = new Point(27, 272);
            richTextSlavePort.Name = "richTextSlavePort";
            richTextSlavePort.Size = new Size(130, 31);
            richTextSlavePort.TabIndex = 1;
            richTextSlavePort.Text = "65535";
            richTextSlavePort.TextChanged += richTextSlavePort_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(richTextHostname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(richTextToken);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextSlavePort);
            panel1.Controls.Add(richTextSlaveIP);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 444);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 12);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 3;
            label5.Text = "Slave Settings";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(27, 371);
            button2.Name = "button2";
            button2.Size = new Size(130, 47);
            button2.TabIndex = 9;
            button2.Text = "RELOAD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += reload_CFG;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(27, 318);
            button1.Name = "button1";
            button1.Size = new Size(130, 47);
            button1.TabIndex = 8;
            button1.Text = "APPLY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += save_CFG;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 49);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "Hostname:";
            // 
            // richTextHostname
            // 
            richTextHostname.BackColor = SystemColors.InfoText;
            richTextHostname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextHostname.ForeColor = Color.White;
            richTextHostname.Location = new Point(27, 67);
            richTextHostname.Name = "richTextHostname";
            richTextHostname.Size = new Size(130, 31);
            richTextHostname.TabIndex = 6;
            richTextHostname.Text = "Host1";
            richTextHostname.TextChanged += richTextBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 117);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Token:";
            // 
            // richTextToken
            // 
            richTextToken.BackColor = SystemColors.InfoText;
            richTextToken.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextToken.ForeColor = Color.White;
            richTextToken.Location = new Point(27, 135);
            richTextToken.Name = "richTextToken";
            richTextToken.Size = new Size(130, 31);
            richTextToken.TabIndex = 4;
            richTextToken.Text = "abcde12345";
            richTextToken.TextChanged += richTextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 186);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "IPv4:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 254);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Port:";
            // 
            // ConsoleOutput
            // 
            ConsoleOutput.BackColor = SystemColors.MenuText;
            ConsoleOutput.ForeColor = SystemColors.Window;
            ConsoleOutput.Location = new Point(667, 13);
            ConsoleOutput.Name = "ConsoleOutput";
            ConsoleOutput.Size = new Size(405, 565);
            ConsoleOutput.TabIndex = 3;
            ConsoleOutput.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ReHoGaBanner3_0_Transparent;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BannerRCT1;
            pictureBox2.Location = new Point(256, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 113);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 12;
            label6.Text = "Version: 1.0.0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button17);
            panel2.Controls.Add(button18);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(382, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 116);
            panel2.TabIndex = 13;
            // 
            // button17
            // 
            button17.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(134, 27);
            button17.Name = "button17";
            button17.Size = new Size(128, 39);
            button17.TabIndex = 7;
            button17.Text = "Clear Console";
            button17.UseVisualStyleBackColor = true;
            button17.Click += buttonClearConsole;
            // 
            // button18
            // 
            button18.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(3, 27);
            button18.Name = "button18";
            button18.Size = new Size(128, 39);
            button18.TabIndex = 6;
            button18.Text = "Open Log";
            button18.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(134, 72);
            button3.Name = "button3";
            button3.Size = new Size(128, 39);
            button3.TabIndex = 5;
            button3.Text = "Test Connection";
            button3.UseVisualStyleBackColor = true;
            button3.Click += testConnection;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(95, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 4;
            label7.Text = "General";
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 72);
            button4.Name = "button4";
            button4.Size = new Size(128, 39);
            button4.TabIndex = 1;
            button4.Text = "Open Config";
            button4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button13);
            flowLayoutPanel1.Controls.Add(button14);
            flowLayoutPanel1.Controls.Add(button15);
            flowLayoutPanel1.Controls.Add(button16);
            flowLayoutPanel1.Location = new Point(218, 134);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(431, 444);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // button12
            // 
            button12.Location = new Point(3, 3);
            button12.Name = "button12";
            button12.Size = new Size(208, 68);
            button12.TabIndex = 7;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(217, 3);
            button5.Name = "button5";
            button5.Size = new Size(208, 68);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 77);
            button6.Name = "button6";
            button6.Size = new Size(208, 68);
            button6.TabIndex = 9;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(217, 77);
            button7.Name = "button7";
            button7.Size = new Size(208, 68);
            button7.TabIndex = 10;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(3, 151);
            button8.Name = "button8";
            button8.Size = new Size(208, 68);
            button8.TabIndex = 11;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(217, 151);
            button9.Name = "button9";
            button9.Size = new Size(208, 68);
            button9.TabIndex = 12;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(3, 225);
            button10.Name = "button10";
            button10.Size = new Size(208, 68);
            button10.TabIndex = 13;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(217, 225);
            button11.Name = "button11";
            button11.Size = new Size(208, 68);
            button11.TabIndex = 14;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(3, 299);
            button13.Name = "button13";
            button13.Size = new Size(208, 68);
            button13.TabIndex = 15;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(217, 299);
            button14.Name = "button14";
            button14.Size = new Size(208, 68);
            button14.TabIndex = 16;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(3, 373);
            button15.Name = "button15";
            button15.Size = new Size(208, 68);
            button15.TabIndex = 17;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(217, 373);
            button16.Name = "button16";
            button16.Size = new Size(208, 68);
            button16.TabIndex = 18;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(12, 585);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 17);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://rehoga-interactive.com/";
            linkLabel1.Click += openWebsite;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(linkLabel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ConsoleOutput);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RCT-Master";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextSlaveIP;
        private RichTextBox richTextSlavePort;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextToken;
        private Label label4;
        private RichTextBox richTextHostname;
        private Button button1;
        private Button button2;
        private Label label5;
        private RichTextBox ConsoleOutput;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Button button4;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button12;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private LinkLabel linkLabel1;
    }
}
