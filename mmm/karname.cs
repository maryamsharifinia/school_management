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
namespace mmm
{
    public partial class karname : Form
    {
        public karname()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            bl_std bd = new bl_std();
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();
            
            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
         
            dataGridView1.DataSource = bd.serchkarname_nfpk(name_teach.Text, family_teach.Text, payeh.Text, kod_teach.Text);
            dataGridView1.Columns[0].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[0].HeaderText = "علوم";
            dataGridView1.Columns[1].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[1].HeaderText = "ریاضی";
            dataGridView1.Columns[2].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[2].HeaderText = "فارسی ";
            dataGridView1.Columns[3].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[3].HeaderText = "اجتماعی";
            dataGridView1.Columns[5].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[5].HeaderText = "نام";
            dataGridView1.Columns[6].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[6].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[7].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[7].HeaderText = "کد ملی";
            dataGridView1.Columns[8].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[8].HeaderText = "پایه";
            dataGridView1.Columns[4].Visible = false;
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 18F, GraphicsUnit.Pixel);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bl_std n = new bl_std();
            dataGridViewX1.Show();
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

            dataGridViewX1.DataSource = n.serchevz(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[0].HeaderText = "دلیل کسر انضباط ";
            dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[1].HeaderText = "مقدار کسر انضباط";
            dataGridViewX1.Columns[2].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[2].HeaderText = "تاریخ کسر انضباط";
            dataGridViewX1.Columns[3].Visible = false;
            dataGridViewX1.Columns[4].Visible = false;
            dataGridViewX1.Columns[5].Visible = false;
            dataGridViewX1.Columns[6].Visible = false;
            dataGridViewX1.Columns[7].Visible = false;
      
            name_teach.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            family_teach.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            kod_teach.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            payeh.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void karname_Load(object sender, EventArgs e)
        {
            dataGridViewX1.Hide();
        }

        private void kod_teach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }
    }
}
