using BE;
using BLL;
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
    public partial class v3 : Form
    {
        public v3()
        {
            InitializeComponent();
        }

        private void v3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(7, label6.BackColor);
            label2.BackColor = Color.FromArgb(7, label6.BackColor);
            label4.BackColor = Color.FromArgb(7, label6.BackColor);
            label3.BackColor = Color.FromArgb(7, label6.BackColor);
            bl_std b = new bl_std();
            dataGridView1.DataSource = b.kelsbandi("سوم");
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ثبت هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                nomre n = new nomre();
                n.name_std = textBox4.Text;
                n.familly_std = textBox2.Text;
                n.kodemeli = textBox3.Text;
                n.farc = comboBox1.Text;
                n.riazi = comboBox2.Text;
                n.olom = comboBox3.Text;
                n.ejtmaey = comboBox4.Text;
                n.payeh = "سوم";
                bl_std d = new bl_std();
                d.createnomre(n);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }
    }
}
