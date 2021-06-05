using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPM_Project.LecturerClasses
{
    class LecturerClass
    {
        //Generate Getters & Setters
        public int ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public int LecturerID { get; set; }
        public string Center { get; set; }
        public string Building { get; set; }
        public string LecturerLevel { get; set; }
        public string ActiveDays { get; set; }
        public string ActiveTimes { get; set; }
        public string Rank { get; set; }

        static string myconnstring = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        //Select data from DB

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);  //Connect to DB
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from Lecturer_Table";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //Insert Method
        public bool Insert (LecturerClass l)
        {
           
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "insert into Lecturer_Table(Title, FirstName, LastName, Faculty, Department, LecturerID, Center, Building, LecturerLevel, Rank , ActiveDays, ActiveTimes) " +
                    "values (@Title, @FirstName, @LastName, @Faculty, @Department, @LecturerID, @Center, @Building, @LecturerLevel, @Rank , @ActiveDays, @ActiveTimes)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Title", l.Title);
                cmd.Parameters.AddWithValue("@FirstName", l.FirstName);
                cmd.Parameters.AddWithValue("@LastName", l.LastName);
                cmd.Parameters.AddWithValue("@Faculty", l.Faculty);
                cmd.Parameters.AddWithValue("@Department", l.Department);
                cmd.Parameters.AddWithValue("@LecturerID", l.LecturerID);
                cmd.Parameters.AddWithValue("@Center", l.Center);
                cmd.Parameters.AddWithValue("@Building", l.Building);
                cmd.Parameters.AddWithValue("@LecturerLevel", l.LecturerLevel);
                cmd.Parameters.AddWithValue("@Rank", l.Rank);
                cmd.Parameters.AddWithValue("@ActiveDays", l.ActiveDays);
                cmd.Parameters.AddWithValue("@ActiveTimes", l.ActiveTimes);

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


        //Update Method

        public Boolean Update(LecturerClass l, int id)
        {
            
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Lecturer_Table SET Title = @Title, FirstName = @FirstName, LastName = @LastName, Faculty = @Faculty, Department = @Department, LecturerID = @LecturerID, Center = @Center, Building = @Building, LecturerLevel = @LecturerLevel, Rank = @Rank, ActiveDays=@ActiveDays, ActiveTimes=@ActiveTimes WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Title", l.Title);
                cmd.Parameters.AddWithValue("@FirstName", l.FirstName);
                cmd.Parameters.AddWithValue("@LastName", l.LastName);
                cmd.Parameters.AddWithValue("@Faculty", l.Faculty);
                cmd.Parameters.AddWithValue("@Department", l.Department);
                cmd.Parameters.AddWithValue("@LecturerID", l.LecturerID);
                cmd.Parameters.AddWithValue("@Center", l.Center);
                cmd.Parameters.AddWithValue("@Building", l.Building);
                cmd.Parameters.AddWithValue("@LecturerLevel", l.LecturerLevel);
                cmd.Parameters.AddWithValue("@Rank", l.Rank);
                cmd.Parameters.AddWithValue("@ActiveDays", l.ActiveDays);
                cmd.Parameters.AddWithValue("@ActiveTimes", l.ActiveTimes);

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

        public bool Delete(LecturerClass l , int id)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM Lecturer_Table WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

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
