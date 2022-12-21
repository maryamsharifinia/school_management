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
        
    public partial class log_in : Form
    {


        public log_in()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            use u = new use();
            u.username= textBoxX1.Text;
            u.password = textBoxX2.Text;
            if (u.username == "modir"&&u.password=="123456") 
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else
            { bl_std b = new bl_std();
                
             if(b.exist_log(textBoxX1.Text,textBoxX2.Text))
                    {
                    this.Hide();
                    moalem f = new moalem();
                    moalem2 f2 = new moalem2();
                    Form2 f3 = new Form2();
                    m4 f4 = new m4();
                    m5 f5 = new m5();
                    m6 f6 = new m6();
                   long a;
                    a = Convert.ToInt64(textBoxX2.Text) % 10;
                    if (a == 1)
                    { f.Show(); }
                    else if(a==2)
                    { f2.ShowDialog(); }
                    else if (a == 3)
                    { f3.ShowDialog(); }
                    else if (a == 4)
                    { f4.ShowDialog(); }
                    else if (a == 5)
                    { f5.ShowDialog(); }
                    else if (a == 6)
                    { f6.ShowDialog(); }
                   

                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور غلط است .");
                }
            }
        }

        private void log_in_Load(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
