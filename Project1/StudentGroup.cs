using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
    class StudentGroup
    {
        public int ID { get; set; }
        public String academicYearSemister { get; set; }
        public String program { get; set; }
        public int groupNumber { get; set; }
        public int subGroupNumber { get; set; }
        public String groupID { get; set; }
        public String subGroupID { get; set; }

        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public String Insert(StudentGroup s)
        {
            String st = "Erorr";
            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();

            try
            {

                String sql = "INSERT INTO StudentGroup(AcademicYearSem, Program, GroupNumber, SubGroupNumber, GroupID, SubGroupID) VALUES (@AcademicYearSemister, @Program, @GroupNumber, @SubGroupNumber, @GroupID, @SubGroupID);";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@AcademicYearSemister", s.academicYearSemister);
                cmd.Parameters.AddWithValue("@Program", s.program);
                cmd.Parameters.AddWithValue("@GroupNumber", s.groupNumber);
                cmd.Parameters.AddWithValue("@SubGroupNumber", s.subGroupNumber);
                cmd.Parameters.AddWithValue("@GroupID", s.groupID);
                cmd.Parameters.AddWithValue("@SubGroupID", s.subGroupID);

                cmd.ExecuteNonQuery();

                st = "Success Insert";
            }
            catch (Exception ex)
            {
                st = ex.Message;

            }
            finally
            {
                conn.Close();
            }

            return st;
        }

        public String Update(StudentGroup s, int id)
        {
            String st = "Erorr";
            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();

            try
            {

                String sql = "UPDATE StudentGroup SET AcademicYearSem=@AcademicYearSemister, Program=@Program, GroupNumber=@GroupNumber, SubGroupNumber=@SubGroupNumber, GroupID=@GroupID, SubGroupID=@SubGroupID WHERE ID=@id;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@AcademicYearSemister", s.academicYearSemister);
                cmd.Parameters.AddWithValue("@Program", s.program);
                cmd.Parameters.AddWithValue("@GroupNumber", s.groupNumber);
                cmd.Parameters.AddWithValue("@SubGroupNumber", s.subGroupNumber);
                cmd.Parameters.AddWithValue("@GroupID", s.groupID);
                cmd.Parameters.AddWithValue("@SubGroupID", s.subGroupID);

                cmd.ExecuteNonQuery();

                st = "Success Update";
            }
            catch (Exception ex)
            {
                st = ex.Message;

            }
            finally
            {
                conn.Close();
            }

            return st;
        }



    }
}
