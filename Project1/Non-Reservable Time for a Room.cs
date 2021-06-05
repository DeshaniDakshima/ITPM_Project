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
    public partial class Non_Reservable_Time_for_a_Room : Form
    {

        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection conn = new SqlConnection(myconstrng);
        public Non_Reservable_Time_for_a_Room()
        {
            InitializeComponent();
            loadroom();
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

        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ClearLocationData();
        }

        private void ClearLocationData()
        {
            room_cmb.SelectedIndex = -1;
            cmbday.SelectedIndex = -1;
            cmbstime.SelectedIndex = -1;
            cmbetime.SelectedIndex = -1;
        }

        
        private void cmbday_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((room_cmb.Text != string.Empty) && (cmbday.Text != string.Empty) && (cmbstime.Text != string.Empty))
            {
                
                SqlDataAdapter da = new SqlDataAdapter("Select RoomName, Day,StartTime,EndTime from NonReservableTime_Rooms where RoomName = '" + room_cmb.Text + "' " +
                    "and  Day = '" + cmbday.Text + "' and StartTime = '" + cmbstime.Text + "' and EndTime = '" + cmbetime.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Time is already allocated as non reservable!");
                    ClearLocationData();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[NonReservableTime_Rooms] ([RoomName],[Day],[StartTime],[EndTime]) VALUES ('" + room_cmb.Text + "','" + cmbday.Text + "','" + cmbstime.Text + "','" + cmbetime.Text + "'   )";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Time is allocated as non reservable for the selected room !");
                    conn.Close();
                    ClearLocationData();
                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Non_Reservable_Time_for_a_Room_Load(object sender, EventArgs e)
        {

        }
    }
}
