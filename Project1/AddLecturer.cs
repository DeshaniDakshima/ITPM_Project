using ITPM_Project.LecturerClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ITPM_Project
{
    public partial class AddLecturer : Form
    {
        public AddLecturer()
        {
            InitializeComponent();
        }

        LecturerClass l = new LecturerClass();
        bool isEmpty = false;

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        ArrayList arrDays = new ArrayList();
        ArrayList arrTimes = new ArrayList();


        public void Clear()
        {
            txtTitleBox.SelectedIndex = -1;
            txtFnameBox.Clear();
            txtLnameBox.Clear();
            txtFacultyBox.SelectedIndex = -1;
            txtDepBox.SelectedIndex = -1;
            txtLecturerIDBox.Clear();
            txtCenterBox.SelectedIndex = -1;
            txtBuildingBox.SelectedIndex = -1;
            txtLevelBox.SelectedIndex = -1;
            txtRankBox.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
        }

        //Generate Rank using Rankmap 
        public void rankMap()
        {
            Dictionary<String,int> rankMap = new Dictionary<String,int>();

            rankMap.Add("Professor", 1);
            rankMap.Add("Assistant Professor", 2);
            rankMap.Add("Senior Lecturer(HG)", 3);
            rankMap.Add("Senior Lecturer", 4);
            rankMap.Add("Lecturer", 5);
            rankMap.Add("Assistant Lecturer", 6);


            if (txtLecturerIDBox.Text != "" && txtLevelBox.Text != "")
            {
                int value = rankMap[txtLevelBox.Text];

                StringBuilder sb = new StringBuilder();
                sb.Append(value + "." + txtLecturerIDBox.Text);

                txtRankBox.Text = sb.ToString();
            }
        }


        //User can insert number only to LectureID
        public void numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Insert Only Number!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtLecturerIDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberonly(sender, e);
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                arrDays.Add("Monday");
            if (checkBox2.Checked)
                arrDays.Add("Tuesday");
            if (checkBox3.Checked)
                arrDays.Add("Wednesday");
            if (checkBox4.Checked)
                arrDays.Add("Thursday");
            if (checkBox5.Checked)
                arrDays.Add("Friday");
            if (checkBox6.Checked)
                arrTimes.Add("8.30-9.30");
            if (checkBox7.Checked)
                arrTimes.Add("9.30-10.30");
            if (checkBox8.Checked)
                arrTimes.Add("10.30-11.30");
            if (checkBox9.Checked)
                arrTimes.Add("11.30-12.30");
            if (checkBox10.Checked)
                arrTimes.Add("12.30-13.30");
            if (checkBox11.Checked)
                arrTimes.Add("13.30-14.30");
            if (checkBox12.Checked)
                arrTimes.Add("14.30-15.30");
            if (checkBox13.Checked)
                arrTimes.Add("15.30-16.30");
            if (checkBox14.Checked)
                arrTimes.Add("16.30-17.30");

            String[] Arr1 = (String[])arrDays.ToArray(typeof(String));
            String days = string.Join(",", Arr1);


            String[] Arr2 = (String[])arrTimes.ToArray(typeof(String));
            String times = string.Join(",", Arr2);

            //Check Feilds are empty or not
            if (txtTitleBox.Text != "" && txtFnameBox.Text != "" && txtLnameBox.Text != "" && txtFacultyBox.Text != "" && txtDepBox.Text != "" && txtLecturerIDBox.Text != "" && txtCenterBox.Text != "" && txtBuildingBox.Text != "" && txtLevelBox.Text != "" && txtRankBox.Text != "")
            {
                l.Title = txtTitleBox.Text;
                l.FirstName = txtFnameBox.Text;
                l.LastName = txtLnameBox.Text;
                l.Faculty = txtFacultyBox.Text;
                l.Department = txtDepBox.Text;
                l.LecturerID = int.Parse(txtLecturerIDBox.Text);
                l.Center = txtCenterBox.Text;
                l.Building = txtBuildingBox.Text;
                l.LecturerLevel = txtLevelBox.Text;
                l.Rank = txtRankBox.Text;
                l.ActiveDays = days;
                l.ActiveTimes = times;
                isEmpty = false;

            }
            else
            {
                MessageBox.Show("Please Insert Empty Value", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isEmpty = true;

            }

            //If empty then not insert into DB

            if (!isEmpty)
            {

                if (l.Insert(l))
                {
                    MessageBox.Show("New Lecturer Successfully Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Faild to Add New Lecturer. Try Again!");
                    Clear();
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRank_Click_1(object sender, EventArgs e)
        {
            rankMap();
        }

        private void AddLecturer_Load(object sender, EventArgs e)
        {

        }
    }

    
}
