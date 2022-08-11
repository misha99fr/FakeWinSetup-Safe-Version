using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsSetup
{
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value > 100)
                timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
