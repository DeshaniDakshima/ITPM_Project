
namespace ITPM_Project
{
    partial class ManageSession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSubGroupMS = new System.Windows.Forms.ComboBox();
            this.textNoOfStudentMS = new System.Windows.Forms.TextBox();
            this.SessionGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.manageSubjectTopic = new System.Windows.Forms.Label();
            this.cmdGroupMS = new System.Windows.Forms.ComboBox();
            this.cmdSubjectMS = new System.Windows.Forms.ComboBox();
            this.cmdTagMS = new System.Windows.Forms.ComboBox();
            this.cmdDurationMS = new System.Windows.Forms.ComboBox();
            this.cmdLecturer2MS = new System.Windows.Forms.ComboBox();
            this.txtSearchMS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdLecturer1MS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmdSubGroupMS);
            this.groupBox1.Controls.Add(this.textNoOfStudentMS);
            this.groupBox1.Controls.Add(this.SessionGridView);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.manageSubjectTopic);
            this.groupBox1.Controls.Add(this.cmdGroupMS);
            this.groupBox1.Controls.Add(this.cmdSubjectMS);
            this.groupBox1.Controls.Add(this.cmdTagMS);
            this.groupBox1.Controls.Add(this.cmdDurationMS);
            this.groupBox1.Controls.Add(this.cmdLecturer2MS);
            this.groupBox1.Controls.Add(this.txtSearchMS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmdLecturer1MS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 886);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdSubGroupMS
            // 
            this.cmdSubGroupMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSubGroupMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubGroupMS.FormattingEnabled = true;
            this.cmdSubGroupMS.Location = new System.Drawing.Point(783, 176);
            this.cmdSubGroupMS.Name = "cmdSubGroupMS";
            this.cmdSubGroupMS.Size = new System.Drawing.Size(242, 30);
            this.cmdSubGroupMS.TabIndex = 109;
            // 
            // textNoOfStudentMS
            // 
            this.textNoOfStudentMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNoOfStudentMS.Location = new System.Drawing.Point(783, 253);
            this.textNoOfStudentMS.Name = "textNoOfStudentMS";
            this.textNoOfStudentMS.Size = new System.Drawing.Size(242, 30);
            this.textNoOfStudentMS.TabIndex = 108;
            // 
            // SessionGridView
            // 
            this.SessionGridView.AllowUserToAddRows = false;
            this.SessionGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.SessionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SessionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessionGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.SessionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SessionGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SessionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SessionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SessionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionGridView.DoubleBuffered = true;
            this.SessionGridView.EnableHeadersVisualStyles = false;
            this.SessionGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.SessionGridView.HeaderForeColor = System.Drawing.Color.White;
            this.SessionGridView.Location = new System.Drawing.Point(26, 437);
            this.SessionGridView.Name = "SessionGridView";
            this.SessionGridView.ReadOnly = true;
            this.SessionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SessionGridView.RowHeadersVisible = false;
            this.SessionGridView.RowHeadersWidth = 51;
            this.SessionGridView.RowTemplate.Height = 24;
            this.SessionGridView.RowTemplate.ReadOnly = true;
            this.SessionGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SessionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessionGridView.Size = new System.Drawing.Size(1264, 411);
            this.SessionGridView.TabIndex = 107;
            this.SessionGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SessionGridView_CellClick);
            this.SessionGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SessionGridView_RowHeaderMouseClick);
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
            this.btnDelete.Location = new System.Drawing.Point(1131, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 57);
            this.btnDelete.TabIndex = 106;
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
            this.btnUpdate.Location = new System.Drawing.Point(1131, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 57);
            this.btnUpdate.TabIndex = 105;
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
            this.btnClear.Location = new System.Drawing.Point(1131, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 57);
            this.btnClear.TabIndex = 104;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // manageSubjectTopic
            // 
            this.manageSubjectTopic.AutoSize = true;
            this.manageSubjectTopic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubjectTopic.Location = new System.Drawing.Point(495, 26);
            this.manageSubjectTopic.Name = "manageSubjectTopic";
            this.manageSubjectTopic.Size = new System.Drawing.Size(206, 32);
            this.manageSubjectTopic.TabIndex = 103;
            this.manageSubjectTopic.Text = "Manage Session";
            // 
            // cmdGroupMS
            // 
            this.cmdGroupMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdGroupMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGroupMS.FormattingEnabled = true;
            this.cmdGroupMS.Location = new System.Drawing.Point(225, 253);
            this.cmdGroupMS.Name = "cmdGroupMS";
            this.cmdGroupMS.Size = new System.Drawing.Size(242, 30);
            this.cmdGroupMS.TabIndex = 102;
            // 
            // cmdSubjectMS
            // 
            this.cmdSubjectMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSubjectMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubjectMS.FormattingEnabled = true;
            this.cmdSubjectMS.Location = new System.Drawing.Point(225, 325);
            this.cmdSubjectMS.Name = "cmdSubjectMS";
            this.cmdSubjectMS.Size = new System.Drawing.Size(242, 30);
            this.cmdSubjectMS.TabIndex = 101;
            // 
            // cmdTagMS
            // 
            this.cmdTagMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTagMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTagMS.FormattingEnabled = true;
            this.cmdTagMS.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.cmdTagMS.Location = new System.Drawing.Point(783, 103);
            this.cmdTagMS.Name = "cmdTagMS";
            this.cmdTagMS.Size = new System.Drawing.Size(242, 30);
            this.cmdTagMS.TabIndex = 100;
            // 
            // cmdDurationMS
            // 
            this.cmdDurationMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdDurationMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDurationMS.FormattingEnabled = true;
            this.cmdDurationMS.Items.AddRange(new object[] {
            "1 hours",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours"});
            this.cmdDurationMS.Location = new System.Drawing.Point(783, 328);
            this.cmdDurationMS.Name = "cmdDurationMS";
            this.cmdDurationMS.Size = new System.Drawing.Size(242, 30);
            this.cmdDurationMS.TabIndex = 99;
            // 
            // cmdLecturer2MS
            // 
            this.cmdLecturer2MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdLecturer2MS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLecturer2MS.FormattingEnabled = true;
            this.cmdLecturer2MS.Location = new System.Drawing.Point(225, 176);
            this.cmdLecturer2MS.Name = "cmdLecturer2MS";
            this.cmdLecturer2MS.Size = new System.Drawing.Size(242, 30);
            this.cmdLecturer2MS.TabIndex = 98;
            // 
            // txtSearchMS
            // 
            this.txtSearchMS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMS.Location = new System.Drawing.Point(225, 393);
            this.txtSearchMS.Name = "txtSearchMS";
            this.txtSearchMS.Size = new System.Drawing.Size(535, 30);
            this.txtSearchMS.TabIndex = 97;
            this.txtSearchMS.TextChanged += new System.EventHandler(this.txtSearchMS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 22);
            this.label8.TabIndex = 96;
            this.label8.Text = "Search Lecturer";
            // 
            // cmdLecturer1MS
            // 
            this.cmdLecturer1MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdLecturer1MS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLecturer1MS.FormattingEnabled = true;
            this.cmdLecturer1MS.Location = new System.Drawing.Point(225, 103);
            this.cmdLecturer1MS.Name = "cmdLecturer1MS";
            this.cmdLecturer1MS.Size = new System.Drawing.Size(242, 30);
            this.cmdLecturer1MS.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 22);
            this.label11.TabIndex = 85;
            this.label11.Text = "Select Lecturer 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "Select Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 88;
            this.label2.Text = "Select Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 89;
            this.label3.Text = "Select Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Select Lecturer 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 91;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 22);
            this.label6.TabIndex = 92;
            this.label6.Text = "Number of Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 22);
            this.label7.TabIndex = 93;
            this.label7.Text = "Select Sub Group";
            // 
            // ManageSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 886);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageSession";
            this.Text = "Instritute of ABC";
            this.Load += new System.EventHandler(this.ManageSession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public FontAwesome.Sharp.IconButton btnDelete;
        public FontAwesome.Sharp.IconButton btnUpdate;
        public FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.Label manageSubjectTopic;
        private System.Windows.Forms.ComboBox cmdGroupMS;
        private System.Windows.Forms.ComboBox cmdSubjectMS;
        private System.Windows.Forms.ComboBox cmdTagMS;
        private System.Windows.Forms.ComboBox cmdDurationMS;
        private System.Windows.Forms.ComboBox cmdLecturer2MS;
        private System.Windows.Forms.TextBox txtSearchMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmdLecturer1MS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid SessionGridView;
        private System.Windows.Forms.ComboBox cmdSubGroupMS;
        private System.Windows.Forms.TextBox textNoOfStudentMS;
    }
}