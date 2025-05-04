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
            button5 = new Button();
            WanCheckBox = new CheckBox();
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
            eventButton1 = new Button();
            eventButton2 = new Button();
            eventButton3 = new Button();
            eventButton4 = new Button();
            eventButton5 = new Button();
            eventButton6 = new Button();
            eventButton7 = new Button();
            eventButton8 = new Button();
            eventButton9 = new Button();
            eventButton10 = new Button();
            eventButton11 = new Button();
            eventButton12 = new Button();
            eventButton13 = new Button();
            eventButton14 = new Button();
            eventButton15 = new Button();
            eventButton16 = new Button();
            eventButton17 = new Button();
            eventButton18 = new Button();
            eventButton19 = new Button();
            eventButton20 = new Button();
            eventButton21 = new Button();
            eventButton22 = new Button();
            eventButton23 = new Button();
            eventButton24 = new Button();
            eventButton25 = new Button();
            eventButton26 = new Button();
            eventButton27 = new Button();
            eventButton28 = new Button();
            eventButton29 = new Button();
            eventButton30 = new Button();
            eventButton31 = new Button();
            eventButton32 = new Button();
            linkLabel1 = new LinkLabel();
            button6 = new Button();
            button7 = new Button();
            label8 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            richTextSlaveIP.Location = new Point(27, 170);
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
            richTextSlavePort.Location = new Point(27, 222);
            richTextSlavePort.Name = "richTextSlavePort";
            richTextSlavePort.Size = new Size(130, 31);
            richTextSlavePort.TabIndex = 1;
            richTextSlavePort.Text = "65534";
            richTextSlavePort.TextChanged += richTextSlavePort_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(WanCheckBox);
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
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Arial", 12F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(27, 388);
            button5.Name = "button5";
            button5.Size = new Size(130, 40);
            button5.TabIndex = 11;
            button5.Text = "RESET";
            button5.UseVisualStyleBackColor = false;
            button5.Click += delCFG;
            // 
            // WanCheckBox
            // 
            WanCheckBox.AutoSize = true;
            WanCheckBox.Location = new Point(45, 267);
            WanCheckBox.Name = "WanCheckBox";
            WanCheckBox.Size = new Size(88, 19);
            WanCheckBox.TabIndex = 10;
            WanCheckBox.Text = "WAN Mode";
            WanCheckBox.UseVisualStyleBackColor = true;
            WanCheckBox.Click += inputWanChanged;
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
            button2.Location = new Point(27, 342);
            button2.Name = "button2";
            button2.Size = new Size(130, 40);
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
            button1.Location = new Point(27, 298);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 8;
            button1.Text = "APPLY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += save_CFG;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 48);
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
            richTextHostname.Location = new Point(27, 66);
            richTextHostname.Name = "richTextHostname";
            richTextHostname.Size = new Size(130, 31);
            richTextHostname.TabIndex = 6;
            richTextHostname.Text = "Host1";
            richTextHostname.TextChanged += richTextBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 100);
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
            richTextToken.Location = new Point(27, 118);
            richTextToken.Name = "richTextToken";
            richTextToken.Size = new Size(130, 31);
            richTextToken.TabIndex = 4;
            richTextToken.Text = "abcde12345";
            richTextToken.TextChanged += richTextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 152);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "IPv4:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 204);
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
            ConsoleOutput.ReadOnly = true;
            ConsoleOutput.Size = new Size(405, 589);
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
            pictureBox2.Size = new Size(120, 96);
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
            button18.Click += openLog;
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
            button4.Click += openCFG;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(eventButton1);
            flowLayoutPanel1.Controls.Add(eventButton2);
            flowLayoutPanel1.Controls.Add(eventButton3);
            flowLayoutPanel1.Controls.Add(eventButton4);
            flowLayoutPanel1.Controls.Add(eventButton5);
            flowLayoutPanel1.Controls.Add(eventButton6);
            flowLayoutPanel1.Controls.Add(eventButton7);
            flowLayoutPanel1.Controls.Add(eventButton8);
            flowLayoutPanel1.Controls.Add(eventButton9);
            flowLayoutPanel1.Controls.Add(eventButton10);
            flowLayoutPanel1.Controls.Add(eventButton11);
            flowLayoutPanel1.Controls.Add(eventButton12);
            flowLayoutPanel1.Controls.Add(eventButton13);
            flowLayoutPanel1.Controls.Add(eventButton14);
            flowLayoutPanel1.Controls.Add(eventButton15);
            flowLayoutPanel1.Controls.Add(eventButton16);
            flowLayoutPanel1.Controls.Add(eventButton17);
            flowLayoutPanel1.Controls.Add(eventButton18);
            flowLayoutPanel1.Controls.Add(eventButton19);
            flowLayoutPanel1.Controls.Add(eventButton20);
            flowLayoutPanel1.Controls.Add(eventButton21);
            flowLayoutPanel1.Controls.Add(eventButton22);
            flowLayoutPanel1.Controls.Add(eventButton23);
            flowLayoutPanel1.Controls.Add(eventButton24);
            flowLayoutPanel1.Controls.Add(eventButton25);
            flowLayoutPanel1.Controls.Add(eventButton26);
            flowLayoutPanel1.Controls.Add(eventButton27);
            flowLayoutPanel1.Controls.Add(eventButton28);
            flowLayoutPanel1.Controls.Add(eventButton29);
            flowLayoutPanel1.Controls.Add(eventButton30);
            flowLayoutPanel1.Controls.Add(eventButton31);
            flowLayoutPanel1.Controls.Add(eventButton32);
            flowLayoutPanel1.Location = new Point(218, 134);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(431, 465);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // eventButton1
            // 
            eventButton1.Location = new Point(3, 3);
            eventButton1.Name = "eventButton1";
            eventButton1.Size = new Size(200, 60);
            eventButton1.TabIndex = 7;
            eventButton1.Text = "none";
            eventButton1.UseVisualStyleBackColor = true;
            eventButton1.Click += buttonAction1;
            // 
            // eventButton2
            // 
            eventButton2.Location = new Point(209, 3);
            eventButton2.Name = "eventButton2";
            eventButton2.Size = new Size(200, 60);
            eventButton2.TabIndex = 8;
            eventButton2.Text = "none";
            eventButton2.UseVisualStyleBackColor = true;
            eventButton2.Click += buttonAction2;
            // 
            // eventButton3
            // 
            eventButton3.Location = new Point(3, 69);
            eventButton3.Name = "eventButton3";
            eventButton3.Size = new Size(200, 60);
            eventButton3.TabIndex = 9;
            eventButton3.Text = "none";
            eventButton3.UseVisualStyleBackColor = true;
            eventButton3.Click += buttonAction3;
            // 
            // eventButton4
            // 
            eventButton4.Location = new Point(209, 69);
            eventButton4.Name = "eventButton4";
            eventButton4.Size = new Size(200, 60);
            eventButton4.TabIndex = 10;
            eventButton4.Text = "none";
            eventButton4.UseVisualStyleBackColor = true;
            eventButton4.Click += buttonAction4;
            // 
            // eventButton5
            // 
            eventButton5.Location = new Point(3, 135);
            eventButton5.Name = "eventButton5";
            eventButton5.Size = new Size(200, 60);
            eventButton5.TabIndex = 11;
            eventButton5.Text = "none";
            eventButton5.UseVisualStyleBackColor = true;
            eventButton5.Click += buttonAction5;
            // 
            // eventButton6
            // 
            eventButton6.Location = new Point(209, 135);
            eventButton6.Name = "eventButton6";
            eventButton6.Size = new Size(200, 60);
            eventButton6.TabIndex = 12;
            eventButton6.Text = "none";
            eventButton6.UseVisualStyleBackColor = true;
            eventButton6.Click += buttonAction6;
            // 
            // eventButton7
            // 
            eventButton7.Location = new Point(3, 201);
            eventButton7.Name = "eventButton7";
            eventButton7.Size = new Size(200, 60);
            eventButton7.TabIndex = 13;
            eventButton7.Text = "none";
            eventButton7.UseVisualStyleBackColor = true;
            eventButton7.Click += buttonAction7;
            // 
            // eventButton8
            // 
            eventButton8.Location = new Point(209, 201);
            eventButton8.Name = "eventButton8";
            eventButton8.Size = new Size(200, 60);
            eventButton8.TabIndex = 14;
            eventButton8.Text = "none";
            eventButton8.UseVisualStyleBackColor = true;
            eventButton8.Click += buttonAction8;
            // 
            // eventButton9
            // 
            eventButton9.Location = new Point(3, 267);
            eventButton9.Name = "eventButton9";
            eventButton9.Size = new Size(200, 60);
            eventButton9.TabIndex = 15;
            eventButton9.Text = "none";
            eventButton9.UseVisualStyleBackColor = true;
            eventButton9.Click += buttonAction9;
            // 
            // eventButton10
            // 
            eventButton10.Location = new Point(209, 267);
            eventButton10.Name = "eventButton10";
            eventButton10.Size = new Size(200, 60);
            eventButton10.TabIndex = 16;
            eventButton10.Text = "none";
            eventButton10.UseVisualStyleBackColor = true;
            eventButton10.Click += buttonAction10;
            // 
            // eventButton11
            // 
            eventButton11.Location = new Point(3, 333);
            eventButton11.Name = "eventButton11";
            eventButton11.Size = new Size(200, 60);
            eventButton11.TabIndex = 17;
            eventButton11.Text = "none";
            eventButton11.UseVisualStyleBackColor = true;
            eventButton11.Click += buttonAction11;
            // 
            // eventButton12
            // 
            eventButton12.Location = new Point(209, 333);
            eventButton12.Name = "eventButton12";
            eventButton12.Size = new Size(200, 60);
            eventButton12.TabIndex = 18;
            eventButton12.Text = "none";
            eventButton12.UseVisualStyleBackColor = true;
            eventButton12.Click += buttonAction12;
            // 
            // eventButton13
            // 
            eventButton13.Location = new Point(3, 399);
            eventButton13.Name = "eventButton13";
            eventButton13.Size = new Size(200, 60);
            eventButton13.TabIndex = 19;
            eventButton13.Text = "none";
            eventButton13.UseVisualStyleBackColor = true;
            eventButton13.Click += buttonAction13;
            // 
            // eventButton14
            // 
            eventButton14.Location = new Point(209, 399);
            eventButton14.Name = "eventButton14";
            eventButton14.Size = new Size(200, 60);
            eventButton14.TabIndex = 20;
            eventButton14.Text = "none";
            eventButton14.UseVisualStyleBackColor = true;
            eventButton14.Click += buttonAction14;
            // 
            // eventButton15
            // 
            eventButton15.Location = new Point(3, 465);
            eventButton15.Name = "eventButton15";
            eventButton15.Size = new Size(200, 60);
            eventButton15.TabIndex = 21;
            eventButton15.Text = "none";
            eventButton15.UseVisualStyleBackColor = true;
            eventButton15.Click += buttonAction15;
            // 
            // eventButton16
            // 
            eventButton16.Location = new Point(209, 465);
            eventButton16.Name = "eventButton16";
            eventButton16.Size = new Size(200, 60);
            eventButton16.TabIndex = 22;
            eventButton16.Text = "none";
            eventButton16.UseVisualStyleBackColor = true;
            eventButton16.Click += buttonAction16;
            // 
            // eventButton17
            // 
            eventButton17.Location = new Point(3, 531);
            eventButton17.Name = "eventButton17";
            eventButton17.Size = new Size(200, 60);
            eventButton17.TabIndex = 23;
            eventButton17.Text = "none";
            eventButton17.UseVisualStyleBackColor = true;
            eventButton17.Click += buttonAction17;
            // 
            // eventButton18
            // 
            eventButton18.Location = new Point(209, 531);
            eventButton18.Name = "eventButton18";
            eventButton18.Size = new Size(200, 60);
            eventButton18.TabIndex = 24;
            eventButton18.Text = "none";
            eventButton18.UseVisualStyleBackColor = true;
            eventButton18.Click += buttonAction18;
            // 
            // eventButton19
            // 
            eventButton19.Location = new Point(3, 597);
            eventButton19.Name = "eventButton19";
            eventButton19.Size = new Size(200, 60);
            eventButton19.TabIndex = 25;
            eventButton19.Text = "none";
            eventButton19.UseVisualStyleBackColor = true;
            eventButton19.Click += buttonAction19;
            // 
            // eventButton20
            // 
            eventButton20.Location = new Point(209, 597);
            eventButton20.Name = "eventButton20";
            eventButton20.Size = new Size(200, 60);
            eventButton20.TabIndex = 26;
            eventButton20.Text = "none";
            eventButton20.UseVisualStyleBackColor = true;
            eventButton20.Click += buttonAction20;
            // 
            // eventButton21
            // 
            eventButton21.Location = new Point(3, 663);
            eventButton21.Name = "eventButton21";
            eventButton21.Size = new Size(200, 60);
            eventButton21.TabIndex = 27;
            eventButton21.Text = "none";
            eventButton21.UseVisualStyleBackColor = true;
            eventButton21.Click += buttonAction21;
            // 
            // eventButton22
            // 
            eventButton22.Location = new Point(209, 663);
            eventButton22.Name = "eventButton22";
            eventButton22.Size = new Size(200, 60);
            eventButton22.TabIndex = 28;
            eventButton22.Text = "none";
            eventButton22.UseVisualStyleBackColor = true;
            eventButton22.Click += buttonAction22;
            // 
            // eventButton23
            // 
            eventButton23.Location = new Point(3, 729);
            eventButton23.Name = "eventButton23";
            eventButton23.Size = new Size(200, 60);
            eventButton23.TabIndex = 29;
            eventButton23.Text = "none";
            eventButton23.UseVisualStyleBackColor = true;
            eventButton23.Click += buttonAction23;
            // 
            // eventButton24
            // 
            eventButton24.Location = new Point(209, 729);
            eventButton24.Name = "eventButton24";
            eventButton24.Size = new Size(200, 60);
            eventButton24.TabIndex = 30;
            eventButton24.Text = "none";
            eventButton24.UseVisualStyleBackColor = true;
            eventButton24.Click += buttonAction24;
            // 
            // eventButton25
            // 
            eventButton25.Location = new Point(3, 795);
            eventButton25.Name = "eventButton25";
            eventButton25.Size = new Size(200, 60);
            eventButton25.TabIndex = 31;
            eventButton25.Text = "none";
            eventButton25.UseVisualStyleBackColor = true;
            eventButton25.Click += buttonAction25;
            // 
            // eventButton26
            // 
            eventButton26.Location = new Point(209, 795);
            eventButton26.Name = "eventButton26";
            eventButton26.Size = new Size(200, 60);
            eventButton26.TabIndex = 32;
            eventButton26.Text = "none";
            eventButton26.UseVisualStyleBackColor = true;
            eventButton26.Click += buttonAction26;
            // 
            // eventButton27
            // 
            eventButton27.Location = new Point(3, 861);
            eventButton27.Name = "eventButton27";
            eventButton27.Size = new Size(200, 60);
            eventButton27.TabIndex = 33;
            eventButton27.Text = "none";
            eventButton27.UseVisualStyleBackColor = true;
            eventButton27.Click += buttonAction27;
            // 
            // eventButton28
            // 
            eventButton28.Location = new Point(209, 861);
            eventButton28.Name = "eventButton28";
            eventButton28.Size = new Size(200, 60);
            eventButton28.TabIndex = 34;
            eventButton28.Text = "none";
            eventButton28.UseVisualStyleBackColor = true;
            eventButton28.Click += buttonAction28;
            // 
            // eventButton29
            // 
            eventButton29.Location = new Point(3, 927);
            eventButton29.Name = "eventButton29";
            eventButton29.Size = new Size(200, 60);
            eventButton29.TabIndex = 35;
            eventButton29.Text = "none";
            eventButton29.UseVisualStyleBackColor = true;
            eventButton29.Click += buttonAction29;
            // 
            // eventButton30
            // 
            eventButton30.Location = new Point(209, 927);
            eventButton30.Name = "eventButton30";
            eventButton30.Size = new Size(200, 60);
            eventButton30.TabIndex = 36;
            eventButton30.Text = "none";
            eventButton30.UseVisualStyleBackColor = true;
            eventButton30.Click += buttonAction30;
            // 
            // eventButton31
            // 
            eventButton31.Location = new Point(3, 993);
            eventButton31.Name = "eventButton31";
            eventButton31.Size = new Size(200, 60);
            eventButton31.TabIndex = 37;
            eventButton31.Text = "none";
            eventButton31.UseVisualStyleBackColor = true;
            eventButton31.Click += buttonAction31;
            // 
            // eventButton32
            // 
            eventButton32.Location = new Point(209, 993);
            eventButton32.Name = "eventButton32";
            eventButton32.Size = new Size(200, 60);
            eventButton32.TabIndex = 38;
            eventButton32.Text = "none";
            eventButton32.UseVisualStyleBackColor = true;
            eventButton32.Click += buttonAction32;
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
            // button6
            // 
            button6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(93, 109);
            button6.Name = "button6";
            button6.Size = new Size(53, 23);
            button6.TabIndex = 16;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = true;
            button6.Click += inputUpdate;
            // 
            // button7
            // 
            button7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(146, 109);
            button7.Name = "button7";
            button7.Size = new Size(53, 23);
            button7.TabIndex = 17;
            button7.Text = "Help";
            button7.UseVisualStyleBackColor = true;
            button7.Click += inputHelp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(256, 108);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 18;
            label8.Text = "Master";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(label8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(linkLabel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ConsoleOutput);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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
        private Button eventButton1;
        private Button eventButton2;
        private Button eventButton3;
        private Button eventButton4;
        private Button eventButton5;
        private Button eventButton6;
        private Button eventButton7;
        private Button eventButton8;
        private Button eventButton9;
        private Button eventButton10;
        private Button eventButton11;
        private Button eventButton12;
        private Button button17;
        private Button button18;
        private LinkLabel linkLabel1;
        private Button eventButton13;
        private Button eventButton14;
        private Button button5;
        private CheckBox WanCheckBox;
        private Button button6;
        private Button button7;
        private Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button eventButton15;
        private Button eventButton16;
        private Button eventButton17;
        private Button eventButton18;
        private Button eventButton19;
        private Button eventButton20;
        private Button eventButton21;
        private Button eventButton22;
        private Button eventButton23;
        private Button eventButton24;
        private Button eventButton25;
        private Button eventButton26;
        private Button eventButton27;
        private Button eventButton28;
        private Button eventButton29;
        private Button eventButton30;
        private Button eventButton31;
        private Button eventButton32;
    }
}
