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

namespace WorkingDaysAndHours
{
    public partial class AddLoc : Form
    {
        public AddLoc()
        {
            InitializeComponent();
        }

        int ID = 0;

        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Display()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT *  FROM AddLocation1", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.Columns["id"].Visible = false;
                con.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Data loading Eorr !");
            }
        }

        private void Add_Location1_Load(object sender, EventArgs e)
        {
            Display();

            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from tbl_location;", con);
            SqlDataAdapter ada2 = new SqlDataAdapter(cmd2);
            DataTable data2 = new DataTable();
            ada2.Fill(data2);
            comboBox1.DataSource = data2;
            comboBox1.DisplayMember = "RoomName";
            comboBox1.SelectedIndex = -1;

            ////////////////////////////////////////
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select * from WorkingDay;", con);
            SqlDataAdapter ada3 = new SqlDataAdapter(cmd3);
            DataTable data3 = new DataTable();
            ada3.Fill(data3);
            comboBox2.DataSource = data3;
            comboBox2.DisplayMember = "Days";
            comboBox2.SelectedIndex = -1;
        

         }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            bool isSucces = false;
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                string sql = "INSERT INTO AddLocation1( Room, Day, STime, ETime) VALUES( @Room, @Day, @STime, @ETime)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Room", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Day", comboBox2.Text);
                cmd.Parameters.AddWithValue("@STime", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@ETime", dateTimePicker2.Value.ToString());
              

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Succes");
                }
                else
                {
                    MessageBox.Show("Not Succes");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                Display();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Text = "00:00:00";
            dateTimePicker2.Text = "00:00:00";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                if (ID == 0 || ID.ToString() == "")
                {
                    MessageBox.Show("Please Select a Row");
                }
                else
                {
                    String q = "DELETE FROM AddLocation1 WHERE ID=@ID";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    MessageBox.Show("Success Delete");
                    ID = 0;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error While Deleteing");
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ee)
            {

            }
        }
    }
}
