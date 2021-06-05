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
    public partial class Room_Group : Form
    {
        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection conn = new SqlConnection(myconstrng);
        public Room_Group()
        {
            InitializeComponent();
            loadroom();
            loadSubGroup();
            loadGroup();
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

                while (RoomNameRead.Read()) {
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

        void loadGroup()
        {
            string sql = "SELECT * FROM StudentGroup";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader GroupRead;

            try
            {
                conn.Open();
                GroupRead = cmd.ExecuteReader();

                while (GroupRead.Read())
                {
                    string GroupID = GroupRead["GroupID"].ToString();
                    group_cmb.Items.Add(GroupID);
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
        void loadSubGroup()
        {
            string sql = "SELECT * FROM StudentGroup";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader SubGroupRead;

            try
            {
                conn.Open();
                SubGroupRead = cmd.ExecuteReader();

                while (SubGroupRead.Read())
                {
                    string SubGroupID = SubGroupRead["SubGroupID"].ToString();
                    subgroup_cmb.Items.Add(SubGroupID);
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
            group_cmb.SelectedIndex = -1;
            subgroup_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((group_cmb.Text != string.Empty) && (subgroup_cmb.Text != string.Empty) && (room_cmb.Text != string.Empty))
            {
                
                SqlDataAdapter da = new SqlDataAdapter("Select GroupID, SubGroupID from StudentGroupRoom" +
                    " where GroupID = '" + group_cmb.Text + "' and  SubGroupID = '" + subgroup_cmb.Text + "' and  Room = '" + room_cmb.Text+"'", conn);
                //SqlDataAdapter sda = new SqlDataAdapter ("Select RoomName, Day,StartTime,EndTime from NonReservableTime_Rooms where RoomName = '" + room_cmb.Text + "' " +
                 //   "and  Day = '" + cmbday.Text + "' and StartTime = '" + cmbstime.Text + "' and EndTime = '" + cmbetime.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected group and sub group!");
                    ClearLocationData();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[StudentGroupRoom] ([GroupID],[SubGroupID],[Room]) " +
                        "VALUES ('" + group_cmb.Text + "','" + subgroup_cmb.Text + "','" + room_cmb.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated Successfully!");
                    conn.Close();
                    ClearLocationData();

                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Room_Group_Load(object sender, EventArgs e)
        {

        }
    }
}
