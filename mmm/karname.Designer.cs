namespace mmm
{
    partial class karname
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karname));
            this.payeh = new System.Windows.Forms.ComboBox();
            this.kod_teach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.family_teach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.name_teach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
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
            this.payeh.Location = new System.Drawing.Point(380, 152);
            this.payeh.Name = "payeh";
            this.payeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.payeh.Size = new System.Drawing.Size(139, 41);
            this.payeh.TabIndex = 9;
            this.payeh.Text = "پایه";
            // 
            // kod_teach
            // 
            // 
            // 
            // 
            this.kod_teach.Border.Class = "TextBoxBorder";
            this.kod_teach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.kod_teach.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.kod_teach.Location = new System.Drawing.Point(638, 152);
            this.kod_teach.MaxLength = 10;
            this.kod_teach.Name = "kod_teach";
            this.kod_teach.PreventEnterBeep = true;
            this.kod_teach.Size = new System.Drawing.Size(166, 40);
            this.kod_teach.TabIndex = 8;
            this.kod_teach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kod_teach.WatermarkText = "کدملی";
            this.kod_teach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kod_teach_KeyPress);
            // 
            // family_teach
            // 
            // 
            // 
            // 
            this.family_teach.Border.Class = "TextBoxBorder";
            this.family_teach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.family_teach.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.family_teach.Location = new System.Drawing.Point(638, 106);
            this.family_teach.Name = "family_teach";
            this.family_teach.PreventEnterBeep = true;
            this.family_teach.Size = new System.Drawing.Size(166, 40);
            this.family_teach.TabIndex = 7;
            this.family_teach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.family_teach.WatermarkText = "نام خانوادگی";
            // 
            // name_teach
            // 
            // 
            // 
            // 
            this.name_teach.Border.Class = "TextBoxBorder";
            this.name_teach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.name_teach.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.name_teach.Location = new System.Drawing.Point(638, 60);
            this.name_teach.Name = "name_teach";
            this.name_teach.PreventEnterBeep = true;
            this.name_teach.Size = new System.Drawing.Size(166, 40);
            this.name_teach.TabIndex = 6;
            this.name_teach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name_teach.WatermarkText = "نام";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("0 Koodak Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(38, 152);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(213, 41);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "جست و جو بین دانش آموزان";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 256);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, -4);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(347, 150);
            this.dataGridViewX1.TabIndex = 12;
            // 
            // karname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mmm.Properties.Resources.vector_abstract_geometric_background_design_element_form_blue_hexagon_vector_abstract_geometric_background_design_element_form_131911559;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.payeh);
            this.Controls.Add(this.kod_teach);
            this.Controls.Add(this.family_teach);
            this.Controls.Add(this.name_teach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "karname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "karname";
            this.Load += new System.EventHandler(this.karname_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox payeh;
        private DevComponents.DotNetBar.Controls.TextBoxX kod_teach;
        private DevComponents.DotNetBar.Controls.TextBoxX family_teach;
        private DevComponents.DotNetBar.Controls.TextBoxX name_teach;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
    }
}