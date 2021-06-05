
namespace ITPM_Project
{
    partial class AddSubject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSelectLecturer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdTuteHours = new System.Windows.Forms.ComboBox();
            this.cmdLabHours = new System.Windows.Forms.ComboBox();
            this.cmdEvaluHours = new System.Windows.Forms.ComboBox();
            this.cmdLecHours = new System.Windows.Forms.ComboBox();
            this.cmdOfferedSem = new System.Windows.Forms.ComboBox();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOfferedYear = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSelectLecturer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmdTuteHours);
            this.groupBox1.Controls.Add(this.cmdLabHours);
            this.groupBox1.Controls.Add(this.cmdEvaluHours);
            this.groupBox1.Controls.Add(this.cmdLecHours);
            this.groupBox1.Controls.Add(this.cmdOfferedSem);
            this.groupBox1.Controls.Add(this.txtSubName);
            this.groupBox1.Controls.Add(this.txtSubCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdOfferedYear);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 886);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdSelectLecturer
            // 
            this.cmdSelectLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSelectLecturer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectLecturer.FormattingEnabled = true;
            this.cmdSelectLecturer.Location = new System.Drawing.Point(279, 653);
            this.cmdSelectLecturer.Name = "cmdSelectLecturer";
            this.cmdSelectLecturer.Size = new System.Drawing.Size(244, 30);
            this.cmdSelectLecturer.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 50;
            this.label9.Text = "Offered Lecturer";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(783, 755);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 52);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
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
            this.btnClear.Location = new System.Drawing.Point(411, 755);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 52);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Add New Subject";
            // 
            // cmdTuteHours
            // 
            this.cmdTuteHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTuteHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTuteHours.FormattingEnabled = true;
            this.cmdTuteHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdTuteHours.Location = new System.Drawing.Point(909, 295);
            this.cmdTuteHours.Name = "cmdTuteHours";
            this.cmdTuteHours.Size = new System.Drawing.Size(244, 30);
            this.cmdTuteHours.TabIndex = 45;
            // 
            // cmdLabHours
            // 
            this.cmdLabHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdLabHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLabHours.FormattingEnabled = true;
            this.cmdLabHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdLabHours.Location = new System.Drawing.Point(909, 414);
            this.cmdLabHours.Name = "cmdLabHours";
            this.cmdLabHours.Size = new System.Drawing.Size(244, 30);
            this.cmdLabHours.TabIndex = 44;
            // 
            // cmdEvaluHours
            // 
            this.cmdEvaluHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdEvaluHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEvaluHours.FormattingEnabled = true;
            this.cmdEvaluHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdEvaluHours.Location = new System.Drawing.Point(909, 538);
            this.cmdEvaluHours.Name = "cmdEvaluHours";
            this.cmdEvaluHours.Size = new System.Drawing.Size(244, 30);
            this.cmdEvaluHours.TabIndex = 43;
            // 
            // cmdLecHours
            // 
            this.cmdLecHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdLecHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLecHours.FormattingEnabled = true;
            this.cmdLecHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdLecHours.Location = new System.Drawing.Point(909, 165);
            this.cmdLecHours.Name = "cmdLecHours";
            this.cmdLecHours.Size = new System.Drawing.Size(244, 30);
            this.cmdLecHours.TabIndex = 42;
            // 
            // cmdOfferedSem
            // 
            this.cmdOfferedSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdOfferedSem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOfferedSem.FormattingEnabled = true;
            this.cmdOfferedSem.Items.AddRange(new object[] {
            "1 st semester",
            "2 nd semester"});
            this.cmdOfferedSem.Location = new System.Drawing.Point(279, 298);
            this.cmdOfferedSem.Name = "cmdOfferedSem";
            this.cmdOfferedSem.Size = new System.Drawing.Size(244, 30);
            this.cmdOfferedSem.TabIndex = 41;
            // 
            // txtSubName
            // 
            this.txtSubName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName.Location = new System.Drawing.Point(279, 419);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(244, 30);
            this.txtSubName.TabIndex = 38;
            // 
            // txtSubCode
            // 
            this.txtSubCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCode.Location = new System.Drawing.Point(279, 543);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(244, 30);
            this.txtSubCode.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Number of Tutorial Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Number of Lab Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Number of Evaluation Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Offered Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Subject Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Number of Lecture Hours";
            // 
            // cmdOfferedYear
            // 
            this.cmdOfferedYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdOfferedYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOfferedYear.FormattingEnabled = true;
            this.cmdOfferedYear.Items.AddRange(new object[] {
            "1 st year",
            "2 nd year",
            "3 rd year",
            "4 th year"});
            this.cmdOfferedYear.Location = new System.Drawing.Point(279, 162);
            this.cmdOfferedYear.Name = "cmdOfferedYear";
            this.cmdOfferedYear.Size = new System.Drawing.Size(244, 30);
            this.cmdOfferedYear.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Offered Year";
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 886);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSubject";
            this.Text = "Instritute of ABC";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdOfferedYear;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.ComboBox cmdTuteHours;
        private System.Windows.Forms.ComboBox cmdLabHours;
        private System.Windows.Forms.ComboBox cmdEvaluHours;
        private System.Windows.Forms.ComboBox cmdLecHours;
        private System.Windows.Forms.ComboBox cmdOfferedSem;
        private System.Windows.Forms.Label label8;
        public FontAwesome.Sharp.IconButton btnSave;
        public FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.ComboBox cmdSelectLecturer;
        private System.Windows.Forms.Label label9;
    }
}