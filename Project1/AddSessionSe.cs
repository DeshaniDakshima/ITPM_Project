using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class AddSessionSe
    {
        public String SessionID { get; set; }
        public String Faculty { get; set; }
        public String Lecturer { get; set; }
        public String Session_Type { get; set; }
        public String Department { get; set; }
        public String Center { get; set; }
        public String Session { get; set; }


        string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * from AddSessions";
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
        public bool Insert(AddSessionSe c)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                string sql = "INSERT INTO AddSessions(Faculty, Lecturer, Session_Type, Department, Center, Session) VALUES(@Faculty, @Lecturer, @Session_Type, @Department, @Center, @Session)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Faculty", c.Faculty);
                cmd.Parameters.AddWithValue("@Lecturer", c.Lecturer);
                cmd.Parameters.AddWithValue("@Session_Type", c.Session_Type);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Center", c.Center);
                cmd.Parameters.AddWithValue("@Session", c.Session);


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
    }
}
