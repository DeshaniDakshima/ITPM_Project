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
    public partial class Room_Session : Form
    {

        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection conn = new SqlConnection(myconstrng);
        public Room_Session()
        {
            InitializeComponent();
            loadroom();
            loadsession();
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

        void loadsession()
        {
            string sql = "SELECT * FROM Session_Table WHERE Status IS NULL ";
            SqlCommand cmd = new SqlCommand(sql, conn);
           
            SqlDataReader sessionRead;

            try
            {
                conn.Open();
                sessionRead = cmd.ExecuteReader();

                while (sessionRead.Read())
                {
                    string SessionRoom = sessionRead["Subject"].ToString();
                    string SessionTag = sessionRead["Tag"].ToString();
                    session_cmb.Items.Add(SessionRoom + " - " + SessionTag);
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
            session_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((session_cmb.Text != string.Empty) && (room_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select Session, RoomName from Session_Room  where Session = '" + session_cmb.Text + "' and  RoomName = '" + room_cmb.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected session");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[Session_Room] ([Session],[RoomName]) VALUES ('" + session_cmb.Text + "','" + room_cmb.Text + "' )";
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

        private void Room_Session_Load(object sender, EventArgs e)
        {

        }
    }
}
