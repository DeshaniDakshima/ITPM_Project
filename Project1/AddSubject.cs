using ITPM_Project.SubjectClasses;
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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
            OfferedLecturerCombo();

        }

        
        bool isEmpty = false;
        SubjectClass s = new SubjectClass();
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
                if(lecture.Count>0)
                {
                    lecture.Clear();
                }
                

                while (OfferedLecturerRead.Read())
                {
                    string ID = OfferedLecturerRead["Title"] +". "+OfferedLecturerRead["FirstName"]+" "+ OfferedLecturerRead["LastName"];
                    lecture.Add(ID, Convert.ToInt32( OfferedLecturerRead["ID"]));
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

        private void lecturerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Clear()
        {
            cmdOfferedYear.SelectedIndex = -1;
            cmdOfferedSem.SelectedIndex = -1;
            txtSubName.Clear();
            txtSubCode.Clear(); 
            cmdLecHours.SelectedIndex = -1;
            cmdTuteHours.SelectedIndex = -1;
            cmdLabHours.SelectedIndex = -1;
            cmdEvaluHours.SelectedIndex = -1;
            cmdSelectLecturer.SelectedIndex = -1;
            
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cmdOfferedYear.Text != "" && cmdOfferedSem.Text != "" && txtSubName.Text != "" && txtSubCode.Text != "" && cmdLecHours.Text != "" && cmdTuteHours.Text != "" && cmdLabHours.Text != "" && cmdEvaluHours.Text != "" && cmdSelectLecturer.Text != "")
            {
                s.OfferedYear = cmdOfferedYear.Text;
                s.OfferedSemester = cmdOfferedSem.Text;
                s.SubjectName = txtSubName.Text;
                s.SubjectCode = txtSubCode.Text;
                s.LectureHours = int.Parse(cmdLecHours.Text);
                s.TutorialHours = int.Parse(cmdTuteHours.Text);
                s.LabHours = int.Parse(cmdLabHours.Text);
                s.EvaluationHours = int.Parse(cmdEvaluHours.Text);
                s.OfferedLecturer = lecture[cmdSelectLecturer.Text];
                isEmpty = false;
            }
            else
            {
                MessageBox.Show("Please Insert Empty Value", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isEmpty = true;
            }

            if (!isEmpty)
            {

                if (s.Insert(s))
                {
                    MessageBox.Show("New Subject Successfully Inserted!");
                    Clear();

                }
                else
                {
                    MessageBox.Show("Faild to Add New Subject. Try Again!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSession s = new AddSession();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSession s = new ManageSession();
            s.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
