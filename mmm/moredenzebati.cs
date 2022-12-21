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
using BehComponents;

namespace mmm
{
    public partial class moredenzebati : Form
    {
        public moredenzebati()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            students s = new students();
            dataGridView1.Show();
            bl_std n = new bl_std();
            dataGridView1.DataSource = n.serchname(textBox3.Text, textBox4.Text);
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
            foreach (DataGridViewColumn DataGridViewColumn1 in dataGridView1.Columns)
            {
                DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
            }
            DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

            HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);
            dataGridView1.Columns[12].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[12].HeaderText = "نام";
            dataGridView1.Columns[13].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[13].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[14].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[14].HeaderText = "کدملی";
            dataGridView1.Columns[15].HeaderCell.Style = HeaderStyle;
            dataGridView1.Columns[15].HeaderText = "پایه";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim().Length == 0) { MessageBox.Show(".نام را وارد کنید"); }
            else if (textBox4.Text.Trim().Length == 0) { MessageBox.Show(".نام خانوادگی  را وارد کنید"); }
            else if (textBox2.Text.Trim().Length == 0) { MessageBox.Show(".مقدار کسری نمره را وارد کنید"); }
            else if (textBox1.Text.Trim().Length == 0) { MessageBox.Show(".علت مورد انضباطی را وارد کنید"); }
            else if (textBox5.Text.Trim().Length == 0) { MessageBox.Show(".کد ملی  را وارد کنید"); }
            else if (Convert.ToDouble(textBox2.Text) > 20) { MessageBox.Show(".شما نمی توانید بیشتر از 20 نمره از دانش آموز انضباط کسر کنید"); }
            else
            {
                enzebati m = new enzebati();
                m.tarikhkasri = txtDate.Text;
                m.moredenzebati = textBox1.Text;
                m.name_std = textBox3.Text;
                m.familly_std = textBox4.Text;
                m.meghdarkasri = Convert.ToDouble(textBox2.Text);
                m.kodemeli = textBox5.Text;

                bl_std b = new bl_std();
                b.createenz(m);
                MessageBox.Show("مورد انضباظی ثبت شد");
               // double d = (20 - Convert.ToDouble(textBox2.Text));
               // nomre mm = new nomre();
               // mm.enzebat = d;
               //// b.up_enz(textBox5.Text, mm);
            }

        }
        private void PersianCalender_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            txtDate.Text = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString();
        }

        private void PersianCalender_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            // textBox2.Text = dataGridView1.CurrentRow.Cells[3].ToolTipText.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }
    }
}
