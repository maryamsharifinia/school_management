using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BehComponents;
using BE;
using BLL;
namespace mmm
{
    public partial class jalse : Form
    {
        public jalse()
        {
            InitializeComponent();
        }

        private void jalse_Load(object sender, EventArgs e)
        {
            dataGridViewX1.Hide();
            label1.Hide();
          
            label3.Hide();    
            textBoxX3.Hide();
            textBoxX4.Hide();
            richTextBox1.Hide();
            txtDate.Hide();
            PersianCalender.Hide();
            buttonX1.Hide();
            buttonX2.Hide();
            buttonX3.Hide();
            txtDate.Text = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString();
        }
        private void PersianCalender_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            txtDate.Text = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString();
        }
        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            PersianCalender.Show();
            txtDate.Show();
            textBoxX3.Hide();
            textBoxX4.Hide();
  
            label1.Hide();
          
            label3.Hide();
          
            richTextBox1.Hide();
            buttonX1.Hide();
            buttonX2.Show();
            buttonX3.Show();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            PersianCalender.Show();
            txtDate.Show();
            textBoxX3.Show();
            textBoxX4.Show();
            dataGridViewX1.Hide();
            label1.Show();
            label3.Show();   
            richTextBox1.Show();
            buttonX1.Show();
            buttonX2.Hide();
            buttonX3.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            meeting j = new meeting();
            j.elat = textBoxX3.Text;
            j.mokhatab = textBoxX4.Text;
            j.tarikh_meet = txtDate.Text;
            j.tozihat = richTextBox1.Text;
            bl_std bl = new bl_std();
            bl.cearatmeet(j);
            
            MessageBox.Show("جلسه ثبت شد ");
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Show();
            bl_std d = new bl_std();
            d.serchjalase(txtDate.Text);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Show();
            bl_std b = new bl_std();
            b.serchjalasek();
        }
    }
}
