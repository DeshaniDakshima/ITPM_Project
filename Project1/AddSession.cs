using ITPM_Project.SessionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ITPM_Project
{
    public partial class AddSession : Form
    {
        public AddSession()
        {
            InitializeComponent();
            LecturerCombo();
            SubjectCombo();
            StudentSubGroupCombo();
            StudentGroupCombo();
        }

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

                    cmdLecturer1.Items.Add(Title + " " + FirstName + " " + LastName);
                    cmdLecturer2.Items.Add(Title + " " + FirstName + " " + LastName);

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
                   
                    cmdSubject.Items.Add(SubjectName + " ( " + SubjectCode + " ) ");

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
                    cmdGroup.Items.Add(GroupID);    
                    
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

                    cmdSubGroup.Items.Add(SubGroupID);

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


        //clear method
        public void Clear()
        {
            cmdLecturer1.SelectedIndex = -1;
            cmdLecturer2.SelectedIndex = -1;
            cmdGroup.SelectedIndex = -1;           
            cmdSubject.SelectedIndex = -1;
            cmdTag.SelectedIndex = -1;
            cmdSubGroup.SelectedIndex = -1;
            txtNoOfStudent.Clear();
            cmdDuration.SelectedIndex = -1;

        }

        //Add button
        private void btnSave_Click(object sender, EventArgs e)
        {
                //........................Validation..........................
               
                if (cmdLecturer1.Text == "")
                    MessageBox.Show("Please Select Lecturer!");
                
                else if (cmdGroup.Text == "")
                    MessageBox.Show("Please Select Group!");
              
                else if (cmdSubject.Text == "")
                    MessageBox.Show("Please Select Subject!");
                
                else if (cmdTag.Text == "")
                    MessageBox.Show("Please Select Sub Tag!");
                
                else if (cmdSubGroup.Text == "")
                    MessageBox.Show("Please Select Sub Group!");
                
                else if (txtNoOfStudent.Text == "")
                    MessageBox.Show("Please Insert Number of Student!");
                
                else if (cmdDuration.Text == "")
                    MessageBox.Show("Please Select Time Duration!");

                else if (System.Text.RegularExpressions.Regex.IsMatch(txtNoOfStudent.Text, "[^0-9]"))
                    MessageBox.Show("Please Enter Number Only For No Of Students!");

                else
                {

                    //get the value from the inpute fileds
                   
                    s.LecturerName1 = cmdLecturer1.Text;
                    s.LecturerName2 = cmdLecturer2.Text;
                    s.StudentGroup = cmdGroup.Text;
                    s.Subject = cmdSubject.Text;
                    s.Tag = cmdTag.Text;
                    s.StudentSubGroup = cmdSubGroup.Text;
                    s.NoOfStudent = int.Parse(txtNoOfStudent.Text);
                    s.Duration = cmdDuration.Text;

                    //Insert data into data using the method we created
                    bool success = s.Insert(s);
                    if (success == true)
                    {
                        MessageBox.Show("New Session Successfully Inserted!");
                        Clear();
                }
                    else
                    {
                       
                        MessageBox.Show("Failed to Add new Session...Try Again!");
                    }
                }
            }
       

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmdLecturer1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSession_Load(object sender, EventArgs e)
        {

        }
    }
}
