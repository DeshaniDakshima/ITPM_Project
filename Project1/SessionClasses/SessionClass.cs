using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPM_Project.SessionClasses
{
    class SessionClass
    {
        public int SessionID { get; set; }
        public string LecturerName1 { get; set; }
        public string LecturerName2 { get; set; }
        public string StudentGroup { get; set; }
        public string Subject { get; set; }
        public string Tag { get; set; }
        public string StudentSubGroup { get; set; }
        public int NoOfStudent { get; set; }
        public string Duration { get; set; }

        static string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        //Select data from DB

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from Session_Table";
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
        public bool Insert(SessionClass s)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "insert into Session_Table( LecturerName1, LecturerName2, StudentGroup, Subject, Tag, StudentSubGroup, NoOfStudent, Duration) " +
                    "values (@LecturerName1, @LecturerName2, @StudentGroup, @Subject, @Tag, @StudentSubGroup, @NoOfStudent, @Duration)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@LecturerName1", s.LecturerName1);
                cmd.Parameters.AddWithValue("@LecturerName2", s.LecturerName2);
                cmd.Parameters.AddWithValue("@StudentGroup", s.StudentGroup);
                cmd.Parameters.AddWithValue("@Subject", s.Subject);
                cmd.Parameters.AddWithValue("@Tag", s.Tag);
                cmd.Parameters.AddWithValue("@StudentSubGroup", s.StudentSubGroup);
                cmd.Parameters.AddWithValue("@NoOfStudent", s.NoOfStudent);
                cmd.Parameters.AddWithValue("@Duration", s.Duration);


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

        public bool Update(SessionClass s, int id)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Session_Table SET LecturerName1 = @LecturerName1, LecturerName2 = @LecturerName2, StudentGroup = @StudentGroup, Subject = @Subject, Tag = @Tag, StudentSubGroup = @StudentSubGroup, NoOfStudent = @NoOfStudent, Duration = @Duration WHERE SessionID = @SessionID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                cmd.Parameters.AddWithValue("@SessionID", id);
                cmd.Parameters.AddWithValue("@LecturerName1", s.LecturerName1);
                cmd.Parameters.AddWithValue("@LecturerName2", s.LecturerName2);
                cmd.Parameters.AddWithValue("@StudentGroup", s.StudentGroup);
                cmd.Parameters.AddWithValue("@Subject", s.Subject);
                cmd.Parameters.AddWithValue("@Tag", s.Tag);
                cmd.Parameters.AddWithValue("@StudentSubGroup", s.StudentSubGroup);
                cmd.Parameters.AddWithValue("@NoOfStudent", s.NoOfStudent);
                cmd.Parameters.AddWithValue("@Duration", s.Duration);


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

        public bool Delete(SessionClass s, int id)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM Session_Table WHERE SessionID = @SessionID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SessionID", id);

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
