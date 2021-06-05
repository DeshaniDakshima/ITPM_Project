using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDaysAndHours
{
    class WorkingTime
    {

        public String EntryID { get; set; }

        public String Hours { get; set; }

        public String Minutes { get; set; }

        string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * from WorkingTime";
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
        public bool Insert(WorkingTime c)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                string sql = "INSERT INTO WorkingTime(Hours,Minutes) VALUES(@Hours,@Minutes)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Hours", c.Hours);
                cmd.Parameters.AddWithValue("@Minutes", c.Minutes);


                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        public String Update(WorkingTime c, int id)
        {
            String isSuccess = "false";
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                String sql = "UPDATE WorkingTime SET Hours=@Hours,Minutes=@Minutes WHERE EntryID=@EntryID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Hours", c.Hours);
                cmd.Parameters.AddWithValue("@Minutes", c.Minutes);
                cmd.Parameters.AddWithValue("@EntryID", id);

                cmd.ExecuteNonQuery();
                isSuccess = "true";

            }
            catch (Exception ex)
            {
                isSuccess = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Delete(WorkingTime c, int id)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM WorkingTime WHERE EntryID=@EntryID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EntryID", id);

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
