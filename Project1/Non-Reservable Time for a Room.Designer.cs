
namespace WD_R_14
{
    partial class Non_Reservable_Time_for_a_Room
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
            this.cmbday = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbetime = new System.Windows.Forms.ComboBox();
            this.room_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbstime = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbday
            // 
            this.cmbday.BackColor = System.Drawing.Color.White;
            this.cmbday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbday.FormattingEnabled = true;
            this.cmbday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbday.Location = new System.Drawing.Point(527, 320);
            this.cmbday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbday.Name = "cmbday";
            this.cmbday.Size = new System.Drawing.Size(143, 30);
            this.cmbday.TabIndex = 53;
            this.cmbday.SelectedIndexChanged += new System.EventHandler(this.cmbday_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(295, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Non Reservable Tiime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(411, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Room";
            // 
            // cmbetime
            // 
            this.cmbetime.BackColor = System.Drawing.Color.White;
            this.cmbetime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbetime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbetime.FormattingEnabled = true;
            this.cmbetime.Items.AddRange(new object[] {
            "9.00 a.m.",
            "9.30 a.m.",
            "10.00 a.m.",
            "10.30 a.m.",
            "11.00 a.m.",
            "11.30 a.m.",
            "12.00 noon",
            "12.30 noon",
            "1.00 p.m.",
            "1.30 p.m.",
            "2.00 p.m.",
            "2.30 p.m.",
            "3.00 p.m.",
            "3.30 p.m.",
            "4.00 p.m.",
            "4.30 p.m.",
            "5.00 p.m.",
            "5.30 p.m."});
            this.cmbetime.Location = new System.Drawing.Point(765, 400);
            this.cmbetime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbetime.Name = "cmbetime";
            this.cmbetime.Size = new System.Drawing.Size(188, 30);
            this.cmbetime.TabIndex = 47;
            // 
            // room_cmb
            // 
            this.room_cmb.BackColor = System.Drawing.Color.White;
            this.room_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room_cmb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_cmb.FormattingEnabled = true;
            this.room_cmb.Location = new System.Drawing.Point(527, 210);
            this.room_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.room_cmb.Name = "room_cmb";
            this.room_cmb.Size = new System.Drawing.Size(315, 30);
            this.room_cmb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Non Reservable Time for a Room";
            // 
            // cmbstime
            // 
            this.cmbstime.BackColor = System.Drawing.Color.White;
            this.cmbstime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstime.FormattingEnabled = true;
            this.cmbstime.Items.AddRange(new object[] {
            "8.30 a.m.",
            "9.00 a.m.",
            "9.30 a.m.",
            "10.00 a.m.",
            "10.30 a.m.",
            "11.00 a.m.",
            "11.30 a.m.",
            "12.00 noon",
            "12.30 noon",
            "1.00 p.m.",
            "1.30 p.m.",
            "2.00 p.m.",
            "2.30 p.m.",
            "3.00 p.m.",
            "3.30 p.m.",
            "4.00 p.m.",
            "4.30 p.m.",
            "5.00 p.m."});
            this.cmbstime.Location = new System.Drawing.Point(527, 400);
            this.cmbstime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbstime.Name = "cmbstime";
            this.cmbstime.Size = new System.Drawing.Size(188, 30);
            this.cmbstime.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbday);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbstime);
            this.panel1.Controls.Add(this.cmbetime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.room_cmb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 750);
            this.panel1.TabIndex = 55;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(765, 542);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(377, 52);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Allocae as non Reservarle Time";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(527, 542);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(183, 52);
            this.iconButton1.TabIndex = 56;
            this.iconButton1.Text = "Clear";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Non_Reservable_Time_for_a_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1325, 750);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Non_Reservable_Time_for_a_Room";
            this.Text = "Non Reservable Time for a Room";
            this.Load += new System.EventHandler(this.Non_Reservable_Time_for_a_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbetime;
        private System.Windows.Forms.ComboBox room_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbstime;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnAdd;
        public FontAwesome.Sharp.IconButton iconButton1;
    }
}