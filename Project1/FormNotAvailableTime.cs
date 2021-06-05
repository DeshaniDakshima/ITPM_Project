using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class FormNotAvailableTime : Form
    {
        public FormNotAvailableTime()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void FormNotAvailableTime_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select FirstName+' '+LastName AS Names from Lecturer_Table;", con);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            ada.Fill(data);
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "Names";
            comboBox1.SelectedIndex = -1;

            ////////////////////////////////////////
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from StudentGroup;", con);
            SqlDataAdapter ada1 = new SqlDataAdapter(cmd1);
            DataTable data1 = new DataTable();
            ada1.Fill(data1);
            comboBox2.DataSource = data1;
            comboBox2.DisplayMember = "GroupID";
            comboBox2.SelectedIndex = -1;
            /////////////////////////////
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from StudentGroup;", con);
            SqlDataAdapter ada2 = new SqlDataAdapter(cmd2);
            DataTable data2 = new DataTable();
            ada2.Fill(data2);
            comboBox3.DataSource = data2;
            comboBox3.DisplayMember = "SubGroupID";
            comboBox3.SelectedIndex = -1;

            ////////////////////////////////////////
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select * from Session_Table;", con);
            SqlDataAdapter ada3 = new SqlDataAdapter(cmd3);
            DataTable data3 = new DataTable();
            ada3.Fill(data3);
            comboBox4.DataSource = data3;
            comboBox4.DisplayMember = "SessionID";
            comboBox4.SelectedIndex = -1;
            /////////////////////////////////
            
        }



        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelConsecutive.Controls.Add(childForm);
            panelConsecutive.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new listNotAvailableTime());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
                bool isSucces = false;                
            try
                {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                string sql = "INSERT INTO NotAvailableTime(Lecturer, GroupID, SubGroup, SessionID, Date, Time) VALUES(@Lecturer, @GroupID, @SubGroup, @SessionID, @Date, @Time)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Lecturer", comboBox1.Text);
                cmd.Parameters.AddWithValue("@GroupID", comboBox2.Text);
                cmd.Parameters.AddWithValue("@SubGroup", comboBox3.Text);
                cmd.Parameters.AddWithValue("@SessionID", comboBox4.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@Time", dateTimePicker2.Value.ToString());


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
                }
                
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            dateTimePicker1.Text = "00:00:00";
            dateTimePicker2.Text = "00:00:00";
        }
    }
}

