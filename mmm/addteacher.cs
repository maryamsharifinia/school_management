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
    public partial class addteacher : Form
    {
        public addteacher()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (name_teach.Text.Trim().Length == 0) { MessageBox.Show(".نام دبیر را وارد کنید"); }
            else if (family_teachbox.Text.Trim().Length == 0) { MessageBox.Show(".نام خانوادگی دبیر را وارد کنید"); }
            else if (kodemeliBox_teach.Text.Trim().Length == 0) { MessageBox.Show(".کد ملی دبیر را وارد کنید"); }
            else if (kodemeliBox_teach.Text.Trim().Length < 10) { MessageBox.Show(".کد ملی دبیر را صحیح وارد کنید"); }
            else if (fathername_teachBOX.Text.Trim().Length == 0) { MessageBox.Show(".نام پدر دبیر را وارد کنید"); }
            else if (payeBox_teach.Text.Trim().Length == 0) { MessageBox.Show(".پایه تحصیلی تدریس دبیر را وارد کنید"); }
            else if (Phone_box.Text.Trim().Length == 0) { MessageBox.Show(". شماره تلفن همراه دبیر را وارد کنید"); }
            else if (Phone_box.Text.Trim().Length < 11) { MessageBox.Show(". شماره تلفن همراه دبیر را صحیح وارد کنید"); }
            else if (home_box.Text.Trim().Length == 0) { MessageBox.Show(".شماره منزل دبیر را وارد کنید"); }
            else if (home_box.Text.Trim().Length < 8) { MessageBox.Show(".شماره منزل دبیر را صحیح وارد کنید"); }
            else if (rezome.Text.Trim().Length == 0) { MessageBox.Show(".رزومه دبیر را وارد کنید"); }
            else if (sabegheBOX.Text.Trim().Length == 0) { MessageBox.Show(".سابقه تدریس دبیر را وارد کنید"); }
            else if (comboBox2.Text.Trim().Length == 0) { MessageBox.Show(".درجه تحصیلی دبیر دبیر را وارد کنید"); }
            else if (textBoxX5.Text.Trim().Length == 0) { MessageBox.Show(".رشته تحصیلی دبیر دبیر را وارد کنید"); }
            else
            {
                teacher td = new teacher();

                td.name_teach = name_teach.Text;
                td.familly_teach = family_teachbox.Text;
                td.fathername_teach = fathername_teachBOX.Text;
                td.kodemeli_teach = kodemeliBox_teach.Text;
                td.homenumber = home_box.Text;
                td.payeh = payeBox_teach.Text;
                td.Phonnumber = Phone_box.Text;
                td.rezome = rezome.Text;
                td.sabeghe = Convert.ToByte(sabegheBOX.Text);
                td.tozih = tozihteach_box.Text;
                td.reshte = comboBox2.Text + " " + textBoxX5.Text;

                bl_std bl = new bl_std();
                bl.createteach(td);
                MessageBox.Show("ثبت نام دبیر انجام شد ");
                if (checkBox1.Checked)
                {
                    use n = new use();
                    n.username = kodemeliBox_teach.Text;
                    if (payeBox_teach.Text == "اول")
                    {
                        n.password = "1" + kodemeliBox_teach.Text + "1";
                    }
                   else if (payeBox_teach.Text == "دوم")
                    {
                        n.password = "2" + kodemeliBox_teach.Text + "2";
                    }
                    else if (payeBox_teach.Text == "سوم")
                    {
                        n.password = "3" + kodemeliBox_teach.Text + "3";
                    }
                    else if (payeBox_teach.Text == "چهارم")
                    {
                        n.password = "4" + kodemeliBox_teach.Text + "4";

                    }
                    else if (payeBox_teach.Text == "پنجم")
                    {
                        n.password = "5" + kodemeliBox_teach.Text + "5";
                    }
                    else if (payeBox_teach.Text == "ششم")
                    {
                        n.password = "6" + kodemeliBox_teach.Text + "6";
                    }
                    
                    bl.create_log(n);
                    MessageBox.Show("نام کاربری برابر با کدملی دبیر است ");
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addteacher_Load(object sender, EventArgs e)
        {
            
           
            label1.BackColor = Color.FromArgb(7, label2.BackColor);
            label1.BackColor = Color.FromArgb(7, label2.BackColor);
            label3.BackColor = Color.FromArgb(7, label2.BackColor);
            label4.BackColor = Color.FromArgb(7, label2.BackColor);
            label5.BackColor = Color.FromArgb(7, label2.BackColor);
            label6.BackColor = Color.FromArgb(7, label2.BackColor);
            label7.BackColor = Color.FromArgb(7, label2.BackColor);
            label8.BackColor = Color.FromArgb(7, label2.BackColor);
            label9.BackColor = Color.FromArgb(7, label2.BackColor);
            label10.BackColor = Color.FromArgb(7, label2.BackColor);
            label15.BackColor = Color.FromArgb(7, label2.BackColor);
            label16.BackColor = Color.FromArgb(7, label2.BackColor);

        }

        private void addteacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }
    }
}
