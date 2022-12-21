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
    public partial class bedehiii : Form
    {
        public bedehiii()
        {
            InitializeComponent();
        }

        private void bedehiii_Load(object sender, EventArgs e)
        {
            kod_bedehi.Hide();
            buttonX3.Hide();
            buttonX1.Hide();
            elat.Hide();
            mablagh_bedehi.Hide();
            add_bedehi.Hide();
            textBoxX1.Hide();
            textBoxX2.Hide();
            textBoxX3.Hide();
            dataGridView1.Hide();
            dataGridView2.Hide();
            textBoxX4.Hide();
            textBoxX5.Hide();
            payeh.Hide();
            buttonX2.Hide();
            textBoxX6.Hide();
        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            buttonX3.Hide();
            kod_bedehi.Show();
            textBoxX6.Hide();
            buttonX2.Show();
            buttonX1.Hide();
            elat.Show();
            mablagh_bedehi.Show();
            add_bedehi.Show();
            textBoxX1.Hide();
            dataGridView1.Hide();
            dataGridView2.Hide();
            textBoxX2.Hide();
            textBoxX3.Hide();
            textBoxX4.Show();
            textBoxX5.Show();
            payeh.Show();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            kod_bedehi.Hide();
            buttonX3.Show();
            textBoxX6.Show();
            buttonX2.Hide();
            buttonX1.Show();
            elat.Hide();
            mablagh_bedehi.Hide();
            add_bedehi.Hide();
            textBoxX1.Show();
            dataGridView1.Hide();
            dataGridView2.Hide();
            textBoxX2.Show();
            textBoxX4.Hide();
            textBoxX5.Hide();
            payeh.Hide();
            textBoxX3.Show();
        }

        private void add_bedehi_Click(object sender, EventArgs e)
        {
            if (mablagh_bedehi.Text.Trim().Length == 0) { MessageBox.Show(".مبلغ بدهی را وارد کنید"); }
            else if (elat.Text.Trim().Length == 0) { MessageBox.Show(".علت بدهی را وارد کنید"); }
            else
            {
                var result = MessageBox.Show("آیا مایل به ثبت هستید ؟", "هشدار", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bl_std d = new bl_std();
                    bedehii h = new bedehii();
                    h.payeh = payeh.Text;
                    h.name_std = textBoxX4.Text;
                    h.familly_std = textBoxX5.Text;
                    h.bedehi = Convert.ToInt32(mablagh_bedehi.Text);
                    h.elatbedehi = elat.Text;
                    h.kodemeli = kod_bedehi.Text;
                    d.createbedehi(h);
                    MessageBox.Show(".بدهی ثبت شد");
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            dataGridView1.Hide();
            bl_std n = new bl_std();
            dataGridView2.DataSource = n.serchbe(textBoxX3.Text, textBoxX2.Text, textBoxX1.Text);
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView2.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();


            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
            dataGridView2.Columns[0].HeaderText = "بدهی ";
            dataGridView2.Columns[0].HeaderCell.Style = HeaderStyle;
            dataGridView2.Columns[1].HeaderText = "علت بدهی ";
            dataGridView2.Columns[1].HeaderCell.Style = HeaderStyle;
            dataGridView2.Columns[3].HeaderText = "نام";
            dataGridView2.Columns[3].HeaderCell.Style = HeaderStyle;
            dataGridView2.Columns[4].HeaderText = "نام خانوادگی";
            dataGridView2.Columns[4].HeaderCell.Style = HeaderStyle;
            dataGridView2.Columns[5].HeaderText = "کدملی";
            dataGridView2.Columns[5].HeaderCell.Style = HeaderStyle;
            dataGridView2.Columns[6].HeaderText = "پایه تحصیل";
            dataGridView2.Columns[6].HeaderCell.Style = HeaderStyle;
            dataGridView2.Columns[2].Visible = false;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            bl_std d = new bl_std();
            dataGridView1.DataSource = d.serch_information(textBoxX4.Text, textBoxX5.Text, payeh.Text, kod_bedehi.Text);
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
        //    dataGridView1.Columns[15].Visible = false;

            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

           
            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
           

            dataGridView1.Columns[12].HeaderText = "نام ";
            dataGridView1.Columns[12].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[13].HeaderText = "نام خانوادگی ";
            dataGridView1.Columns[13].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[15].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[15].HeaderText = "پایه تحصیل ";
        }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX4.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBoxX5.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            kod_bedehi.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            payeh.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBoxX2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBoxX1.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBoxX6.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ثبت هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bl_std n = new bl_std();
                n.remove(Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString()));
                MessageBox.Show(".بدهی پرداخت شد");
            }
        }

        private void bubbleBar1_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void bedehiii_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }
    }
}
