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
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Location = new Point(38, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 444);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 11);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 3;
            label5.Text = "Slave Settings";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(27, 371);
            button2.Name = "button2";
            button2.Size = new Size(130, 47);
            button2.TabIndex = 9;
            button2.Text = "RELOAD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(27, 318);
            button1.Name = "button1";
            button1.Size = new Size(130, 47);
            button1.TabIndex = 8;
            button1.Text = "APPLY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            ConsoleOutput.Size = new Size(357, 583);
            ConsoleOutput.TabIndex = 3;
            ConsoleOutput.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 108);
            label6.Name = "label6";
            label6.Size = new Size(247, 29);
            label6.TabIndex = 4;
            label6.Text = "RemoteControlTerminal";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.ReHoGaBanner3_0_Transparent;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 608);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(ConsoleOutput);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RCT-Master";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label6;
        private PictureBox pictureBox1;
    }
}
