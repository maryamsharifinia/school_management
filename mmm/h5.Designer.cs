namespace mmm
{
    partial class h5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(h5));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersianCalender = new BehComponents.MonthCalendarX();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("B Koodak", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox3.Location = new System.Drawing.Point(251, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 34);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("B Koodak", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(251, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 34);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Koodak", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(251, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 34);
            this.textBox1.TabIndex = 9;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("B Koodak", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(277, 246);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(89, 34);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "غیبت";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(209, 451);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.PersianCalender.Location = new System.Drawing.Point(448, 13);
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
            this.PersianCalender.Size = new System.Drawing.Size(170, 183);
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
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.Location = new System.Drawing.Point(448, 203);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(170, 30);
            this.txtDate.TabIndex = 2;
            // 
            // h5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mmm.Properties.Resources.blue_wave;
            this.ClientSize = new System.Drawing.Size(627, 449);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PersianCalender);
            this.Controls.Add(this.txtDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "h5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "h5";
            this.Load += new System.EventHandler(this.h5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BehComponents.MonthCalendarX PersianCalender;
        private System.Windows.Forms.TextBox txtDate;
    }
}