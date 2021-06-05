using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD_R_14.LocationsClasses
{
    class LocationClass
    {
        //Getter & setter 

        public int LocationID { get; set; }
        public string BuildingName { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public string Capacity { get; set; }


        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // Select data from Database

        public DataTable Select() 
        {
            SqlConnection conn = new SqlConnection(myconstrng);
            DataTable dt = new DataTable();
            try 
            {
                string sql = "SELECT * FROM tbl_Location";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Inseert data from Database
        public bool Insert(LocationClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconstrng);
            try
            {
                string sql = "INSERT INTO tbl_Location(BuildingName,RoomName,RoomType,Capacity)VALUES (@BuildingName,@RoomName,@RoomType,@Capacity)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@BuildingName", c.BuildingName);
                cmd.Parameters.AddWithValue("@RoomName", c.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", c.RoomType);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);

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
            
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        // Update data from Database
        public bool Update(LocationClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconstrng);
            try
            {
                string sql = "UPDATE tbl_Location SET BuildingName = @BuildingName , RoomName = @RoomName , RoomType = @RoomType , Capacity = @Capacity WHERE LocationID = @LocationID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BuildingName", c.BuildingName);
                cmd.Parameters.AddWithValue("@RoomName", c.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", c.RoomType);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@LocationID", c.LocationID);

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
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        // Delect data from Database
        public bool Delete(LocationClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconstrng);
            try
            {
                string sql = "DELETE FROM tbl_Location  WHERE LocationID = @LocationID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@LocationID", c.LocationID);

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
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
        // Chart data Select in Database 
        public DataTable Count()
        {
            SqlConnection conn = new SqlConnection(myconstrng);
            DataTable dt = new DataTable();
            try 
            {
                string sql = "SELECT Location,COUNT(LocationID) as countlLoc FROM tbl_Location GROUP BY RoomType";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }


    }

}
