using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using System.Data.SqlClient;

namespace mmm
{
    public partial class c : Form
    {
        public c()
        {
            InitializeComponent();
        }

        private void c_Load(object sender, EventArgs e)
        {
            name_teach.Hide();
            family_teach.Hide();
            kod_teach.Hide();
            payeh.Hide();
            buttonX1.Hide();
            dataGridViewX1.Hide();
            buttonX2.Hide();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            name_teach.Show();
            family_teach.Show();
            kod_teach.Show();
            payeh.Show();
            buttonX2.Show();
            buttonX1.Hide();
            dataGridViewX1.DataSource = null;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Show();
        }

        private void bubbleButton2_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            name_teach.Show();
            family_teach.Show();
            kod_teach.Show();
            payeh.Show();
            buttonX1.Show();
            buttonX2.Hide();
            dataGridViewX1.DataSource = null;
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            
            dataGridViewX1.Show();
            bl_std n = new bl_std();
            dataGridViewX1.DataSource = n.serch_information_teach(name_teach.Text, family_teach.Text, payeh.Text, kod_teach.Text);
            dataGridViewX1.Columns[0].Visible = false;
            dataGridViewX1.Columns[11].Visible = false;
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }     
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

            int c = 0;
            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
            while (c < 12)
            {
                dataGridViewX1.Columns[c].HeaderCell.Style = HeaderStyle;
                c++;
            }

            dataGridViewX1.Columns[1].HeaderText = "نام ";
            dataGridViewX1.Columns[2].HeaderText = "نام پدر ";
            dataGridViewX1.Columns[3].HeaderText = "نام خانوادگی ";
            dataGridViewX1.Columns[4].HeaderText = "کدملی دبیر";
            dataGridViewX1.Columns[5].HeaderText = "پایه تدریس";
            dataGridViewX1.Columns[6].HeaderText = "سابقه کاری";
            dataGridViewX1.Columns[7].HeaderText = "تلفن منزل";
            dataGridViewX1.Columns[8].HeaderText = "تلفن همراه";
            dataGridViewX1.Columns[9].HeaderText = "رزومه";
            dataGridViewX1.Columns[10].HeaderText = "توضیحات";

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        { students s = new students();
            dataGridViewX1.Show();
            bl_std n = new bl_std();

            dataGridViewX1.DataSource = n.serch_information(name_teach.Text, family_teach.Text, payeh.Text, kod_teach.Text);
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

            int c = 0;
            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
            while (c < 16)
            {
                dataGridViewX1.Columns[c].HeaderCell.Style = HeaderStyle;
                c++;
            }
            dataGridViewX1.Columns[0].HeaderText = "نام پدر";
            dataGridViewX1.Columns[11].Visible = false;
            dataGridViewX1.Columns[1].HeaderText = " تلفن همراه پدر";
            dataGridViewX1.Columns[2].HeaderText = "تلفن همراه مادر ";
            dataGridViewX1.Columns[3].HeaderText = "تلفن منزل";
            dataGridViewX1.Columns[7].HeaderText = "شغل پدر";
            dataGridViewX1.Columns[15].HeaderText = "پایه تحصیل";
            dataGridViewX1.Columns[5].HeaderText = "آدرس";
            dataGridViewX1.Columns[6].HeaderText = "کدپستی";
            dataGridViewX1.Columns[8].HeaderText = "شغل مادر";
            dataGridViewX1.Columns[9].HeaderText = "مدرک تحصیلی پدر";
            dataGridViewX1.Columns[10].HeaderText = "مدرک تحصیلی مادر";
            dataGridViewX1.Columns[12].HeaderText = "نام";
            dataGridViewX1.Columns[13].HeaderText = "نام خانوادگی";
            dataGridViewX1.Columns[14].HeaderText = "کدملی";
            dataGridViewX1.Columns[4].HeaderText = "توضیحات";

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void kod_teach_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void kod_teach_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }
    }
}
