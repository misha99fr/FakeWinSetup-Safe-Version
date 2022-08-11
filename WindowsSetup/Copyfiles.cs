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
    public partial class Copyfiles : Form
    {
        public Copyfiles()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value > 100)
                timer1.Enabled = false;
            else label9.Text = progressBar1.Value.ToString() + " %"; 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Restart form6 = new Restart();
            form6.Show();
            this.Hide();
        }

        private void Copyfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
