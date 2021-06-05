using ITPM_Project.SessionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_Project
{
    public partial class ManageSession : Form
    {
        public ManageSession()
        {
            InitializeComponent();
            LecturerCombo();
            SubjectCombo();
            StudentGroupCombo();
            StudentSubGroupCombo();
        }

        int id;
        SessionClass s = new SessionClass();
        
        static string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Loading lecturer name into the combo box
        void LecturerCombo()
        {


            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            string sql = "select * from Lecturer_Table";
            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataReader LecturerRead;

            try
            {
                conn.Open();
                LecturerRead = cmd.ExecuteReader();

                while (LecturerRead.Read())
                {
                    string Title = LecturerRead["Title"].ToString();
                    string FirstName = LecturerRead["FirstName"].ToString();
                    string LastName = LecturerRead["LastName"].ToString();

                    cmdLecturer1MS.Items.Add(Title + " " + FirstName + " " + LastName);
                    cmdLecturer2MS.Items.Add(Title + " " + FirstName + " " + LastName);

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        //Loading subject name into the combo box
        void SubjectCombo()
        {
            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            string sql = "select * from Subject_Table";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader SubjectRead;

            try
            {
                conn.Open();
                SubjectRead = cmd.ExecuteReader();

                while (SubjectRead.Read())
                {
                    string SubjectName = SubjectRead["SubjectName"].ToString();
                    string SubjectCode = SubjectRead["SubjectCode"].ToString();

                    cmdSubjectMS.Items.Add(SubjectName + " ( " + SubjectCode + " ) ");

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        void StudentGroupCombo()
        {
            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            string sql = "SELECT DISTINCT GroupID from StudentGroup";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader StudentRead;

            try
            {
                conn.Open();
                StudentRead = cmd.ExecuteReader();

                while (StudentRead.Read())
                {
                    string GroupID = StudentRead["GroupID"].ToString();
                    
                    cmdGroupMS.Items.Add(GroupID);
    
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        void StudentSubGroupCombo()
        {
            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            string sql = "SELECT SubGroupID from StudentGroup ";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader StudentRead;

            try
            {
                conn.Open();
                StudentRead = cmd.ExecuteReader();

                while (StudentRead.Read())
                {

                    string SubGroupID = StudentRead["SubGroupID"].ToString();

                    cmdSubGroupMS.Items.Add(SubGroupID);

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void Clear()
        {
            cmdLecturer1MS.SelectedIndex = -1;
            cmdLecturer2MS.SelectedIndex = -1;
            cmdGroupMS.SelectedIndex = -1;
            cmdSubjectMS.SelectedIndex = -1;
            cmdTagMS.SelectedIndex = -1;
            cmdSubGroupMS.SelectedIndex = -1;
            textNoOfStudentMS.Clear();
            cmdDurationMS.SelectedIndex = -1;
            txtSearchMS.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //View session details in DataGridView

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DataTable dt = s.Select();
            SessionGridView.DataSource = dt;
        }

        private void SessionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id = Int16.Parse(SessionGridView.Rows[rowIndex].Cells[0].Value.ToString());
            cmdLecturer1MS.Text = SessionGridView.Rows[rowIndex].Cells[1].Value.ToString();
            cmdLecturer2MS.SelectedItem = SessionGridView.Rows[rowIndex].Cells[2].Value.ToString();
            cmdGroupMS.Text = SessionGridView.Rows[rowIndex].Cells[3].Value.ToString();
            cmdSubjectMS.SelectedItem = SessionGridView.Rows[rowIndex].Cells[4].Value.ToString();
            cmdTagMS.Text = SessionGridView.Rows[rowIndex].Cells[5].Value.ToString();
            cmdSubGroupMS.Text = SessionGridView.Rows[rowIndex].Cells[6].Value.ToString();
            textNoOfStudentMS.Text = SessionGridView.Rows[rowIndex].Cells[7].Value.ToString();
            cmdDurationMS.Text = SessionGridView.Rows[rowIndex].Cells[8].Value.ToString();
        }


        //Update button

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if(cmdLecturer1MS.Text == "" && cmdLecturer2MS.Text == "" && cmdGroupMS.Text == "" && cmdSubjectMS.Text == "" && cmdTagMS.Text == "" && cmdSubGroupMS.Text == "" && textNoOfStudentMS.Text == "" && cmdDurationMS.Text == "")
            {
                MessageBox.Show("Please Select Relavent Row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (cmdLecturer1MS.Text == "")              
                MessageBox.Show("Please Select Lecturer!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdGroupMS.Text == "")
                MessageBox.Show("Please Select Group!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdSubjectMS.Text == "")
                MessageBox.Show("Please Select Subject!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdTagMS.Text == "")
                MessageBox.Show("Please Select Tag!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdSubGroupMS.Text == "")
                MessageBox.Show("Please Select Sub Group!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (textNoOfStudentMS.Text == "")
                MessageBox.Show("Please Insert Number of Student!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdDurationMS.Text == "")
                MessageBox.Show("Please Select Time Duration!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (System.Text.RegularExpressions.Regex.IsMatch(textNoOfStudentMS.Text, "[^0-9]"))
                MessageBox.Show("Please Enter Number Only For No Of Students!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {

                //get the value from the inpute fileds

                s.LecturerName1 = cmdLecturer1MS.Text;
                s.LecturerName2 = cmdLecturer2MS.Text;
                s.StudentGroup = cmdGroupMS.Text;
                s.Subject = cmdSubjectMS.Text;
                s.Tag = cmdTagMS.Text;
                s.StudentSubGroup = cmdSubGroupMS.Text;
                s.NoOfStudent = int.Parse(textNoOfStudentMS.Text);
                s.Duration = cmdDurationMS.Text;

                //Insert data into data using the method we created
                bool success = s.Update(s, id);
                if (success == true)
                {
                    MessageBox.Show("Session has been Successfully Updated!");
                    DataTable dt = s.Select();
                    SessionGridView.DataSource = dt;
                    Clear();
                }
                else
                {

                    MessageBox.Show("Failed to update Session...Try Again!");
                }
            }


        }


        //Delete button

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (cmdLecturer1MS.Text == "" && cmdLecturer2MS.Text == "" && cmdGroupMS.Text == "" && cmdSubjectMS.Text == "" && cmdTagMS.Text == "" && cmdSubGroupMS.Text == "" && textNoOfStudentMS.Text == "" && cmdDurationMS.Text == "")
            {
                MessageBox.Show("Please Select Relavent Row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (cmdLecturer1MS.Text == "")
                MessageBox.Show("Please Select Lecturer!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdGroupMS.Text == "")
                MessageBox.Show("Please Select Group!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdSubjectMS.Text == "")
                MessageBox.Show("Please Select Subject!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdTagMS.Text == "")
                MessageBox.Show("Please Select Tag!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdSubGroupMS.Text == "")
                MessageBox.Show("Please Select Sub Group!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (textNoOfStudentMS.Text == "")
                MessageBox.Show("Please Insert Number of Student!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (cmdDurationMS.Text == "")
                MessageBox.Show("Please Select Time Duration!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (System.Text.RegularExpressions.Regex.IsMatch(textNoOfStudentMS.Text, "[^0-9]"))
                MessageBox.Show("Please Enter Number Only For No Of Students!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {

                //Delete data into data 
                s.SessionID = Convert.ToInt32(id);
                bool success = s.Delete(s, id);

                if (success == true)
                {
                    MessageBox.Show("Session Successfully Deleted!");

                    DataTable dt = s.Select();
                    SessionGridView.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Delete Session. Try Again!");
                }
            }
        }

                             

        private void txtSearchMS_TextChanged(object sender, EventArgs e)
        {
            
            string keyword = txtSearchMS.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Session_Table WHERE LecturerName1 LIKE '%" + keyword + "%' OR LecturerName2 LIKE '%" + keyword + "%' OR Subject LIKE '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SessionGridView.DataSource = dt;

        }

        private void SessionGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ManageSession_Load(object sender, EventArgs e)
        {
            string keyword = txtSearchMS.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Session_Table ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SessionGridView.DataSource = dt;
            SessionGridView.Columns["Status"].Visible = false;
        }
    }
}
