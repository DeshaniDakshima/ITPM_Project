
namespace ITPM_Project
{
    partial class ManageLecturer
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
            this.txtFnameBoxML = new System.Windows.Forms.TextBox();
            this.txtTitleBoxML = new System.Windows.Forms.ComboBox();
            this.txtLevelBoxML = new System.Windows.Forms.ComboBox();
            this.txtBuildingBoxML = new System.Windows.Forms.ComboBox();
            this.txtCenterBoxML = new System.Windows.Forms.ComboBox();
            this.txtDepBoxML = new System.Windows.Forms.ComboBox();
            this.txtFacultyBoxML = new System.Windows.Forms.ComboBox();
            this.txtRankBoxML = new System.Windows.Forms.TextBox();
            this.txtLecturerIDBoxML = new System.Windows.Forms.TextBox();
            this.txtLnameBoxML = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.manageLectureTopic = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.lecGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtSearchBoxML = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFnameBoxML
            // 
            this.txtFnameBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFnameBoxML.Location = new System.Drawing.Point(169, 150);
            this.txtFnameBoxML.Name = "txtFnameBoxML";
            this.txtFnameBoxML.Size = new System.Drawing.Size(189, 26);
            this.txtFnameBoxML.TabIndex = 38;
            // 
            // txtTitleBoxML
            // 
            this.txtTitleBoxML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTitleBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleBoxML.FormattingEnabled = true;
            this.txtTitleBoxML.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Mrs ",
            "Miss"});
            this.txtTitleBoxML.Location = new System.Drawing.Point(169, 95);
            this.txtTitleBoxML.Name = "txtTitleBoxML";
            this.txtTitleBoxML.Size = new System.Drawing.Size(189, 27);
            this.txtTitleBoxML.TabIndex = 37;
            // 
            // txtLevelBoxML
            // 
            this.txtLevelBoxML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLevelBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevelBoxML.FormattingEnabled = true;
            this.txtLevelBoxML.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer"});
            this.txtLevelBoxML.Location = new System.Drawing.Point(537, 276);
            this.txtLevelBoxML.Name = "txtLevelBoxML";
            this.txtLevelBoxML.Size = new System.Drawing.Size(189, 27);
            this.txtLevelBoxML.TabIndex = 32;
            // 
            // txtBuildingBoxML
            // 
            this.txtBuildingBoxML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBuildingBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingBoxML.FormattingEnabled = true;
            this.txtBuildingBoxML.Items.AddRange(new object[] {
            "Main Building",
            "New Building",
            "Engineering Building",
            "Business Building"});
            this.txtBuildingBoxML.Location = new System.Drawing.Point(537, 210);
            this.txtBuildingBoxML.Name = "txtBuildingBoxML";
            this.txtBuildingBoxML.Size = new System.Drawing.Size(189, 27);
            this.txtBuildingBoxML.TabIndex = 31;
            // 
            // txtCenterBoxML
            // 
            this.txtCenterBoxML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCenterBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenterBoxML.FormattingEnabled = true;
            this.txtCenterBoxML.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Mathara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.txtCenterBoxML.Location = new System.Drawing.Point(537, 149);
            this.txtCenterBoxML.Name = "txtCenterBoxML";
            this.txtCenterBoxML.Size = new System.Drawing.Size(189, 27);
            this.txtCenterBoxML.TabIndex = 30;
            // 
            // txtDepBoxML
            // 
            this.txtDepBoxML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDepBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepBoxML.FormattingEnabled = true;
            this.txtDepBoxML.Items.AddRange(new object[] {
            "IT",
            "SE",
            "DS",
            "IM",
            "CS",
            "ISE",
            "CSSE",
            "BA",
            "BM",
            "HCM",
            "MU",
            "CE",
            "EEE"});
            this.txtDepBoxML.Location = new System.Drawing.Point(169, 334);
            this.txtDepBoxML.Name = "txtDepBoxML";
            this.txtDepBoxML.Size = new System.Drawing.Size(189, 27);
            this.txtDepBoxML.TabIndex = 29;
            // 
            // txtFacultyBoxML
            // 
            this.txtFacultyBoxML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFacultyBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyBoxML.FormattingEnabled = true;
            this.txtFacultyBoxML.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Science"});
            this.txtFacultyBoxML.Location = new System.Drawing.Point(169, 273);
            this.txtFacultyBoxML.Name = "txtFacultyBoxML";
            this.txtFacultyBoxML.Size = new System.Drawing.Size(189, 27);
            this.txtFacultyBoxML.TabIndex = 28;
            // 
            // txtRankBoxML
            // 
            this.txtRankBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRankBoxML.Location = new System.Drawing.Point(537, 334);
            this.txtRankBoxML.Name = "txtRankBoxML";
            this.txtRankBoxML.ReadOnly = true;
            this.txtRankBoxML.Size = new System.Drawing.Size(189, 26);
            this.txtRankBoxML.TabIndex = 27;
            // 
            // txtLecturerIDBoxML
            // 
            this.txtLecturerIDBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturerIDBoxML.Location = new System.Drawing.Point(537, 95);
            this.txtLecturerIDBoxML.MaxLength = 6;
            this.txtLecturerIDBoxML.Name = "txtLecturerIDBoxML";
            this.txtLecturerIDBoxML.Size = new System.Drawing.Size(189, 26);
            this.txtLecturerIDBoxML.TabIndex = 26;
            this.txtLecturerIDBoxML.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLecturerIDBoxML_KeyPress);
            // 
            // txtLnameBoxML
            // 
            this.txtLnameBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnameBoxML.Location = new System.Drawing.Point(169, 211);
            this.txtLnameBoxML.Name = "txtLnameBoxML";
            this.txtLnameBoxML.Size = new System.Drawing.Size(189, 26);
            this.txtLnameBoxML.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 19);
            this.label15.TabIndex = 41;
            this.label15.Text = "Title";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(414, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 19);
            this.label14.TabIndex = 42;
            this.label14.Text = "Lecturer ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(45, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 19);
            this.label16.TabIndex = 43;
            this.label16.Text = "Faculty";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(45, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 19);
            this.label17.TabIndex = 44;
            this.label17.Text = "Last Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(414, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 19);
            this.label18.TabIndex = 45;
            this.label18.Text = "Center";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 337);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 19);
            this.label19.TabIndex = 46;
            this.label19.Text = "Department";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 19);
            this.label20.TabIndex = 47;
            this.label20.Text = "First Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(414, 337);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 19);
            this.label21.TabIndex = 48;
            this.label21.Text = "Rank";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(414, 275);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 19);
            this.label22.TabIndex = 49;
            this.label22.Text = "Level";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(414, 214);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 19);
            this.label23.TabIndex = 50;
            this.label23.Text = "Building";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.manageLectureTopic);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.lecGridView);
            this.groupBox2.Controls.Add(this.checkBox14);
            this.groupBox2.Controls.Add(this.checkBox13);
            this.groupBox2.Controls.Add(this.checkBox12);
            this.groupBox2.Controls.Add(this.checkBox11);
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtSearchBoxML);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtTitleBoxML);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtLnameBoxML);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtLecturerIDBoxML);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtRankBoxML);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtFacultyBoxML);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtDepBoxML);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCenterBoxML);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtBuildingBoxML);
            this.groupBox2.Controls.Add(this.txtLevelBoxML);
            this.groupBox2.Controls.Add(this.txtFnameBoxML);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1326, 749);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // manageLectureTopic
            // 
            this.manageLectureTopic.AutoSize = true;
            this.manageLectureTopic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLectureTopic.Location = new System.Drawing.Point(521, 25);
            this.manageLectureTopic.Name = "manageLectureTopic";
            this.manageLectureTopic.Size = new System.Drawing.Size(175, 25);
            this.manageLectureTopic.TabIndex = 82;
            this.manageLectureTopic.Text = "Manage Lecturer";
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
            this.btnDelete.Location = new System.Drawing.Point(1109, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 56);
            this.btnDelete.TabIndex = 81;
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
            this.btnUpdate.Location = new System.Drawing.Point(1109, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 56);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
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
            this.btnClear.Location = new System.Drawing.Point(1109, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 56);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lecGridView
            // 
            this.lecGridView.AllowUserToAddRows = false;
            this.lecGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lecGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lecGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lecGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lecGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lecGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.lecGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lecGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lecGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecGridView.DoubleBuffered = true;
            this.lecGridView.EnableHeadersVisualStyles = false;
            this.lecGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.lecGridView.HeaderForeColor = System.Drawing.Color.White;
            this.lecGridView.Location = new System.Drawing.Point(22, 494);
            this.lecGridView.Name = "lecGridView";
            this.lecGridView.ReadOnly = true;
            this.lecGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.lecGridView.RowHeadersVisible = false;
            this.lecGridView.RowHeadersWidth = 51;
            this.lecGridView.RowTemplate.Height = 24;
            this.lecGridView.RowTemplate.ReadOnly = true;
            this.lecGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lecGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lecGridView.Size = new System.Drawing.Size(1288, 233);
            this.lecGridView.TabIndex = 70;
            this.lecGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // checkBox14
            // 
            this.checkBox14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(903, 334);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(138, 23);
            this.checkBox14.TabIndex = 61;
            this.checkBox14.Text = "16.30-17.30";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(903, 305);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(138, 23);
            this.checkBox13.TabIndex = 62;
            this.checkBox13.Text = "15.30-16.30";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(903, 276);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(130, 23);
            this.checkBox12.TabIndex = 63;
            this.checkBox12.Text = "14.30-15.30";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(903, 247);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(138, 23);
            this.checkBox11.TabIndex = 64;
            this.checkBox11.Text = "13.30-14.30";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(903, 215);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(130, 23);
            this.checkBox10.TabIndex = 65;
            this.checkBox10.Text = "12.30-13.30";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(903, 185);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(130, 23);
            this.checkBox9.TabIndex = 66;
            this.checkBox9.Text = "11.30-12.30";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(903, 156);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(130, 23);
            this.checkBox8.TabIndex = 67;
            this.checkBox8.Text = "10.30-11.30";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(903, 127);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(130, 23);
            this.checkBox7.TabIndex = 68;
            this.checkBox7.Text = "9.30-10.30";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(903, 99);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(130, 23);
            this.checkBox6.TabIndex = 69;
            this.checkBox6.Text = "8.30-930";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(779, 393);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(108, 37);
            this.checkBox5.TabIndex = 56;
            this.checkBox5.Text = "Friday";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(633, 393);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(121, 37);
            this.checkBox4.TabIndex = 57;
            this.checkBox4.Text = "Thurseday";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(478, 393);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(127, 37);
            this.checkBox3.TabIndex = 58;
            this.checkBox3.Text = "Wednesday";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(328, 393);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 37);
            this.checkBox2.TabIndex = 59;
            this.checkBox2.Text = "Tuesday";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(183, 392);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 38);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "Monday";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSearchBoxML
            // 
            this.txtSearchBoxML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBoxML.Location = new System.Drawing.Point(233, 448);
            this.txtSearchBoxML.Name = "txtSearchBoxML";
            this.txtSearchBoxML.Size = new System.Drawing.Size(493, 26);
            this.txtSearchBoxML.TabIndex = 54;
            this.txtSearchBoxML.TextChanged += new System.EventHandler(this.txtSearchBoxML_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(45, 451);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 19);
            this.label26.TabIndex = 53;
            this.label26.Text = "Search Lecturer";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(45, 398);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 19);
            this.label25.TabIndex = 52;
            this.label25.Text = "Active Days";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(775, 98);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 19);
            this.label24.TabIndex = 51;
            this.label24.Text = "Active Time";
            // 
            // ManageLecturer
            // 
            this.ClientSize = new System.Drawing.Size(1326, 749);
            this.Controls.Add(this.groupBox2);
            this.Name = "ManageLecturer";
            this.Text = "Instritute of ABC";
            this.Load += new System.EventHandler(this.ManageLecturer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView LecturerGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtFnameBoxML;
        private System.Windows.Forms.ComboBox txtTitleBoxML;
        private System.Windows.Forms.ComboBox txtLevelBoxML;
        private System.Windows.Forms.ComboBox txtBuildingBoxML;
        private System.Windows.Forms.ComboBox txtCenterBoxML;
        private System.Windows.Forms.ComboBox txtDepBoxML;
        private System.Windows.Forms.ComboBox txtFacultyBoxML;
        private System.Windows.Forms.TextBox txtRankBoxML;
        private System.Windows.Forms.TextBox txtLecturerIDBoxML;
        private System.Windows.Forms.TextBox txtLnameBoxML;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSearchBoxML;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid lecGridView;
        public FontAwesome.Sharp.IconButton btnDelete;
        public FontAwesome.Sharp.IconButton btnUpdate;
        public FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.Label manageLectureTopic;
    }
}