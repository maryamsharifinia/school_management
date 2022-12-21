using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmm
{
    public partial class m5 : Form
    {
        public m5()
        {
            InitializeComponent();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            h5 s = new h5();
            s.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            v5 s = new v5();
            s.ShowDialog();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            this.Close();
            log_in n = new log_in();
            n.Show();
        }
    }
}
