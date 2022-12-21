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
using BE;

namespace mmm
{
    public partial class h2 : Form
    {
        public h2()
        {
            InitializeComponent();
        }
        
        private void PersianCalender_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            txtDate.Text = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString();
        }

     
        

        private void h2_Load(object sender, EventArgs e)
        {
            bl_std b = new bl_std();
            dataGridView1.DataSource = b.kelsbandi("دوم");
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

            int c = 0;
            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

            dataGridView1.Columns[12].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[13].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[12].HeaderText = "نام ";
            dataGridView1.Columns[13].HeaderText = "نام خانوادگی ";
 
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ثبت هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bl_std b = new bl_std();
                hozurghyab aq = new hozurghyab();
                aq.hozor = "غایب";
                aq.tarikh = txtDate.Text;
                aq.name_std = textBox1.Text;
                aq.familly_std = textBox2.Text;
                aq.kodemeli = textBox3.Text;
                aq.payeh = "دوم";
                b.createhozur(aq);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }
    }
}
