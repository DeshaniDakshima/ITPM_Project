using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDaysAndHours
{
    class NoOfWorkingDays
    {

        public String EntryID { get; set; }
        
        public String Number_Of_Working_Days { get; set; }

        string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * from NoWorkingDays";
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
        public bool Insert(NoOfWorkingDays c)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                string sql = "INSERT INTO NoWorkingDays(Number_Of_Working_Days) VALUES(@Number_Of_Working_Days)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Number_Of_Working_Days", c.Number_Of_Working_Days);
                

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
        public String Update(NoOfWorkingDays c , int id)
        {
            String isSuccess = "false";
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                String sql = "UPDATE NoWorkingDays SET Number_Of_Working_days=@Number_Of_Working_Days WHERE EntryID=@EntryID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Number_Of_Working_Days", c.Number_Of_Working_Days);
                cmd.Parameters.AddWithValue("@EntryID", id);

                cmd.ExecuteNonQuery();
                isSuccess ="true";

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
        public bool Delete(NoOfWorkingDays c ,int id)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM NoWorkingDays WHERE EntryID=@EntryID";
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
