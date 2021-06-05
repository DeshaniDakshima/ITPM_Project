using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDaysAndHours
{
    class WorkingDay
    {

        public String EntryID { get; set; }

        public String Days { get; set; }
        


        string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * from WorkingDay";
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
        public String Insert(WorkingDay c)
        {
            String isSucces = "false";
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                string sql = "INSERT INTO WorkingDay(Days) VALUES(@Days)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Days", c.Days);


                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = "true";
                }
                else
                {
                    isSucces = "false";
                }

            }
            catch (Exception ex)
            {
                isSucces = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        public String Update(WorkingDay c,  int id)
        {
            String isSuccess = "false";
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE WorkingDay SET Days=@Days WHERE EntryID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Days", c.Days);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
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
        public bool Delete(WorkingDay c , int id)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM WorkingDay WHERE EntryID=@EntryID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EntryID", id);


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
    }
}
      
