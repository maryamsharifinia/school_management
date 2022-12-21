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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            h3 s = new h3();
            s.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            v3 s = new v3();
            s.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
