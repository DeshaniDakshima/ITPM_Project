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
    public partial class Room_Consecutive_Sessions : Form
    {

        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection conn = new SqlConnection(myconstrng);

        public Room_Consecutive_Sessions()
        {
            InitializeComponent();
            loadroom();
            loadcsession();
        }

        void loadroom()
        {
            string sql = "SELECT distinct RoomName FROM tbl_location";
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

        void loadcsession()
        {
            string sql = "SELECT * FROM Consecutive";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader ConsecutiveRead;

            try
            {
                conn.Open();
                ConsecutiveRead = cmd.ExecuteReader();

                while (ConsecutiveRead.Read())
                {
                    string tagCodes = ConsecutiveRead["tagCodes"].ToString();
                    string subjectCode = ConsecutiveRead["subjectCode"].ToString();

                    

                    csession_cmb.Items.Add(subjectCode + " -" + tagCodes);
                    
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
        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearLocationData();
        }

        private void ClearLocationData()
        {
            csession_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
        }


        

        private void btnsave_Click(object sender, EventArgs e)
        {
            if ((room_cmb.Text != string.Empty) && (csession_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select Room,subjectCode_tagCodes  from Consecutive_Room where Room = '" + room_cmb.Text + "' and  subjectCode_tagCodes = '" + csession_cmb.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Room is already allocated for the selected consecutive session! Please choose another");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO[dbo].[Consecutive_Room] ([Room],[subjectCode_tagCodes]) VALUES ('" + room_cmb.Text + "', '" + csession_cmb.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated!");
                    conn.Close();
                    ClearLocationData();
                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Room_Consecutive_Sessions_Load(object sender, EventArgs e)
        {

        }

        private void csession_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
