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

namespace WD_R_14
{
    public partial class Room_Lecturer : Form
    {

        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection conn = new SqlConnection(myconstrng);
        public Room_Lecturer()
        {
            InitializeComponent();
            loadroom();
            loadLecturer();
        }

        void loadroom()
        {
            string sql = "SELECT  distinct RoomName FROM tbl_location";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader RoomNameRead;

            try
            {
                conn.Open();
                RoomNameRead = cmd.ExecuteReader();

                while (RoomNameRead.Read())
                {
                    string RoomName = RoomNameRead["RoomName"].ToString();
                    room_cmb.Items.Add(RoomName);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        void loadLecturer()
        {
            string sql = "SELECT * FROM Lecturer_Table";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader LecturerRead;

            try
            {
                conn.Open();
                LecturerRead = cmd.ExecuteReader();

                while (LecturerRead.Read())
                {
                    string Title = LecturerRead["Title"].ToString();
                    string FName = LecturerRead["FirstName"].ToString();
                    string LName = LecturerRead["LastName"].ToString();
                    lec_cmb.Items.Add(Title + " " + FName + " " + LName);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }


        
        private void ClearLocationData()
        {
            lec_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
        }

        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((lec_cmb.Text != string.Empty) && (room_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select LecturerName,Room from Lecturer_Room where LecturerName = '" + lec_cmb.Text + "' and  Room = '" + room_cmb.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected lecturer");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[Lecturer_Room] ([LecturerName],[Room]) VALUES ('" + lec_cmb.Text + "','" + room_cmb.Text + "' )";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated!");
                    conn.Close();
                    ClearLocationData();
                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            ClearLocationData();
        }

        private void Room_Lecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
