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
    public partial class vorodnomre2 : Form
    {
        public vorodnomre2()
        {
            InitializeComponent();
        }
        

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ثبت هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                nomre n = new nomre();
                n.name_std = textBox1.Text;
                n.familly_std = textBox2.Text;
                n.kodemeli = textBox3.Text;
                n.farc = comboBox1.Text;
                n.riazi = comboBox2.Text;
                n.olom = comboBox3.Text;
                n.ejtmaey = comboBox4.Text;
                n.payeh = "دوم";
                bl_std d = new bl_std();
                d.createnomre(n);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void vorodnomre2_Load(object sender, EventArgs e)
        {
            bl_std b = new bl_std();
            dataGridView1.DataSource = b.kelsbandi("دوم");
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
    }
}
