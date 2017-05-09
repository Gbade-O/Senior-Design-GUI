using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;


namespace SD_GUI
{
    public partial class Form1 : Form
    {
        AutoItX3 autoit = new AutoItX3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (drop1.SelectedIndex)
            {
                default:
                    //Choose the proper config file to match the pinouts for the arduiono
                    break;
            }
            int pid = autoit.Run(@"C:\Program Files (x86)\ArtaSoftware\Arta.exe");
            autoit.WinWaitActive("Untitled - Arta", "", 1);

            switch (drop2.SelectedIndex)
            {
                default://Select the right config to wok each particular calibration mode
                    autoit.WinMenuSelectItem("Untitled - Arta", "", "&Analysis", "Single-gated smoothed &Frequency response / Spectrum");
                    autoit.WinWait("Smoothed frequency response (Untitled)", "Custom1", 5);

                    break;
            }

            
     
            //autoit.Sleep(1000);
            //string process = autoit.WinGetProcess("Untitled - Arta");
            //autoit.ProcessClose(process);
            
        }

        private void drop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string channel;
            channel= (string)drop1.SelectedItem;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mode;
            mode=(string)drop2.SelectedItem;


        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderpath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
