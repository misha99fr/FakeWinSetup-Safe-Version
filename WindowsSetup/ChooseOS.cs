using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSetup
{
    public partial class ChooseOS : Form
    {
        public ChooseOS()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count <= 0)
                return;
            this.label1.Text = this.listView1.SelectedItems[0].Text;
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            license license = new license();
            license.Show();
            this.Hide();
        }
    }
}
