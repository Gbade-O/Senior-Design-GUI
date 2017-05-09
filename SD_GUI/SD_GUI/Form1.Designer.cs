namespace SD_GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.drop2 = new System.Windows.Forms.ComboBox();
            this.drop1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.folderpath = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.drop2);
            this.panel1.Controls.Add(this.drop1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(237, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Mode";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // drop2
            // 
            this.drop2.FormattingEnabled = true;
            this.drop2.Items.AddRange(new object[] {
            "Frequency Response",
            "Impedance Response ",
            "Impedance Calibration"});
            this.drop2.Location = new System.Drawing.Point(343, 47);
            this.drop2.Name = "drop2";
            this.drop2.Size = new System.Drawing.Size(151, 28);
            this.drop2.TabIndex = 1;
            this.drop2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // drop1
            // 
            this.drop1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.drop1.Location = new System.Drawing.Point(109, 50);
            this.drop1.MaxDropDownItems = 4;
            this.drop1.Name = "drop1";
            this.drop1.Size = new System.Drawing.Size(121, 28);
            this.drop1.TabIndex = 1;
            this.drop1.SelectedIndexChanged += new System.EventHandler(this.drop1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Channel";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(213, 961);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(108, 42);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Run Arta";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.SystemColors.Control;
            this.listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox.FormattingEnabled = true;
            this.listbox.Items.AddRange(new object[] {
            "Save as PIR",
            "Save as ASCII",
            "Save as CSV",
            "Create an overlay for each measurement"});
            this.listbox.Location = new System.Drawing.Point(64, 815);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(375, 105);
            this.listbox.TabIndex = 11;
            this.listbox.ThreeDCheckBoxes = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.folderpath);
            this.panel2.Controls.Add(this.path);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 158);
            this.panel2.TabIndex = 12;
            // 
            // folderpath
            // 
            this.folderpath.Location = new System.Drawing.Point(28, 105);
            this.folderpath.Name = "folderpath";
            this.folderpath.Size = new System.Drawing.Size(75, 35);
            this.folderpath.TabIndex = 22;
            this.folderpath.Text = "Browse";
            this.folderpath.UseVisualStyleBackColor = true;
            this.folderpath.Click += new System.EventHandler(this.folderpath_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(28, 73);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(452, 26);
            this.path.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(28, 26);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(366, 19);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "Please specify path to ARTA.exe";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Browse";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(28, 66);
            this.maskedTextBox1.Mask = "0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RejectInputOnFirstFailure = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(28, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(375, 19);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Waiting time between measurements [in seconds]";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(28, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(375, 19);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Filename prefix";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(28, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(375, 19);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "Filename suffix[also counts as step size]";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(28, 295);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(375, 19);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "Desired number of PIRs you want to record";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BeepOnError = true;
            this.maskedTextBox4.Location = new System.Drawing.Point(28, 345);
            this.maskedTextBox4.Mask = "0";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.RejectInputOnFirstFailure = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox4.TabIndex = 19;
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(28, 158);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 20;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BeepOnError = true;
            this.maskedTextBox2.Location = new System.Drawing.Point(28, 249);
            this.maskedTextBox2.Mask = "0";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.RejectInputOnFirstFailure = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox2.TabIndex = 21;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.maskedTextBox2);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.maskedTextBox4);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.maskedTextBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1216, 428);
            this.panel3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 1036);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Senior Design";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox drop1;
        private System.Windows.Forms.ComboBox drop2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox listbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folderpath;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Panel panel3;
    }
}

