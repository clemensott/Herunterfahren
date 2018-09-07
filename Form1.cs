using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herunterfahren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int ver = Convert.ToInt32(nud_h.Value) * 3600 + Convert.ToInt32(nud_m.Value) * 60 + Convert.ToInt32(nud_s.Value);

            if (rbn_her.Checked)
                System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -f -t " + ver.ToString());
            else if(rbn_neu.Checked)
                System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-r -f -t " + ver.ToString());
            else
                System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-a");

            Application.Exit();
        }

        private void rbn_abb_CheckedChanged(object sender, EventArgs e)
        {
            nud_h.Enabled = nud_m.Enabled = nud_s.Enabled = !rbn_abb.Checked;
        }

        private void btn_ab_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
