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
    public partial class add_student : Form
    {
        public add_student()
        {
            InitializeComponent();
        }
       
        public void digitonly(KeyPressEventArgs e)
        { 
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("Enter only digit and decimal point.", "Alert!"); } 
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (name_std.Text.Trim().Length == 0) { MessageBox.Show(".نام دانش آموز را وارد کنید"); }
            else if (family_stdbox.Text.Trim().Length == 0) { MessageBox.Show(".نام خانوادگی دانش آموز را وارد کنید"); }
            else if (kodemeliBox.Text.Trim().Length == 0) { MessageBox.Show(".کد ملی دانش آموز را وارد کنید"); }
            else if (kodemeliBox.Text.Trim().Length < 10) { MessageBox.Show(".کد ملی دانش آموز را صحیح وارد کنید"); }
            else if (fathername_BOX.Text.Trim().Length == 0) { MessageBox.Show(".نام پدر دانش آموز را وارد کنید"); }
            else if (payeBox.Text.Trim().Length == 0) { MessageBox.Show(".پایه تحصیلی دانش آموز را وارد کنید"); }
            else if (motherPhon_Box.Text.Trim().Length == 0 & fatherPhon_Box.Text.Trim().Length==0){ MessageBox.Show(".حداقل شماره تلفن همراه یکی از والدین دانش آموز را وارد کنید"); }
            else if (motherPhon_Box.Text.Trim().Length < 11 & fatherPhon_Box.Text.Trim().Length < 11) { MessageBox.Show(". شماره تلفن همراه والدین دانش آموز را صحیح وارد کنید"); }
            else if (homePhon_Box.Text.Trim().Length == 0) { MessageBox.Show(".شماره منزل دانش آموز را وارد کنید"); }
            //else if (homePhon_Box.Text.Trim().Length <= 12) { MessageBox.Show(".شماره منزل دانش آموز را صحیح وارد کنید"); }
            else if (textBoxX1.Text.Trim().Length == 0) { MessageBox.Show(".شغل مادر دانش آموز را وارد کنید"); }
            else if (textBoxX4.Text.Trim().Length == 0) { MessageBox.Show(".شغل پدر دانش آموز را وارد کنید"); }
            else if (textBoxX2.Text.Trim().Length == 0) { MessageBox.Show(".کدپستی محل سکونت دانش آموز را وارد کنید"); }
            else if (textBoxX2.Text.Trim().Length < 10) { MessageBox.Show(".کدپستی محل سکونت دانش آموز را صحیح وارد کنید"); }
            else if (textBox2.Text.Trim().Length == 0) { MessageBox.Show(".آدرس محل سکونت دانش آموز را وارد کنید"); }
            else if (textBoxX5.Text.Trim().Length == 0) { MessageBox.Show(".رشته تحصیلی پدر دانش آموز را وارد کنید"); }
            else if (textBoxX3.Text.Trim().Length == 0) { MessageBox.Show(".رشته تحصیلی مادر دانش آموز را وارد کنید"); }
            else if (comboBox1.Text.Trim().Length == 0) { MessageBox.Show(".درجه تحصیلی مادر دانش آموز را وارد کنید"); }
            else if (comboBox2.Text.Trim().Length == 0) { MessageBox.Show(".درجه تحصیلی پدر دانش آموز را وارد کنید"); }
            else
            { information_std std = new information_std();
                
                std.name_std = name_std.Text;
                std.familly_std = family_stdbox.Text;
                std.fathername_std = fathername_BOX.Text;
                std.kodemeli = kodemeliBox.Text;
                std.homenumber = homePhon_Box.Text;
                std.payeh = payeBox.Text;
                std.motherphonnumber = motherPhon_Box.Text;
                std.fatherphonnumber = fatherPhon_Box.Text;
                std.job_father = textBoxX4.Text;
                std.job_mother = textBoxX1.Text;
                std.postkode = textBoxX2.Text;
                std.address = textBox2.Text;
                std.tozihat = textBox1.Text;
                std.madrak_father = comboBox2.Text + " " + textBoxX5.Text;
                std.madrak_mother = comboBox1.Text + " " + textBoxX3.Text;
                bl_std bl = new bl_std();
                bl.create1(std);
                MessageBox.Show("ثبت نام دانش آموز انجام شد ");
                shahriee m =new shahriee();
                m.name_std = name_std.Text;
                m.familly_std = family_stdbox.Text;
                m.kodemeli = kodemeliBox.Text;
                m.payeh = payeBox.Text;
                m.shahriepardakhti = 0;
                m.shahriepardakhtnashode = 5000000;
                bl.createshahrie(m);
                bedehii d = new bedehii();
                d.name_std = name_std.Text;
                d.familly_std = family_stdbox.Text;
                d.kodemeli = kodemeliBox.Text;
                d.payeh = payeBox.Text;
                d.bedehi = 0;
                bl.createbedehi(d);
            }

        }

        private void add_student_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(7, label12.BackColor);
            label2.BackColor = Color.FromArgb(7, label12.BackColor);
            label3.BackColor = Color.FromArgb(7, label12.BackColor);
            label4.BackColor = Color.FromArgb(7, label12.BackColor);
            label5.BackColor = Color.FromArgb(7, label12.BackColor);
            label6.BackColor = Color.FromArgb(7, label12.BackColor);
            label7.BackColor = Color.FromArgb(7, label12.BackColor);
            label8.BackColor = Color.FromArgb(7, label12.BackColor);
            label9.BackColor = Color.FromArgb(7, label12.BackColor);
            label10.BackColor = Color.FromArgb(7, label12.BackColor);
            label11.BackColor = Color.FromArgb(7, label12.BackColor);
            label12.BackColor = Color.FromArgb(7, label12.BackColor);
            label13.BackColor = Color.FromArgb(7, label12.BackColor);
            label14.BackColor = Color.FromArgb(7, label12.BackColor);
            label15.BackColor = Color.FromArgb(7, label12.BackColor);
            label16.BackColor = Color.FromArgb(7, label12.BackColor);
            label17.BackColor = Color.FromArgb(7, label12.BackColor);
        }

        private void kodemeliBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            int isNumber = 0;
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }

        }

        private void motherPhon_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }

        private void fatherPhon_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            { e.Handled = true; MessageBox.Show("عدد وارد کنید", "هشدار!"); }
        }
    }
}

