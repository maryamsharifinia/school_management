using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using BE;

namespace mmm
{
    public partial class shahrie : Form
    {
        public shahrie()
        {
            InitializeComponent();
        }

        private void bubbleButton3_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            kod_BOX.Hide();
            dataGridViewX1.Hide();
            dataGridView1.Show();
            dataGridViewX2.Hide();
            buttonX1.Hide();
            mablagh_box.Hide();
            serach_b.Show();
            name_teach.Show();
            payeh.Show();
            family_teach.Show();
            comboBox1.Hide();
            comboBox2.Hide();
            buttonX2.Hide();
            buttonX3.Hide();
            name_teach.Show();
            payeh.Show();
            family_teach.Show();
            textBoxX2.Hide();
            textBoxX1.Hide();
            buttonX3.Hide();
        }

        private void shahrie_Load(object sender, EventArgs e)
        {
            name_teach.Hide();
            payeh.Hide();
            family_teach.Hide();
            serach_b.Hide();
            kod_BOX.Hide();
            buttonX1.Hide();
            mablagh_box.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            buttonX2.Hide();
            textBoxX2.Hide();
            textBoxX1.Hide();
            buttonX3.Hide();
            dataGridView1.Hide();
            dataGridViewX1.Hide();
            dataGridViewX2.Hide();

        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            name_teach.Hide();
            payeh.Hide();
            family_teach.Hide();
            buttonX3.Show();
            serach_b.Hide();
            kod_BOX.Show();
            mablagh_box.Show();
            mablagh_box.Show();
            buttonX1.Show();
            comboBox1.Hide();
            comboBox2.Hide();
            buttonX2.Hide();
            textBoxX2.Show();
            textBoxX1.Show();
            dataGridView1.Hide();
            dataGridViewX1.Show();
            dataGridViewX2.Hide();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            comboBox1.Show();
            comboBox2.Show();
            buttonX3.Hide();
            buttonX2.Show();
            name_teach.Hide();
            dataGridView1.Hide();
            dataGridViewX1.Hide();
            dataGridViewX2.Show();
            payeh.Hide();
            family_teach.Hide();
            serach_b.Hide();
            kod_BOX.Hide();
            buttonX1.Hide();
            mablagh_box.Hide();
            textBoxX2.Hide();
            textBoxX1.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ثبت هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int b = Convert.ToInt32(mablagh_box.Text) + Convert.ToInt32(dataGridViewX1.CurrentRow.Cells[0].Value.ToString());
                int a = (5000000 - b);
                bl_std n = new bl_std();
                shahriee m = new shahriee();
                m.name_std = textBoxX2.Text;
                m.familly_std = textBoxX1.Text;
                m.kodemeli = kod_BOX.Text;
                m.shahriepardakhti = b;
                m.shahriepardakhtnashode = a;
                n.upshahrie(Convert.ToInt32(dataGridViewX1.CurrentRow.Cells[2].Value.ToString()), m);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            payeh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void serach_b_Click(object sender, EventArgs e)
        {
            bl_std n = new bl_std();
            dataGridView1.DataSource = n.serch_shahr(name_teach.Text, family_teach.Text, payeh.Text, "");
           
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();


            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderText = "شهریه پرداخت شده";
            dataGridView1.Columns[0].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[1].HeaderText = " شهریه پرداخت نشده";
            dataGridView1.Columns[1].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[3].HeaderText = "نام";
            dataGridView1.Columns[3].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[4].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[4].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[5].HeaderText = "کدملی";
            dataGridView1.Columns[5].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[6].HeaderText = "پایه تحصیل";
            dataGridView1.Columns[6].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[2].Visible = false;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            bl_std n = new bl_std();
           dataGridViewX1.DataSource = n.serch_shahr(textBoxX2.Text, textBoxX1.Text,"", kod_BOX.Text);
            dataGridViewX1.Columns[2].Visible = false;
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();


            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
            dataGridViewX1.Columns[0].HeaderText = "شهریه پرداخت شده";
            dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[1].HeaderText = " شهریه پرداخت نشده";
            dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[3].HeaderText = "نام";
            dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
            dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[5].HeaderText = "کدملی";
            dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
            dataGridViewX1.Columns[6].HeaderText = "پایه تحصیل";
            dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX2.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            textBoxX1.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();
            kod_BOX.Text = dataGridViewX1.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            
            if (comboBox2.Text == "کامل")
            {if (comboBox1.Text == "اول")
                {
                   bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat("اول");
                }
                if (comboBox1.Text == "دوم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat("دوم");
                }
                if (comboBox1.Text == "سوم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat("سوم");
                }
                if (comboBox1.Text == "چهارم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat("چهارم");
                }
                if (comboBox1.Text == "پنجم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat("پنجم");
                }
                if (comboBox1.Text == "ششم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat("ششم");
                }
                if (comboBox1.Text == "همه")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat("چهارم");
                    dataGridViewX2.DataSource = bl.read_shat("اول");
                    dataGridViewX2.DataSource = bl.read_shat("سوم");
                    dataGridViewX2.DataSource = bl.read_shat("دوم");
                    dataGridViewX2.DataSource = bl.read_shat("پنجم");
                    dataGridViewX2.DataSource = bl.read_shat("ششم");
                }
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX2.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
                dataGridViewX2.Columns[0].HeaderText = "شهریه پرداخت شده";
                dataGridViewX2.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[1].HeaderText = " شهریه پرداخت نشده";
                dataGridViewX2.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[3].HeaderText = "نام";
                dataGridViewX2.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX2.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[5].HeaderText = "کدملی";
                dataGridViewX2.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[6].HeaderText = "پایه تحصیل";
                dataGridViewX2.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[2].Visible = false;
            }
             else if (comboBox2.Text == "ناقص ")
            {
                if (comboBox1.Text == "اول")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat_n("اول");
                }
                if (comboBox1.Text == "دوم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat_n("دوم");
                }
                if (comboBox1.Text == "سوم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat_n("سوم");
                }
                if (comboBox1.Text == "چهارم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat_n("چهارم");
                }
                if (comboBox1.Text == "پنجم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat_n("پنجم");
                }
                if (comboBox1.Text == "ششم")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat_n("ششم");
                }
                if (comboBox1.Text == "همه")
                {
                    bl_std bl = new bl_std();
                    dataGridViewX2.DataSource = bl.read_shat_n("چهارم");
                    dataGridViewX2.DataSource = bl.read_shat_n("اول");
                    dataGridViewX2.DataSource = bl.read_shat_n("سوم");
                    dataGridViewX2.DataSource = bl.read_shat_n("دوم");
                    dataGridViewX2.DataSource = bl.read_shat_n("پنجم");
                    dataGridViewX2.DataSource = bl.read_shat_n("ششم");
                }
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX2.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();


                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
                dataGridViewX2.Columns[0].HeaderText = "شهریه پرداخت شده";
                dataGridViewX2.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[1].HeaderText = " شهریه پرداخت نشده";
                dataGridViewX2.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[3].HeaderText = "نام";
                dataGridViewX2.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX2.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[5].HeaderText = "کدملی";
                dataGridViewX2.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[6].HeaderText = "پایه تحصیل";
                dataGridViewX2.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX2.Columns[2].Visible = false;
            }
        }

        private void shahrie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }
    }
}
