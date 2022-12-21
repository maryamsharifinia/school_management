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
    public partial class hozorghyab : Form
    {
        public hozorghyab()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Show();


            if (comboBox1.Text =="همه")
            {
                bl_std b = new bl_std();
                dataGridViewX1.DataSource = b.serchhozurk(txtDate.Text);
                dataGridViewX1.Columns[2].Visible = false;
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

                dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[0].HeaderText = "وضعیت حضور";
                dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[1].HeaderText = "تاریخ";
                dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[3].HeaderText = "نام";
                dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[5].HeaderText = "کدملی";
                dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[6].HeaderText = "پایه";
            }
            if (comboBox1.Text == "اول")
            {
                bl_std b = new bl_std();
                dataGridViewX1.DataSource = b.serchhozur("اول", txtDate.Text);
                dataGridViewX1.Columns[2].Visible = false;
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

                dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[0].HeaderText = "وضعیت حضور";
                dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[1].HeaderText = "تاریخ";
                dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[3].HeaderText = "نام";
                dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[5].HeaderText = "کدملی";
                dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[6].HeaderText = "پایه";

            }
            if (comboBox1.Text == "دوم")
            {
                bl_std b = new bl_std();

                dataGridViewX1.DataSource = b.serchhozur("دوم", txtDate.Text);
                dataGridViewX1.Columns[2].Visible = false;
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

                dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[0].HeaderText = "وضعیت حضور";
                dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[1].HeaderText = "تاریخ";
                dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[3].HeaderText = "نام";
                dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[5].HeaderText = "کدملی";
                dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[6].HeaderText = "پایه";
            }
            if (comboBox1.Text == "سوم")
            {
                bl_std b = new bl_std();
                dataGridViewX1.DataSource = b.serchhozur("سوم", txtDate.Text);
                dataGridViewX1.Columns[2].Visible = false;
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

                dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[0].HeaderText = "وضعیت حضور";
                dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[1].HeaderText = "تاریخ";
                dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[3].HeaderText = "نام";
                dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[5].HeaderText = "کدملی";
                dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[6].HeaderText = "پایه";

            }
            if (comboBox1.Text == "چهارم")
            {
                bl_std b = new bl_std();
                dataGridViewX1.DataSource = b.serchhozur("چهارم", txtDate.Text);
                dataGridViewX1.Columns[2].Visible = false;
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

                dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[0].HeaderText = "وضعیت حضور";
                dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[1].HeaderText = "تاریخ";
                dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[3].HeaderText = "نام";
                dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[5].HeaderText = "کدملی";
                dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[6].HeaderText = "پایه";
            }
            if (comboBox1.Text == "پنجم")
            {
                bl_std b = new bl_std();
                dataGridViewX1.DataSource = b.serchhozur("پنجم", txtDate.Text);
                dataGridViewX1.Columns[2].Visible = false;
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

                dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[0].HeaderText = "وضعیت حضور";
                dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[1].HeaderText = "تاریخ";
                dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[3].HeaderText = "نام";
                dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[5].HeaderText = "کدملی";
                dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[6].HeaderText = "پایه";
            }
            if (comboBox1.Text == "ششم")
            {
                bl_std b = new bl_std();
                dataGridViewX1.DataSource = b.serchhozur("ششم", txtDate.Text);
                dataGridViewX1.Columns[2].Visible = false;
                foreach (DataGridViewColumn DataGridViewColumn1 in dataGridViewX1.Columns)
                {
                    DataGridViewColumn1.DefaultCellStyle.Font = new Font("B koodak", 20F, GraphicsUnit.Pixel);
                }
                DataGridViewCellStyle HeaderStyle = new DataGridViewCellStyle();

                HeaderStyle.Font = new Font("B koodak", 10, FontStyle.Bold);

                dataGridViewX1.Columns[0].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[0].HeaderText = "وضعیت حضور";
                dataGridViewX1.Columns[1].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[1].HeaderText = "تاریخ";
                dataGridViewX1.Columns[3].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[3].HeaderText = "نام";
                dataGridViewX1.Columns[4].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[4].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[5].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[5].HeaderText = "کدملی";
                dataGridViewX1.Columns[6].HeaderCell.Style = HeaderStyle;
                dataGridViewX1.Columns[6].HeaderText = "پایه";
            }
        }
        private void PersianCalender_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            txtDate.Text = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString();
        }
        private void hozorghyab_Load(object sender, EventArgs e)
        {
            dataGridViewX1.Hide();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
