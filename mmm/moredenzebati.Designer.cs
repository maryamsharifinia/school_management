using System;

namespace mmm
{
    partial class moredenzebati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moredenzebati));
            this.PersianCalender = new BehComponents.MonthCalendarX();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersianCalender
            // 
            this.PersianCalender.BoldedDayForeColor = System.Drawing.Color.Blue;
            this.PersianCalender.BorderColor = System.Drawing.Color.CadetBlue;
            this.PersianCalender.CalendarType = BehComponents.CalendarTypes.Persian;
            this.PersianCalender.DayRectTickness = 2F;
            this.PersianCalender.DaysBackColor = System.Drawing.Color.White;
            this.PersianCalender.DaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalender.DaysForeColor = System.Drawing.Color.Black;
            this.PersianCalender.EnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.PersianCalender.EnglishBoldedDates = new System.DateTime[0];
            this.PersianCalender.EnglishHolidayDates = new System.DateTime[0];
            this.PersianCalender.EnglishMonthlyBoldedDates = new System.DateTime[0];
            this.PersianCalender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalender.HolidayForeColor = System.Drawing.Color.Red;
            this.PersianCalender.HolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.PersianCalender.LineWeekColor = System.Drawing.Color.Black;
            this.PersianCalender.Location = new System.Drawing.Point(331, 23);
            this.PersianCalender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersianCalender.Name = "PersianCalender";
            this.PersianCalender.PersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.ShowToday = true;
            this.PersianCalender.ShowTodayRect = true;
            this.PersianCalender.ShowToolTips = false;
            this.PersianCalender.ShowTrailing = true;
            this.PersianCalender.Size = new System.Drawing.Size(176, 183);
            this.PersianCalender.Style_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.PersianCalender.Style_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.PersianCalender.Style_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.PersianCalender.TabIndex = 0;
            this.PersianCalender.TitleBackColor = System.Drawing.Color.White;
            this.PersianCalender.TitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.PersianCalender.TitleForeColor = System.Drawing.Color.Black;
            this.PersianCalender.TodayBackColor = System.Drawing.Color.White;
            this.PersianCalender.TodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PersianCalender.TodayForeColor = System.Drawing.Color.Black;
            this.PersianCalender.TodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PersianCalender.TodayRectTickness = 2F;
            this.PersianCalender.TrailingForeColor = System.Drawing.Color.DarkGray;
            this.PersianCalender.WeekDaysBackColor = System.Drawing.Color.White;
            this.PersianCalender.WeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.PersianCalender.WeekDaysForeColor = System.Drawing.Color.Blue;
            this.PersianCalender.WeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.PersianCalender.SelectedDateChanged += new BehComponents.MonthCalendarX.OnSelectedDateChanged(this.PersianCalender_SelectedDateChanged);
            this.PersianCalender.Load += new System.EventHandler(this.moredenzebati_load);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.Location = new System.Drawing.Point(331, 213);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(176, 30);
            this.txtDate.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("0 Koodak Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(33, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(60, 173);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(116, 33);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "ثبت مورد انضباطی ";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(206, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "علت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(206, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "مقدار کسر نمره ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(403, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(403, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "نام خانوادگی";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("0 Koodak Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(33, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 34);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("0 Koodak Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox3.Location = new System.Drawing.Point(230, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 34);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("0 Koodak Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox4.Location = new System.Drawing.Point(230, 362);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 34);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(206, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "کد ملی";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("0 Koodak Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox5.Location = new System.Drawing.Point(33, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 34);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX2.Location = new System.Drawing.Point(99, 360);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(104, 36);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 17;
            this.buttonX2.Text = "جست و جو ";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // moredenzebati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mmm.Properties.Resources.blue_wave;
            this.ClientSize = new System.Drawing.Size(516, 564);
            this.Controls.Add(this.PersianCalender);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "moredenzebati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "moredenzebati";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void moredenzebati_load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        /// <summary>
        ///   A strongly-typed resource class, for looking up localized strings, etc.
        /// </summary>
        // This class was auto-generated by the StronglyTypedResourceBuilder
        // class via a tool like ResGen or Visual Studio.
        // To add or remove a member, edit your .ResX file then rerun ResGen
        // with the /str option, or rebuild your VS project.
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        internal class Resources
        {

            private static global::System.Resources.ResourceManager resourceMan;

            private static global::System.Globalization.CultureInfo resourceCulture;

            [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            internal Resources()
            {
            }

            /// <summary>
            ///   Returns the cached ResourceManager instance used by this class.
            /// </summary>
            [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
            internal static global::System.Resources.ResourceManager ResourceManager
            {
                get
                {
                    if ((resourceMan == null))
                    {
                        global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PersianCalender.Properties.Resources", typeof(Resources).Assembly);
                        resourceMan = temp;
                    }
                    return resourceMan;
                }
            }

            /// <summary>
            ///   Overrides the current thread's CurrentUICulture property for all
            ///   resource lookups using this strongly typed resource class.
            /// </summary>
            [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
            internal static global::System.Globalization.CultureInfo Culture
            {
                get
                {
                    return resourceCulture;
                }
                set
                {
                    resourceCulture = value;
                }
            }
        }

        private BehComponents.MonthCalendarX PersianCalender;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox textBox1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}