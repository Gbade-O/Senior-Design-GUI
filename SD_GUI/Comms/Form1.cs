using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using System.IO.Ports;
using System.Diagnostics;


namespace Comms
{
    public partial class Form1 : Form
    {
        AutoItX3 autoit = new AutoItX3();
        
        
        int Arta_pid;
        string status;
        string verification;
        bool Vbutton = false;
        string[] seperators = { "_" };
        string[] seperators2 = { "," };
        
        int count=0;
        string[] Port;
        string Mode_Channel;
        private static System.Timers.Timer aTimer;
        



        public Form1()
        {
            InitializeComponent();
            StabilizeGui();
            
            
             
             Port = SerialPort.GetPortNames();
        }
        void PingCom(string Comms)
        {
            aTimer = new System.Timers.Timer(500);
            aTimer.Elapsed += OnTimedEvent;
            //aTimer.AutoReset = true;
            foreach (string com in Port)
            {
                serialPort1.PortName = com;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                serialPort1.WriteLine('@' + Comms + '#');
            }
            aTimer.Start();
        }
		
        void StabilizeGui()
        {
            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.MaximumSize;
        }

        bool WinExists()
        {
            if (autoit.WinExists("Confirm Save As") == 1)
            {
                return true;
            }
            else
                return false;
        }

         private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            //string status;
            int start;
            int to;
           
            if(serialPort1.BytesToRead>0)
            {
                status = serialPort1.ReadExisting();
                serialPort1.Close();
                aTimer.Stop();
                aTimer.Enabled = false;
                //MessageBox.Show(status);
                
                
            }
            start = status.IndexOf("@") + "@".Length;
            to = status.LastIndexOf("#");
            verification = status.Substring(start, to - start);

            if (Vbutton)
            {
                Vbutton = false;
                string[] result = verification.Split(seperators2, StringSplitOptions.RemoveEmptyEntries);
                string[] update = result[0].Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                ch1_st.Text = update[0];
                mode1_st.Text = update[1];



                update = result[1].Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                ch2_st.Text = update[0];
                mode2_st.Text = update[1];


                update = result[2].Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                ch3_st.Text = update[0];
                mode3_st.Text = update[1];


                update = result[3].Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                ch4_st.Text = update[0];
                mode4_st.Text = update[1];

            }
            else
            {
                if (verification[2] == '1')
                {
                    string[] result = verification.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    ch1_st.Text = result[0];
                    mode1_st.Text = result[1];
                }
                else if (verification[2] == '2')
                {
                    string[] result = verification.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    ch2_st.Text = result[0];
                    mode2_st.Text = result[1];
                }
                else if (verification[2] == '3')
                {
                    string[] result = verification.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    ch3_st.Text = result[0];
                    mode3_st.Text = result[1];
                }
                else
                {
                    string[] result = verification.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    ch4_st.Text = result[0];
                    mode4_st.Text = result[1];
                }
            }
        }
           

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                path.Text = openFileDialog2.FileName;
            }
        }

        private void drop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string channel;
            channel = (string)drop1.SelectedItem;
        }

        private void drop2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mode;
            mode = (string)drop2.SelectedItem;
        }

        private void Run_btn_Click_1(object sender, EventArgs e)
        {
            


            Hide();
            Process[] Arta_process = Process.GetProcessesByName("Arta");
            Process[] LIMP_process = Process.GetProcessesByName("Limp");
            Process[] STEPS_process = Process.GetProcessesByName("Steps");
            Process Arta = new Process();
            if ((Arta_process.Length == 0) && (LIMP_process.Length==0) && (STEPS_process.Length==0))
            {
                Arta_pid=autoit.Run(path.Text); //Run ARTA with a process
                Arta = Process.GetProcessById(Arta_pid);

                if(Arta.ProcessName=="Arta")
                {
                    autoit.WinWaitActive("Untitled - Arta");
                    autoit.WinMenuSelectItem("Untitled - Arta", "", "&Setup", "&Audio devices");
                    

                    autoit.Sleep(1000 * 1);
                    autoit.WinSetState("Untitled - Arta", "", 8);
                    autoit.WinWaitActive("Untitled - Arta");
                    autoit.Send("!r");
                    autoit.Send("{enter}");
                    autoit.WinWaitActive("Impulse response measurement / Signal recording");
                    
                }
                else if (Arta.ProcessName == "Limp")
                {
                    autoit.WinWaitActive("Untitled - Limp");

                    autoit.WinSetState("Untitled - Limp", "", 8);
                    //autoit.Sleep(1000 * 3);
                    autoit.WinWaitActive("Untitled - Limp");
                    autoit.WinMenuSelectItem("Untitled - Limp", "", "&Setup", "&Audio devices");
                    
                    autoit.WinWaitActive("Soundcard Setup");
                    autoit.WinWaitClose("Soundcard Setup");


                    if (drop2.SelectedIndex == 2)
                    {
                        autoit.WinWaitActive("Untitled - Limp");
                        autoit.WinMenuSelectItem("Untitled - Limp", "", "&Record", "&Calibrate");
                        autoit.WinWaitActive("Calibrate Input Channels");
                    }
                    else if(drop2.SelectedIndex == 1)
                    {
                        autoit.WinWaitActive("Untitled - Limp");
                        autoit.WinMenuSelectItem("Untitled - Limp", "", "&Setup", "&Generator");
                        autoit.WinWaitActive("Generator Setup");
                        autoit.WinWaitClose("Generator Setup");
                        autoit.WinMenuSelectItem("Untitled - Limp", "", "&Setup", "&Measurement");
                        autoit.WinWaitActive("Measurement Setup");
                        autoit.WinWaitClose("Measurement Setup");
                    }

                   
                       
                    
                   
                    
                }
                    

               

               
                int Trials, Suffix, Wait,Wait_m;
                bool running = false;
                Int32.TryParse(trials.Text, out Trials);
                Int32.TryParse(suffix.Text, out Suffix);
                Int32.TryParse(wait.Text, out Wait);
                Int32.TryParse(wait_measure.Text, out Wait_m);
                bool iteration = true;

                
                for (int i = 0; i < Trials; i++)
                {
                    int step = i * Suffix;
                    string Step = Convert.ToString(step);
                    if (Arta.ProcessName == "Arta")
                    {
                        if(iteration)
                        {
                            autoit.WinWaitClose("Impulse response measurement / Signal recording");
                            iteration = false;
                        }
                        else
                        {
                            autoit.Send("!r");
                            autoit.Send("{enter}");
                            autoit.WinWaitActive("Impulse response measurement / Signal recording");
                            autoit.ControlClick("Impulse response measurement / Signal recording", "", "Close after recording");
                            autoit.Send("!r");
                            autoit.Sleep(1000*3);
                          
                        }
                        
                    }
                    else if (Arta.ProcessName == "Limp")
                    {
                        if(drop2.SelectedIndex == 2)
                        {
                            autoit.WinWaitActive("Untitled - Limp");
                            if (iteration)
                            {
                                autoit.WinWaitClose("Calibrate Input Channels");
                                iteration = false;
                            }
                            else
                            {
                                autoit.ControlClick("Calibrate Input Channels", "", "Generate");
                                autoit.ControlClick("Calibrate Input Channels", "", "Calibrate");
                                autoit.Sleep(1000 * 1);
                                autoit.ControlClick("Calibrate Input Channels", "", "OK");
                            }
                            
                        }
                        else
                        {
                            autoit.WinWaitActive("Untitled - Limp");
                            autoit.WinMenuSelectItem("Untitled - Limp", "", "&Record", "&Start");
                            autoit.Sleep(1000 * Wait_m);
                            autoit.WinMenuSelectItem("Untitled - Limp", "", "&Record", "&Stop");
                            autoit.Sleep(1 * 1000);
                        }
                        
                    }

                    
                    #region Save_types
                    if (Arta.ProcessName == "Arta")
                    {
                        autoit.WinActivate("Untitled - Arta");
                        if (overlay.Checked)
                        {
                            autoit.Send("!o");
                            autoit.Send("a");
                            if (WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }
                        }
                        if (csv.Checked)
                        {
                            autoit.Send("!f");
                            autoit.Send("e");
                            autoit.Send("c");
                            autoit.Sleep(300);
                            autoit.Send(prefix.Text + step + ".csv");
                            autoit.Sleep(300);
                            autoit.Send("{ENTER}");
                            autoit.Sleep(300);
                            if (WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }
                        }
                        if (ascii.Checked)
                        {
                            autoit.Send("!f");
                            autoit.Send("e");
                            autoit.Send("a");
                            autoit.Sleep(300);
                            autoit.Send(prefix.Text + step + ".txt");
                            autoit.Sleep(300);
                            autoit.Send("{ENTER}");
                            autoit.Sleep(300);
                            if (WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }
                        }
                        if (pir.Checked)
                        {
                            autoit.Send("!f");
                            autoit.Send("s");
                            autoit.Sleep(300);
                            autoit.Send(prefix.Text + step + ".pir");
                            autoit.Send("{ENTER}");
                            autoit.Sleep(300);
                            if (WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }
                        }
                    }
                    else if(Arta.ProcessName == "Limp")
                    {
                        if (overlay.Checked)
                        {
                            autoit.Send("!o");
                            autoit.Send("s");
                            if (WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }
                        }
                        if (csv.Checked)
                        {
                            autoit.Send("!f");
                            autoit.Send("e");
                            autoit.Send("c");
                            autoit.Sleep(150);
                            autoit.Send(prefix.Text + step + ".csv");
                            autoit.Sleep(150);
                            autoit.Send("{ENTER}");
                            autoit.Sleep(300);
                            if(WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }

                        }
                        if (ascii.Checked)
                        {
                            autoit.Send("!f");
                            autoit.Send("e");
                            autoit.Send("t");
                            autoit.Sleep(150);
                            autoit.Send(prefix.Text + step + ".txt");
                            autoit.Sleep(150);
                            autoit.Send("{ENTER}");
                            autoit.Sleep(300);
                            if (WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }
                        }
                        if (pir.Checked)
                        {
                            autoit.Send("!f");
                            autoit.Send("s");
                            autoit.Sleep(300);
                            autoit.Send(prefix.Text + step + ".pir");
                            autoit.Send("{ENTER}");
                            autoit.Sleep(300);
                            if (WinExists())
                            {
                                autoit.WinWaitActive("Save As");
                                autoit.Sleep(1000 * 2);
                            }
                        }
                    }
                    #endregion 

                    autoit.Sleep(Wait * 1000);


                }
            }
            else
            {
                MessageBox.Show("You can only run one macro");
                this.Close();
            }
            
            Arta.Kill();
            Arta.Dispose();
            this.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //PingCom();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                config.Text = openFileDialog1.FileName;
                string[] readText = System.IO.File.ReadAllLines(config.Text);
                 path.Text =readText[0];
                 wait.Text = readText[1];
                 prefix.Text = readText[2];
                 suffix.Text = readText[3];
                 trials.Text = readText[4];
                 drop1.SelectedItem = readText[5];
                 drop2.SelectedItem = readText[6];
                 wait_measure.Text = readText[7];

            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            
            string Channel;
            if (drop2.SelectedIndex == 0)
            {
                Channel = "fr";
            }
            else if (drop2.SelectedIndex == 1)
            {
                Channel = "ir";
            }
            else if (drop2.SelectedIndex == 2)
                Channel = "ic";
            else
                Channel = "co";

            if ((drop2.SelectedItem != null) && ((string)drop1.SelectedItem != null))
            {
                Mode_Channel = "CH" + (string)drop1.SelectedItem + "_" + Channel;
                //MessageBox.Show(Mode_Channel);
            }
            else
                MessageBox.Show("Please enter both values");

            PingCom(Mode_Channel);


            
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            notifyIcon1.Visible = true;
            ShowInTaskbar = false;
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //this.Show();
            notifyIcon1.Visible = false;

        }

        private void verify_Click(object sender, EventArgs e)
        {
            Vbutton = true;
            PingCom("verify");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files | *.txt| Config file | *.ini";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] config = new string[8];
                config[0] = path.Text;
                config[1] = wait.Text;
                config[2] = prefix.Text;
                config[3] = suffix.Text;
                config[4] = trials.Text;
                config[5] = (string)drop1.SelectedItem;
                config[6] = (string)drop2.SelectedItem;
                config[7] = wait_measure.Text ;
                string filename = System.IO.Path.GetFullPath(saveFileDialog1.FileName);
                System.IO.File.WriteAllLines(filename, config); //Write to Config files
            }
           
        }
    }
}
