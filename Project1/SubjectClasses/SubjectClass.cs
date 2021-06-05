using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPM_Project.SubjectClasses
{
    class SubjectClass
    {
        public int SubjectID { get; set; }
        public string OfferedYear { get; set; }
        public string OfferedSemester { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int LectureHours { get; set; }
        public int TutorialHours { get; set; }
        public int LabHours { get; set; }
        public int EvaluationHours { get; set; }
        public int OfferedLecturer { get; set; }

        static string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Select data from DB

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            DataTable dt = new DataTable();

            try
            {
                string sql = "select s.SubjectID, s.OfferedYear, s.OfferedSemester, s.SubjectName, s.SubjectCode, s.LectureHours, s.TutorialHours, s.LabHours, s.EvaluationHours, (l.Title +'. '+ l.FirstName + ' ' +l.LastName ) AS Lecturer from Subject_Table s, Lecturer_Table l where s.OfferedLecturer = l.ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        //Insert Method
        public bool Insert(SubjectClass s)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "insert into Subject_Table( OfferedYear, OfferedSemester, SubjectName, SubjectCode, LectureHours, TutorialHours, LabHours, EvaluationHours, OfferedLecturer) " +
                    "values (@OfferedYear, @OfferedSemester, @SubjectName, @SubjectCode, @LectureHours, @TutorialHours, @LabHours, @EvaluationHours, @OfferedLecturer)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@OfferedYear", s.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemester", s.OfferedSemester);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@LectureHours", s.LectureHours);
                cmd.Parameters.AddWithValue("@TutorialHours", s.TutorialHours);
                cmd.Parameters.AddWithValue("@LabHours", s.LabHours);
                cmd.Parameters.AddWithValue("@EvaluationHours", s.EvaluationHours);
                cmd.Parameters.AddWithValue("@OfferedLecturer", s.OfferedLecturer);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Update Method

        public bool Update(SubjectClass s, int id)
        {
           
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Subject_Table SET OfferedYear = @OfferedYear, OfferedSemester = @OfferedSemester, SubjectName = @SubjectName, SubjectCode = @SubjectCode, LectureHours = @LectureHours, TutorialHours = @TutorialHours, LabHours = @LabHours, EvaluationHours = @EvaluationHours, OfferedLecturer = @OfferedLecturer WHERE SubjectID = @SubjectID";
               
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                cmd.Parameters.AddWithValue("@SubjectID", id);
                cmd.Parameters.AddWithValue("@OfferedYear", s.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemester", s.OfferedSemester);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@LectureHours", s.LectureHours);
                cmd.Parameters.AddWithValue("@TutorialHours", s.TutorialHours);
                cmd.Parameters.AddWithValue("@LabHours", s.LabHours);
                cmd.Parameters.AddWithValue("@EvaluationHours", s.EvaluationHours);
                cmd.Parameters.AddWithValue("@OfferedLecturer", s.OfferedLecturer);

                conn.Open();
                cmd.ExecuteNonQuery();

                
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
            finally
            {
                conn.Close();
            }

            
        }

        //Delete Method

        public bool Delete(SubjectClass s, int id)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM Subject_Table WHERE SubjectID = @SubjectID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SubjectID", id);

                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                cmd.ExecuteNonQuery();

                isSuccess = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

    }
}
