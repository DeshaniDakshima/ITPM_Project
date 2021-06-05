using ITPM_Project.SubjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_Project
{
    public partial class ManageSubject : Form
    {
        public ManageSubject()
        {
            InitializeComponent();
            OfferedLecturerCombo();
        }

        int id;
        SubjectClass s = new SubjectClass();
        bool isEmpty = false;

        Dictionary<String, int> lecture = new Dictionary<string, int>();

        static string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        void OfferedLecturerCombo()
        {
            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            string sql = "select ID, Title, FirstName, LastName from Lecturer_Table ";
            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataReader OfferedLecturerRead;

            try
            {

                conn.Open();
                OfferedLecturerRead = cmd.ExecuteReader();
                if (lecture.Count > 0)
                {
                    lecture.Clear();
                }


                while (OfferedLecturerRead.Read())
                {
                    string ID = OfferedLecturerRead["Title"] + ". " + OfferedLecturerRead["FirstName"] + " " + OfferedLecturerRead["LastName"];
                    lecture.Add(ID, Convert.ToInt32(OfferedLecturerRead["ID"]));
                    cmdSelectLecturer.Items.Add(ID);
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
            cmdOfferedYearMS.SelectedIndex = -1;
            cmdOfferedSemMS.SelectedIndex = -1;
            txtSubNameMS.Clear();
            txtSubCodeMS.Clear();
            cmdLecHoursMS.SelectedIndex = -1;
            cmdTuteHoursMS.SelectedIndex = -1;
            cmdLabHoursMS.SelectedIndex = -1;
            cmdEvaluHoursMS.SelectedIndex = -1;
            cmdSelectLecturer.SelectedIndex = -1;
            txtSearchMS.Clear();
        }


        //View subject details in DataGridView
        private void ManageSubject_Load(object sender, EventArgs e)
        {
            DataTable dt = s.Select();
            SubGridView.DataSource = dt;
            id = 0;
        }

        private void SubGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id = Int16.Parse(SubGridView.Rows[rowIndex].Cells[0].Value.ToString());
            cmdOfferedYearMS.Text = SubGridView.Rows[rowIndex].Cells[1].Value.ToString();
            cmdOfferedSemMS.Text = SubGridView.Rows[rowIndex].Cells[2].Value.ToString();
            txtSubNameMS.Text = SubGridView.Rows[rowIndex].Cells[3].Value.ToString();
            txtSubCodeMS.Text = SubGridView.Rows[rowIndex].Cells[4].Value.ToString();
            cmdLecHoursMS.Text = SubGridView.Rows[rowIndex].Cells[5].Value.ToString();
            cmdTuteHoursMS.Text = SubGridView.Rows[rowIndex].Cells[6].Value.ToString();
            cmdLabHoursMS.Text = SubGridView.Rows[rowIndex].Cells[7].Value.ToString();
            cmdEvaluHoursMS.Text = SubGridView.Rows[rowIndex].Cells[8].Value.ToString();
            cmdSelectLecturer.Text = SubGridView.Rows[rowIndex].Cells[9].Value.ToString();
        }

        

        private void btnClearMS_Click(object sender, EventArgs e)
        {
            Clear();
        }


       
        private void txtSearchMS_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchMS.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Subject_Table WHERE SubjectName LIKE '%" + keyword + "%' OR SubjectCode LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SubGridView.DataSource = dt;
        }


        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmdOfferedYearMS.Text != "" && cmdOfferedSemMS.Text != "" && txtSubNameMS.Text != "" && txtSubCodeMS.Text != "" && cmdLecHoursMS.Text != "" && cmdTuteHoursMS.Text != "" && cmdLabHoursMS.Text != "" && cmdEvaluHoursMS.Text != "" && cmdSelectLecturer.Text != "")
            {
                s.OfferedYear = cmdOfferedYearMS.Text;
                s.OfferedSemester = cmdOfferedSemMS.Text;
                s.SubjectName = txtSubNameMS.Text;
                s.SubjectCode = txtSubCodeMS.Text;
                s.LectureHours = int.Parse(cmdLecHoursMS.Text);
                s.TutorialHours = int.Parse(cmdTuteHoursMS.Text);
                s.LabHours = int.Parse(cmdLabHoursMS.Text);
                s.EvaluationHours = int.Parse(cmdEvaluHoursMS.Text);
                s.OfferedLecturer = lecture[cmdSelectLecturer.Text];
                isEmpty = false;
            }
            else
            {
                MessageBox.Show("Please Select Relavent Row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isEmpty = true;

            }

            if (!isEmpty)
            {

                if (s.Update(s, id))
                {
                    MessageBox.Show("Subject has been Successfully Updated!");
                    DataTable dt = s.Select();
                    SubGridView.DataSource = dt;
                    Clear();

                }
                else
                {
                    MessageBox.Show("Failed to Update Subject. Try Again!");
                    Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmdOfferedYearMS.Text != "" && cmdOfferedSemMS.Text != "" && txtSubNameMS.Text != "" && txtSubCodeMS.Text != "" && cmdLecHoursMS.Text != "" && cmdTuteHoursMS.Text != "" && cmdLabHoursMS.Text != "" && cmdEvaluHoursMS.Text != "")
            {
                s.SubjectID = Convert.ToInt32(id);
                bool success = s.Delete(s, id);

                if (success == true)
                {
                    MessageBox.Show("Subject Successfully Deleted!");

                    DataTable dt = s.Select();
                    SubGridView.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Delete Subject. Try Again!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Relavent Row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SubGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void SubGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
