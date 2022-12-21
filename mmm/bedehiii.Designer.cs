namespace mmm
{
    partial class bedehiii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bedehiii));
            this.elat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mablagh_bedehi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.add_bedehi = new DevComponents.DotNetBar.ButtonX();
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.بدهی = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.bubbleButton1 = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton2 = new DevComponents.DotNetBar.BubbleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.payeh = new System.Windows.Forms.ComboBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxX6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.kod_bedehi = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // elat
            // 
            // 
            // 
            // 
            this.elat.Border.Class = "TextBoxBorder";
            this.elat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elat.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.elat.Location = new System.Drawing.Point(95, 96);
            this.elat.Name = "elat";
            this.elat.PreventEnterBeep = true;
            this.elat.Size = new System.Drawing.Size(153, 40);
            this.elat.TabIndex = 1;
            this.elat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.elat.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.elat.WatermarkText = "علت بدهی ";
            // 
            // mablagh_bedehi
            // 
            // 
            // 
            // 
            this.mablagh_bedehi.Border.Class = "TextBoxBorder";
            this.mablagh_bedehi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mablagh_bedehi.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mablagh_bedehi.Location = new System.Drawing.Point(95, 144);
            this.mablagh_bedehi.Name = "mablagh_bedehi";
            this.mablagh_bedehi.PreventEnterBeep = true;
            this.mablagh_bedehi.Size = new System.Drawing.Size(153, 40);
            this.mablagh_bedehi.TabIndex = 2;
            this.mablagh_bedehi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mablagh_bedehi.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.mablagh_bedehi.WatermarkText = "(مبلغ (به تومان";
            this.mablagh_bedehi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bedehiii_KeyPress);
            // 
            // add_bedehi
            // 
            this.add_bedehi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.add_bedehi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.add_bedehi.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.add_bedehi.Location = new System.Drawing.Point(108, 196);
            this.add_bedehi.Name = "add_bedehi";
            this.add_bedehi.Size = new System.Drawing.Size(130, 34);
            this.add_bedehi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.add_bedehi.TabIndex = 3;
            this.add_bedehi.Text = "اضافه کردن بدهی";
            this.add_bedehi.Click += new System.EventHandler(this.add_bedehi_Click);
            // 
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.AntiAlias = true;
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
            this.bubbleBar1.SelectedTab = this.بدهی;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar1.Size = new System.Drawing.Size(642, 90);
            this.bubbleBar1.TabIndex = 4;
            this.bubbleBar1.Tabs.Add(this.بدهی);
            this.bubbleBar1.Text = "bubbleBar1";
            this.bubbleBar1.ButtonClick += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleBar1_ButtonClick);
            // 
            // بدهی
            // 
            this.بدهی.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.بدهی.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.بدهی.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.bubbleButton1,
            this.bubbleButton2});
            this.بدهی.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.بدهی.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.بدهی.Name = "بدهی";
            this.بدهی.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.بدهی.Text = "بدهی";
            this.بدهی.TextColor = System.Drawing.Color.Black;
            // 
            // bubbleButton1
            // 
            this.bubbleButton1.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton1.Image")));
            this.bubbleButton1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton1.ImageLarge")));
            this.bubbleButton1.Name = "bubbleButton1";
            this.bubbleButton1.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton1_Click);
            // 
            // bubbleButton2
            // 
            this.bubbleButton2.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton2.Image")));
            this.bubbleButton2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton2.ImageLarge")));
            this.bubbleButton2.Name = "bubbleButton2";
            this.bubbleButton2.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 182);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxX1.Location = new System.Drawing.Point(453, 190);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(153, 40);
            this.textBoxX1.TabIndex = 6;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX1.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxX1.WatermarkText = "کدملی";
            this.textBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bedehiii_KeyPress);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(453, 238);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(153, 40);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "جست‌وجو  بدهی ها";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxX2.Location = new System.Drawing.Point(453, 142);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(153, 40);
            this.textBoxX2.TabIndex = 8;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX2.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxX2.WatermarkText = "نام خانوادگی";
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxX3.Location = new System.Drawing.Point(453, 96);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(153, 40);
            this.textBoxX3.TabIndex = 9;
            this.textBoxX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX3.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxX3.WatermarkText = "نام";
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxX4.Location = new System.Drawing.Point(385, 96);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(153, 40);
            this.textBoxX4.TabIndex = 11;
            this.textBoxX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX4.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxX4.WatermarkText = "نام";
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxX5.Location = new System.Drawing.Point(385, 142);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.PreventEnterBeep = true;
            this.textBoxX5.Size = new System.Drawing.Size(153, 40);
            this.textBoxX5.TabIndex = 10;
            this.textBoxX5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX5.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxX5.WatermarkText = "نام خانوادگی";
            // 
            // payeh
            // 
            this.payeh.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.payeh.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.payeh.FormattingEnabled = true;
            this.payeh.Items.AddRange(new object[] {
            "اول",
            "دوم ",
            "سوم ",
            "چهارم",
            "پنجم ",
            "ششم"});
            this.payeh.Location = new System.Drawing.Point(385, 237);
            this.payeh.Name = "payeh";
            this.payeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.payeh.Size = new System.Drawing.Size(153, 41);
            this.payeh.TabIndex = 12;
            this.payeh.Text = "پایه";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX2.Location = new System.Drawing.Point(351, 285);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(220, 40);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 13;
            this.buttonX2.Text = "جست وجو بین دانش آموزان";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(642, 166);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBoxX6
            // 
            // 
            // 
            // 
            this.textBoxX6.Border.Class = "TextBoxBorder";
            this.textBoxX6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX6.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxX6.Location = new System.Drawing.Point(254, 96);
            this.textBoxX6.Name = "textBoxX6";
            this.textBoxX6.PreventEnterBeep = true;
            this.textBoxX6.Size = new System.Drawing.Size(153, 40);
            this.textBoxX6.TabIndex = 15;
            this.textBoxX6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX6.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxX6.WatermarkText = "(مبلغ (به تومان";
            this.textBoxX6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bedehiii_KeyPress);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Location = new System.Drawing.Point(283, 142);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(96, 42);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 16;
            this.buttonX3.Text = "پرداخت شد";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // kod_bedehi
            // 
            this.kod_bedehi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.kod_bedehi.Border.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.kod_bedehi.Border.Class = "TextBoxBorder";
            this.kod_bedehi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.kod_bedehi.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.kod_bedehi.Location = new System.Drawing.Point(385, 191);
            this.kod_bedehi.Name = "kod_bedehi";
            this.kod_bedehi.PreventEnterBeep = true;
            this.kod_bedehi.Size = new System.Drawing.Size(153, 40);
            this.kod_bedehi.TabIndex = 17;
            this.kod_bedehi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kod_bedehi.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.kod_bedehi.WatermarkText = "کدملی";
            this.kod_bedehi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bedehiii_KeyPress);
            // 
            // bedehiii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::mmm.Properties.Resources.blue_wave;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.kod_bedehi);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.textBoxX6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.payeh);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.textBoxX5);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bubbleBar1);
            this.Controls.Add(this.add_bedehi);
            this.Controls.Add(this.mablagh_bedehi);
            this.Controls.Add(this.elat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bedehiii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bedehiii";
            this.Load += new System.EventHandler(this.bedehiii_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bedehiii_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX elat;
        private DevComponents.DotNetBar.Controls.TextBoxX mablagh_bedehi;
        private DevComponents.DotNetBar.ButtonX add_bedehi;
        private DevComponents.DotNetBar.BubbleBar bubbleBar1;
        private DevComponents.DotNetBar.BubbleBarTab بدهی;
        private DevComponents.DotNetBar.BubbleButton bubbleButton1;
        private DevComponents.DotNetBar.BubbleButton bubbleButton2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private System.Windows.Forms.ComboBox payeh;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX6;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.TextBoxX kod_bedehi;
    }
}