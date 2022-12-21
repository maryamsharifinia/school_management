namespace mmm
{
    partial class jalse
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jalse));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.bubbleButton2 = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton1 = new DevComponents.DotNetBar.BubbleButton();
            this.PersianCalender = new BehComponents.MonthCalendarX();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 301);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(800, 149);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            // 
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.AntiAlias = true;
            this.bubbleBar1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.bubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bubbleBar1.ImageSizeLarge = new System.Drawing.Size(100, 100);
            this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(50, 50);
            this.bubbleBar1.Location = new System.Drawing.Point(0, 0);
            this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar1.Name = "bubbleBar1";
            this.bubbleBar1.SelectedTab = this.bubbleBarTab1;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar1.Size = new System.Drawing.Size(800, 61);
            this.bubbleBar1.TabIndex = 1;
            this.bubbleBar1.Tabs.Add(this.bubbleBarTab1);
            this.bubbleBar1.Text = "bubbleBar1";
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.bubbleButton2,
            this.bubbleButton1});
            this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab1.Text = "bubbleBarTab1";
            this.bubbleBarTab1.TextColor = System.Drawing.Color.Black;
            // 
            // bubbleButton2
            // 
            this.bubbleButton2.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton2.Image")));
            this.bubbleButton2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton2.ImageLarge")));
            this.bubbleButton2.Name = "bubbleButton2";
            this.bubbleButton2.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton2_Click);
            // 
            // bubbleButton1
            // 
            this.bubbleButton1.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton1.Image")));
            this.bubbleButton1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton1.ImageLarge")));
            this.bubbleButton1.Name = "bubbleButton1";
            this.bubbleButton1.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton1_Click);
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
            this.PersianCalender.Location = new System.Drawing.Point(630, 68);
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
            this.PersianCalender.Load += new System.EventHandler(this.jalse_Load);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.Location = new System.Drawing.Point(630, 258);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(170, 30);
            this.txtDate.TabIndex = 2;
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Location = new System.Drawing.Point(414, 132);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(113, 21);
            this.textBoxX3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(546, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "علت جلسه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(532, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "مخاطب جلسه";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("0 Titr Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(94, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(298, 163);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "توضیحات بیشتر";
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.Location = new System.Drawing.Point(414, 173);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(113, 21);
            this.textBoxX4.TabIndex = 15;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(580, 371);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(116, 29);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 17;
            this.buttonX1.Text = "ثبت جلسه";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX2.Location = new System.Drawing.Point(492, 247);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(122, 41);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 18;
            this.buttonX2.Text = "جست و جو ";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Location = new System.Drawing.Point(12, 221);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(196, 57);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.TabIndex = 19;
            this.buttonX3.Text = "جست و جو همه جلسات ";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // jalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.PersianCalender);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.bubbleBar1);
            this.Controls.Add(this.dataGridViewX1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "jalse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jalse";
            this.Load += new System.EventHandler(this.jalse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.BubbleBar bubbleBar1;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        private DevComponents.DotNetBar.BubbleButton bubbleButton2;
        private DevComponents.DotNetBar.BubbleButton bubbleButton1;
        private BehComponents.MonthCalendarX PersianCalender;
        private System.Windows.Forms.TextBox txtDate;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
    }
}