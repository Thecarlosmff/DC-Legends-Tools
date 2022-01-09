using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Legends_Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gear f2 = new Gear();
            this.Hide();
            f2.ShowDialog(); // Shows Form2
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Thecarlosmff/DC-Legends-Tools/releases",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}
