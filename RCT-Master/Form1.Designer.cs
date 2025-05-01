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
            richTextSlaveIP = new RichTextBox();
            richTextSlavePort = new RichTextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextSlaveIP
            // 
            richTextSlaveIP.BackColor = SystemColors.InfoText;
            richTextSlaveIP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextSlaveIP.ForeColor = Color.Yellow;
            richTextSlaveIP.Location = new Point(25, 36);
            richTextSlaveIP.Name = "richTextSlaveIP";
            richTextSlaveIP.Size = new Size(130, 31);
            richTextSlaveIP.TabIndex = 0;
            richTextSlaveIP.Text = "255.255.255.255";
            // 
            // richTextSlavePort
            // 
            richTextSlavePort.BackColor = SystemColors.InfoText;
            richTextSlavePort.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextSlavePort.ForeColor = Color.Yellow;
            richTextSlavePort.Location = new Point(25, 104);
            richTextSlavePort.Name = "richTextSlavePort";
            richTextSlavePort.Size = new Size(130, 31);
            richTextSlavePort.TabIndex = 1;
            richTextSlavePort.Text = "65535";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextSlavePort);
            panel1.Controls.Add(richTextSlaveIP);
            panel1.Location = new Point(139, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 148);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 86);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Port:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 18);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "IPv4:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "RCT-Master";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextSlaveIP;
        private RichTextBox richTextSlavePort;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
