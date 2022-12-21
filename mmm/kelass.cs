using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace mmm
{
    public partial class kelass : Form
    {
        public kelass()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            bl_std b = new bl_std();
            if (comboBox1.Text == "همه")
            {
                dataGridViewX1.DataSource = b.kelsbandikol();
            }
          else
                dataGridViewX1.DataSource = b. kelsbandi(comboBox1.Text);

             dataGridViewX1.Show();

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
            dataGridViewX1.Columns[12].HeaderText = "نام ";
            dataGridViewX1.Columns[0].HeaderText = "نام پدر ";
            dataGridViewX1.Columns[1].HeaderText = "شماره تلفن پدر ";
            dataGridViewX1.Columns[2].HeaderText = "شماره تلفن مادر ";
            dataGridViewX1.Columns[3].HeaderText = "شماره تلفن منزل ";
            dataGridViewX1.Columns[13].HeaderText = "نام خانوادگی ";
            dataGridViewX1.Columns[14].HeaderText = "کدملی ";
            dataGridViewX1.Columns[15].HeaderText = "پایه ";
            dataGridViewX1.Columns[6].HeaderText = "سابقه کاری";
            dataGridViewX1.Columns[5].HeaderText = "آدرس منزل";
            dataGridViewX1.Columns[6].HeaderText = "کد پستی";
            dataGridViewX1.Columns[7].HeaderText = "شغل پدر";
            dataGridViewX1.Columns[8].HeaderText = "شغل مادر";
            dataGridViewX1.Columns[9].HeaderText = "مدرک پدر";
            dataGridViewX1.Columns[10].HeaderText = "مدرک مادر";
            dataGridViewX1.Columns[11].Visible = false;
            dataGridViewX1.Columns[4].HeaderText = "توضیحات";

        }

        private void kelass_Load(object sender, EventArgs e)
        {
            dataGridViewX1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
