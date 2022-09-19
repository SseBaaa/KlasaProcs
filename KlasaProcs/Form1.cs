using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KlasaProcs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }

        private void buttonexp_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
        }
    }
}
