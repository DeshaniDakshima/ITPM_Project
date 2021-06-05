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
    public partial class Rooms_Subject_and_Tag : Form
    {
        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection conn = new SqlConnection(myconstrng);
        public Rooms_Subject_and_Tag()
        {
            InitializeComponent();
            loadroom();
            loadSubject();
            loadTag();
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

        void loadSubject()
        {
            string sql = "SELECT * FROM Subject_Table";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader SubjectRead;

            try
            {
                conn.Open();
                SubjectRead = cmd.ExecuteReader();

                while (SubjectRead.Read())
                {
                    string SubjectName = SubjectRead["SubjectName"].ToString();
                    string SubjectCode = SubjectRead["SubjectCode"].ToString();
                    subject_cmb.Items.Add(SubjectName +" - "+SubjectCode);
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

        void loadTag()
        {
            string sql = "SELECT * FROM Tag";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader TagRead;

            try
            {
                conn.Open();
                TagRead = cmd.ExecuteReader();

                while (TagRead.Read())
                {
                    string TagName = TagRead["TagName"].ToString();
                    tag_cmb.Items.Add(TagName);
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
            subject_cmb.SelectedIndex = -1;
            tag_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((subject_cmb.Text != string.Empty) && (tag_cmb.Text != string.Empty) && (room_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select Subject, Tag, Room from SubjectTag_Rooms where Subject = '" + subject_cmb.Text + "'and (Tag = '" + tag_cmb.Text + "'  and Room = '" + room_cmb.Text + "')", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected subject and tag");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[SubjectTag_Rooms] ([Subject],[Tag],[Room]) VALUES ('" + subject_cmb.Text + "','" + tag_cmb.Text + "','" + room_cmb.Text + "' )";
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

        private void Rooms_Subject_and_Tag_Load(object sender, EventArgs e)
        {

        }
    }
}
