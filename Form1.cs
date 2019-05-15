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

namespace pornHubDesktopLoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Process.Start("https://rt.pornhub.com/");
        }
    }
}
