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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            add_student f = new add_student();
            f.ShowDialog();
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
           addteacher f = new addteacher();
            f.ShowDialog();
        }
        private void buttonX7_Click(object sender, EventArgs e)
        {
            shahrie f = new shahrie();
            f.ShowDialog();
        }
        private void buttonX8_Click(object sender, EventArgs e)
        {
            kelass f = new kelass();
            f.ShowDialog();
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            bedehiii f = new bedehiii();
            f.ShowDialog();
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            c f = new c();
            f.ShowDialog();
        }
        private void buttonX10_Click(object sender, EventArgs e)
        {
            hozorghyab f = new hozorghyab();
            f.ShowDialog();
        }
        private void buttonX6_Click(object sender, EventArgs e)
        {
            moredenzebati f = new moredenzebati();
            f.ShowDialog();
        }
        private void buttonX5_Click(object sender, EventArgs e)
        {
            jalse f = new jalse();
            f.ShowDialog();
        }
        private void buttonX9_Click(object sender, EventArgs e)
        {
            karname f = new karname();
            f.ShowDialog();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            this.Close();
            log_in n = new log_in();
            n.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
