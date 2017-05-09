namespace Comms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.verify = new System.Windows.Forms.Button();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.mode4_st = new System.Windows.Forms.TextBox();
            this.mode3_st = new System.Windows.Forms.TextBox();
            this.mode2_st = new System.Windows.Forms.TextBox();
            this.ch4_st = new System.Windows.Forms.TextBox();
            this.ch3_st = new System.Windows.Forms.TextBox();
            this.ch2_st = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.mode1_st = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ch1_st = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.drop1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.drop2 = new System.Windows.Forms.ComboBox();
            this.Apply = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.wait_measure = new System.Windows.Forms.TextBox();
            this.Run_btn = new System.Windows.Forms.Button();
            this.pir = new System.Windows.Forms.CheckBox();
            this.ascii = new System.Windows.Forms.CheckBox();
            this.csv = new System.Windows.Forms.CheckBox();
            this.overlay = new System.Windows.Forms.CheckBox();
            this.trials = new System.Windows.Forms.TextBox();
            this.suffix = new System.Windows.Forms.TextBox();
            this.wait = new System.Windows.Forms.TextBox();
            this.prefix = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.InitialDirectory = "C:\\Program Files (x86)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 992);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "4Track";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.verify);
            this.panel6.Controls.Add(this.textBox23);
            this.panel6.Controls.Add(this.textBox22);
            this.panel6.Controls.Add(this.textBox21);
            this.panel6.Controls.Add(this.mode4_st);
            this.panel6.Controls.Add(this.mode3_st);
            this.panel6.Controls.Add(this.mode2_st);
            this.panel6.Controls.Add(this.ch4_st);
            this.panel6.Controls.Add(this.ch3_st);
            this.panel6.Controls.Add(this.ch2_st);
            this.panel6.Controls.Add(this.textBox17);
            this.panel6.Controls.Add(this.textBox16);
            this.panel6.Controls.Add(this.mode1_st);
            this.panel6.Controls.Add(this.textBox8);
            this.panel6.Controls.Add(this.ch1_st);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(884, 996);
            this.panel6.TabIndex = 1;
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(345, 858);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(104, 35);
            this.verify.TabIndex = 24;
            this.verify.Text = "Verify";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // textBox23
            // 
            this.textBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox23.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Location = new System.Drawing.Point(3, 563);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(82, 19);
            this.textBox23.TabIndex = 23;
            this.textBox23.Text = "Channel 4";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox22.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Location = new System.Drawing.Point(3, 412);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(82, 19);
            this.textBox22.TabIndex = 22;
            this.textBox22.Text = "Channel 3";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox21.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Location = new System.Drawing.Point(3, 272);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(82, 19);
            this.textBox21.TabIndex = 21;
            this.textBox21.Text = "Channel 2";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mode4_st
            // 
            this.mode4_st.Location = new System.Drawing.Point(482, 560);
            this.mode4_st.Name = "mode4_st";
            this.mode4_st.Size = new System.Drawing.Size(212, 26);
            this.mode4_st.TabIndex = 20;
            // 
            // mode3_st
            // 
            this.mode3_st.Location = new System.Drawing.Point(482, 406);
            this.mode3_st.Name = "mode3_st";
            this.mode3_st.Size = new System.Drawing.Size(212, 26);
            this.mode3_st.TabIndex = 19;
            // 
            // mode2_st
            // 
            this.mode2_st.Location = new System.Drawing.Point(482, 269);
            this.mode2_st.Name = "mode2_st";
            this.mode2_st.Size = new System.Drawing.Size(212, 26);
            this.mode2_st.TabIndex = 18;
            // 
            // ch4_st
            // 
            this.ch4_st.Location = new System.Drawing.Point(132, 560);
            this.ch4_st.Name = "ch4_st";
            this.ch4_st.Size = new System.Drawing.Size(212, 26);
            this.ch4_st.TabIndex = 17;
            // 
            // ch3_st
            // 
            this.ch3_st.Location = new System.Drawing.Point(132, 409);
            this.ch3_st.Name = "ch3_st";
            this.ch3_st.Size = new System.Drawing.Size(212, 26);
            this.ch3_st.TabIndex = 16;
            // 
            // ch2_st
            // 
            this.ch2_st.Location = new System.Drawing.Point(132, 269);
            this.ch2_st.Name = "ch2_st";
            this.ch2_st.Size = new System.Drawing.Size(212, 26);
            this.ch2_st.TabIndex = 15;
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Location = new System.Drawing.Point(489, 46);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(204, 19);
            this.textBox17.TabIndex = 14;
            this.textBox17.Text = "Verfify mode connection";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox16.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(136, 46);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(208, 19);
            this.textBox16.TabIndex = 10;
            this.textBox16.Text = "Verify Channel connection";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mode1_st
            // 
            this.mode1_st.Location = new System.Drawing.Point(482, 118);
            this.mode1_st.Name = "mode1_st";
            this.mode1_st.Size = new System.Drawing.Size(212, 26);
            this.mode1_st.TabIndex = 11;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(3, 122);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 19);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Channel 1";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ch1_st
            // 
            this.ch1_st.Location = new System.Drawing.Point(132, 118);
            this.ch1_st.Name = "ch1_st";
            this.ch1_st.Size = new System.Drawing.Size(212, 26);
            this.ch1_st.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 1025);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.wait_measure);
            this.tabPage3.Controls.Add(this.Run_btn);
            this.tabPage3.Controls.Add(this.pir);
            this.tabPage3.Controls.Add(this.ascii);
            this.tabPage3.Controls.Add(this.csv);
            this.tabPage3.Controls.Add(this.overlay);
            this.tabPage3.Controls.Add(this.trials);
            this.tabPage3.Controls.Add(this.suffix);
            this.tabPage3.Controls.Add(this.wait);
            this.tabPage3.Controls.Add(this.prefix);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.browse_button);
            this.tabPage3.Controls.Add(this.path);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.config);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(888, 992);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ARTA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.drop1);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.drop2);
            this.panel1.Controls.Add(this.Apply);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 109);
            this.panel1.TabIndex = 45;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(58, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 19);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Channel";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drop1
            // 
            this.drop1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.drop1.Location = new System.Drawing.Point(164, 49);
            this.drop1.MaxDropDownItems = 4;
            this.drop1.Name = "drop1";
            this.drop1.Size = new System.Drawing.Size(121, 28);
            this.drop1.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(376, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 19);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "Mode";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drop2
            // 
            this.drop2.FormattingEnabled = true;
            this.drop2.Items.AddRange(new object[] {
            "Frequency Response",
            "Impedance Response ",
            "Impedance Calibration",
            "Cut off"});
            this.drop2.Location = new System.Drawing.Point(482, 43);
            this.drop2.Name = "drop2";
            this.drop2.Size = new System.Drawing.Size(172, 28);
            this.drop2.TabIndex = 15;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(681, 40);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(99, 37);
            this.Apply.TabIndex = 18;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(57, 428);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(418, 19);
            this.textBox4.TabIndex = 44;
            this.textBox4.Text = "Waiting time between Impedance response measurement";
            // 
            // wait_measure
            // 
            this.wait_measure.Location = new System.Drawing.Point(57, 454);
            this.wait_measure.Name = "wait_measure";
            this.wait_measure.Size = new System.Drawing.Size(100, 26);
            this.wait_measure.TabIndex = 43;
            // 
            // Run_btn
            // 
            this.Run_btn.Location = new System.Drawing.Point(368, 893);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(108, 32);
            this.Run_btn.TabIndex = 42;
            this.Run_btn.Text = "Run Arta";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click_1);
            // 
            // pir
            // 
            this.pir.AutoSize = true;
            this.pir.Location = new System.Drawing.Point(58, 876);
            this.pir.Name = "pir";
            this.pir.Size = new System.Drawing.Size(123, 24);
            this.pir.TabIndex = 41;
            this.pir.Text = "Save as PIR";
            this.pir.UseVisualStyleBackColor = true;
            // 
            // ascii
            // 
            this.ascii.AutoSize = true;
            this.ascii.Location = new System.Drawing.Point(58, 846);
            this.ascii.Name = "ascii";
            this.ascii.Size = new System.Drawing.Size(139, 24);
            this.ascii.TabIndex = 40;
            this.ascii.Text = "Save as ASCII";
            this.ascii.UseVisualStyleBackColor = true;
            // 
            // csv
            // 
            this.csv.AutoSize = true;
            this.csv.Location = new System.Drawing.Point(58, 816);
            this.csv.Name = "csv";
            this.csv.Size = new System.Drawing.Size(129, 24);
            this.csv.TabIndex = 39;
            this.csv.Text = "Save as CSV";
            this.csv.UseVisualStyleBackColor = true;
            // 
            // overlay
            // 
            this.overlay.AutoSize = true;
            this.overlay.Location = new System.Drawing.Point(58, 786);
            this.overlay.Name = "overlay";
            this.overlay.Size = new System.Drawing.Size(311, 24);
            this.overlay.TabIndex = 38;
            this.overlay.Text = "Create overlay between measurements";
            this.overlay.UseVisualStyleBackColor = true;
            // 
            // trials
            // 
            this.trials.Location = new System.Drawing.Point(57, 707);
            this.trials.Name = "trials";
            this.trials.Size = new System.Drawing.Size(100, 26);
            this.trials.TabIndex = 37;
            // 
            // suffix
            // 
            this.suffix.Location = new System.Drawing.Point(57, 644);
            this.suffix.Name = "suffix";
            this.suffix.Size = new System.Drawing.Size(100, 26);
            this.suffix.TabIndex = 36;
            // 
            // wait
            // 
            this.wait.Location = new System.Drawing.Point(57, 517);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(100, 26);
            this.wait.TabIndex = 35;
            // 
            // prefix
            // 
            this.prefix.Location = new System.Drawing.Point(57, 580);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(100, 26);
            this.prefix.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(57, 680);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(375, 19);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "Desired number of PIRs you want to record";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(57, 617);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(375, 19);
            this.textBox9.TabIndex = 32;
            this.textBox9.Text = "Filename suffix[also counts as step size]";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(57, 554);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(375, 19);
            this.textBox10.TabIndex = 31;
            this.textBox10.Text = "Filename prefix";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(57, 491);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(375, 19);
            this.textBox11.TabIndex = 30;
            this.textBox11.Text = "Waiting time between measurements [in seconds]";
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(57, 337);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 35);
            this.browse_button.TabIndex = 29;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(57, 300);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(452, 26);
            this.path.TabIndex = 28;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(58, 274);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(366, 19);
            this.textBox13.TabIndex = 27;
            this.textBox13.Text = "Please specify path to ARTA.exe";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(58, 177);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(452, 26);
            this.config.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(57, 142);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(366, 19);
            this.textBox14.TabIndex = 24;
            this.textBox14.Text = "Load previous configuration file";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(896, 1025);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(922, 2091);
            this.MinimumSize = new System.Drawing.Size(922, 1008);
            this.Name = "Form1";
            this.Text = "FTMB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox mode1_st;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox ch1_st;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox drop2;
        private System.Windows.Forms.ComboBox drop1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox trials;
        private System.Windows.Forms.TextBox suffix;
        private System.Windows.Forms.TextBox wait;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.CheckBox pir;
        private System.Windows.Forms.CheckBox ascii;
        private System.Windows.Forms.CheckBox csv;
        private System.Windows.Forms.CheckBox overlay;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox mode4_st;
        private System.Windows.Forms.TextBox mode3_st;
        private System.Windows.Forms.TextBox mode2_st;
        private System.Windows.Forms.TextBox ch4_st;
        private System.Windows.Forms.TextBox ch3_st;
        private System.Windows.Forms.TextBox ch2_st;
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox wait_measure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox config;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

