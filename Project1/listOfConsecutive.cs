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
using System.Xml;

namespace Project1
{
    public partial class listOfConsecutive : Form
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public listOfConsecutive()
        {
            InitializeComponent();
        }
        private void Display()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                String q = "SELECT * FROM Session_Table where Subject=@subjectName AND Status='C'";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@subjectName", List.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data loading Eorr !  " + ee.Message);
            }
        }

        private void listOfConsecutive_Load(object sender, EventArgs e)
        {
            string sql = "select * from Subject_Table";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader SubjectRead;

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SubjectRead = cmd.ExecuteReader();

                while (SubjectRead.Read())
                {
                    string SubjectName = SubjectRead["SubjectName"].ToString();
                    string SubjectCode = SubjectRead["SubjectCode"].ToString();

                    List.Items.Add(SubjectName + " ( " + SubjectCode + " ) ");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error while data binding    ");
            }

            //dataGridView.Columns[1].HeaderText = "Tag Codes";
            //dataGridView.Columns[2].HeaderText = "Subject Code";

        }

        public int id = 0;
        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (List.Text == "")
            {
                MessageBox.Show("Please Select a Subject");
            }
            else
            {
                try
                {
                    String q = "UPDATE Session_Table SET Status='' where Subject=@subjectName AND Status='C'";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@subjectName", List.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                    con.Close();

                    MessageBox.Show("Success Delete");
                    Display();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error While Deleteing" + ee.Message);
                }
            }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }
    }
}
