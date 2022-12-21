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
    public partial class moalem2 : Form
    {
        public moalem2()
        {
            InitializeComponent();
        }
        

        private void buttonX10_Click_1(object sender, EventArgs e)
        {
            h2 s = new h2();
            s.ShowDialog();
        }

        private void buttonX6_Click_1(object sender, EventArgs e)
        {
            vorodnomre2 s = new vorodnomre2();
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
