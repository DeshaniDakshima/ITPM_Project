
namespace ITPM_Project
{
    partial class ManageSubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSubNameMS = new System.Windows.Forms.TextBox();
            this.txtSubCodeMS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOfferedYearMS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSelectLecturer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.manageSubjectTopic = new System.Windows.Forms.Label();
            this.SubGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmdLecHoursMS = new System.Windows.Forms.ComboBox();
            this.cmdTuteHoursMS = new System.Windows.Forms.ComboBox();
            this.cmdLabHoursMS = new System.Windows.Forms.ComboBox();
            this.cmdEvaluHoursMS = new System.Windows.Forms.ComboBox();
            this.cmdOfferedSemMS = new System.Windows.Forms.ComboBox();
            this.txtSearchMS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubNameMS
            // 
            this.txtSubNameMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubNameMS.Location = new System.Drawing.Point(214, 250);
            this.txtSubNameMS.Name = "txtSubNameMS";
            this.txtSubNameMS.Size = new System.Drawing.Size(244, 30);
            this.txtSubNameMS.TabIndex = 55;
            // 
            // txtSubCodeMS
            // 
            this.txtSubCodeMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCodeMS.Location = new System.Drawing.Point(214, 322);
            this.txtSubCodeMS.Name = "txtSubCodeMS";
            this.txtSubCodeMS.Size = new System.Drawing.Size(244, 30);
            this.txtSubCodeMS.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Number of Tutorial Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Number of Lab Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Number of Evaluation Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Offered Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Subject Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Number of Lecture Hours";
            // 
            // cmdOfferedYearMS
            // 
            this.cmdOfferedYearMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdOfferedYearMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOfferedYearMS.FormattingEnabled = true;
            this.cmdOfferedYearMS.Items.AddRange(new object[] {
            "1 st year",
            "2 nd year",
            "3 rd year",
            "4 th year"});
            this.cmdOfferedYearMS.Location = new System.Drawing.Point(214, 100);
            this.cmdOfferedYearMS.Name = "cmdOfferedYearMS";
            this.cmdOfferedYearMS.Size = new System.Drawing.Size(244, 30);
            this.cmdOfferedYearMS.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 22);
            this.label11.TabIndex = 39;
            this.label11.Text = "Offered Year";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmdSelectLecturer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.manageSubjectTopic);
            this.groupBox1.Controls.Add(this.SubGridView);
            this.groupBox1.Controls.Add(this.cmdLecHoursMS);
            this.groupBox1.Controls.Add(this.cmdTuteHoursMS);
            this.groupBox1.Controls.Add(this.cmdLabHoursMS);
            this.groupBox1.Controls.Add(this.cmdEvaluHoursMS);
            this.groupBox1.Controls.Add(this.cmdOfferedSemMS);
            this.groupBox1.Controls.Add(this.txtSearchMS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSubNameMS);
            this.groupBox1.Controls.Add(this.cmdOfferedYearMS);
            this.groupBox1.Controls.Add(this.txtSubCodeMS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 886);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdSelectLecturer
            // 
            this.cmdSelectLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSelectLecturer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectLecturer.FormattingEnabled = true;
            this.cmdSelectLecturer.Location = new System.Drawing.Point(214, 390);
            this.cmdSelectLecturer.Name = "cmdSelectLecturer";
            this.cmdSelectLecturer.Size = new System.Drawing.Size(244, 30);
            this.cmdSelectLecturer.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 85;
            this.label9.Text = "Offered Lecturer";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1120, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 75);
            this.btnDelete.TabIndex = 84;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1120, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 75);
            this.btnUpdate.TabIndex = 83;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(1120, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 75);
            this.btnClear.TabIndex = 82;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // manageSubjectTopic
            // 
            this.manageSubjectTopic.AutoSize = true;
            this.manageSubjectTopic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubjectTopic.Location = new System.Drawing.Point(484, 23);
            this.manageSubjectTopic.Name = "manageSubjectTopic";
            this.manageSubjectTopic.Size = new System.Drawing.Size(208, 32);
            this.manageSubjectTopic.TabIndex = 72;
            this.manageSubjectTopic.Text = "Manage Subject";
            // 
            // SubGridView
            // 
            this.SubGridView.AllowUserToAddRows = false;
            this.SubGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.SubGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.SubGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SubGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubGridView.DoubleBuffered = true;
            this.SubGridView.EnableHeadersVisualStyles = false;
            this.SubGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.SubGridView.HeaderForeColor = System.Drawing.Color.White;
            this.SubGridView.Location = new System.Drawing.Point(26, 490);
            this.SubGridView.Name = "SubGridView";
            this.SubGridView.ReadOnly = true;
            this.SubGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SubGridView.RowHeadersVisible = false;
            this.SubGridView.RowHeadersWidth = 51;
            this.SubGridView.RowTemplate.Height = 24;
            this.SubGridView.RowTemplate.ReadOnly = true;
            this.SubGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubGridView.Size = new System.Drawing.Size(1266, 370);
            this.SubGridView.TabIndex = 71;
            this.SubGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubGridView_CellClick);
            this.SubGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubGridView_CellContentClick);
            // 
            // cmdLecHoursMS
            // 
            this.cmdLecHoursMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdLecHoursMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLecHoursMS.FormattingEnabled = true;
            this.cmdLecHoursMS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdLecHoursMS.Location = new System.Drawing.Point(772, 100);
            this.cmdLecHoursMS.Name = "cmdLecHoursMS";
            this.cmdLecHoursMS.Size = new System.Drawing.Size(244, 30);
            this.cmdLecHoursMS.TabIndex = 66;
            // 
            // cmdTuteHoursMS
            // 
            this.cmdTuteHoursMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTuteHoursMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTuteHoursMS.FormattingEnabled = true;
            this.cmdTuteHoursMS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdTuteHoursMS.Location = new System.Drawing.Point(772, 171);
            this.cmdTuteHoursMS.Name = "cmdTuteHoursMS";
            this.cmdTuteHoursMS.Size = new System.Drawing.Size(244, 30);
            this.cmdTuteHoursMS.TabIndex = 65;
            // 
            // cmdLabHoursMS
            // 
            this.cmdLabHoursMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdLabHoursMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLabHoursMS.FormattingEnabled = true;
            this.cmdLabHoursMS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdLabHoursMS.Location = new System.Drawing.Point(772, 250);
            this.cmdLabHoursMS.Name = "cmdLabHoursMS";
            this.cmdLabHoursMS.Size = new System.Drawing.Size(244, 30);
            this.cmdLabHoursMS.TabIndex = 64;
            // 
            // cmdEvaluHoursMS
            // 
            this.cmdEvaluHoursMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdEvaluHoursMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEvaluHoursMS.FormattingEnabled = true;
            this.cmdEvaluHoursMS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdEvaluHoursMS.Location = new System.Drawing.Point(772, 325);
            this.cmdEvaluHoursMS.Name = "cmdEvaluHoursMS";
            this.cmdEvaluHoursMS.Size = new System.Drawing.Size(244, 30);
            this.cmdEvaluHoursMS.TabIndex = 63;
            // 
            // cmdOfferedSemMS
            // 
            this.cmdOfferedSemMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdOfferedSemMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOfferedSemMS.FormattingEnabled = true;
            this.cmdOfferedSemMS.Items.AddRange(new object[] {
            "1 st semester",
            "2 nd semester"});
            this.cmdOfferedSemMS.Location = new System.Drawing.Point(214, 173);
            this.cmdOfferedSemMS.Name = "cmdOfferedSemMS";
            this.cmdOfferedSemMS.Size = new System.Drawing.Size(244, 30);
            this.cmdOfferedSemMS.TabIndex = 62;
            // 
            // txtSearchMS
            // 
            this.txtSearchMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMS.Location = new System.Drawing.Point(214, 444);
            this.txtSearchMS.Name = "txtSearchMS";
            this.txtSearchMS.Size = new System.Drawing.Size(537, 30);
            this.txtSearchMS.TabIndex = 58;
            this.txtSearchMS.TextChanged += new System.EventHandler(this.txtSearchMS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 57;
            this.label8.Text = "Search Subject";
            // 
            // ManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 886);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageSubject";
            this.Text = " Instritute of ABC";
            this.Load += new System.EventHandler(this.ManageSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubNameMS;
        private System.Windows.Forms.TextBox txtSubCodeMS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdOfferedYearMS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmdLecHoursMS;
        private System.Windows.Forms.ComboBox cmdTuteHoursMS;
        private System.Windows.Forms.ComboBox cmdLabHoursMS;
        private System.Windows.Forms.ComboBox cmdEvaluHoursMS;
        private System.Windows.Forms.ComboBox cmdOfferedSemMS;
        private System.Windows.Forms.Label manageSubjectTopic;
        private Bunifu.Framework.UI.BunifuCustomDataGrid SubGridView;
        public FontAwesome.Sharp.IconButton btnDelete;
        public FontAwesome.Sharp.IconButton btnUpdate;
        public FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.ComboBox cmdSelectLecturer;
        private System.Windows.Forms.Label label9;
    }
}