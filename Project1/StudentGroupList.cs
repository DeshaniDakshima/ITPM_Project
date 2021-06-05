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
    public partial class StudentGroupList : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public StudentGroupList()
        {
            InitializeComponent();
        }

        private void Display()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM StudentGroup", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.Columns["ID"].Visible = false;
                conn.Close();
                dataGridView.Columns[1].HeaderText = "Academic Y&S";
                dataGridView.Columns[2].HeaderText = "Program";
                dataGridView.Columns[3].HeaderText = "Group Number";
                dataGridView.Columns[4].HeaderText = "Sub-Group Number";
                dataGridView.Columns[5].HeaderText = "Group ID";
                dataGridView.Columns[6].HeaderText = "Sub-Group ID";
            }
            catch(Exception ee)
            {
                MessageBox.Show("Data loading Eorr !");
            }
        }
        public void Check()
        {
            if (textAcademicYearSemister.Text == "")
            {
                MessageBox.Show(" Please Select Academic Year and Semister !");
            }
            else if (textProgram.Text == "")
            {
                MessageBox.Show(" Please Select Program !");
            }
            else if (textGroupNumber.Value == 0)
            {
                MessageBox.Show(" Please Select Group Number !");
            }
            else if (textSubGroupNumber.Value == 0)
            {
                MessageBox.Show(" Please Select Sub-Group Number !");
            }
            else if (textGroupID.Text == "")
            {

            }
            else if (textSubGroupID.Text == "")
            {

            }
        }


        private void StudentGroupList_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            textAcademicYearSemister.SelectedIndex = -1;
            textProgram.SelectedIndex = -1;
            textGroupNumber.Text = "0";
            textSubGroupNumber.Text = "0";
            textGroupID.Text = String.Empty;
            textSubGroupID.Text = String.Empty;
        }

        int gID;

        StudentGroup sg = new StudentGroup();




        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            try
            {
                StudentGroup sgo = new StudentGroup();
                gID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                textAcademicYearSemister.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textProgram.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textGroupNumber.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                textSubGroupNumber.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                textGroupID.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                textSubGroupID.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception eee)
            {

            }
        }


        private void btnGenarateID_Click_1(object sender, EventArgs e)
        {
            Check();
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                String q = "SELECT SubGroupID FROM StudentGroup WHERE SubGroupID =@SGID";
                String GID = textAcademicYearSemister.Text + "." + Int16.Parse(textGroupNumber.Text) + "(" + textProgram.Text + ")";
                textGroupID.Text = GID;
                String SGID = textAcademicYearSemister.Text + "." + Int16.Parse(textGroupNumber.Text) + "." + Int16.Parse(textSubGroupNumber.Text) + "(" + textProgram.Text + ")";
                textSubGroupID.Text = SGID;

                conn.Open();
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@SGID", SGID);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                ArrayList list = new ArrayList();

                foreach (DataRow row in table.Rows)
                {
                    String temp = row["SubGroupID"].ToString();
                    list.Add(temp);
                }
                String[] Arr = (String[])list.ToArray(typeof(String));
                if (Arr.Length != 0)
                {
                    MessageBox.Show(textSubGroupID.Text + " Group is already exist. Please enter another Sub-Group ID!");
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                String q = "SELECT SubGroupID FROM StudentGroup WHERE SubGroupID =@SGID";
                String GID = textAcademicYearSemister.Text + "." + Int16.Parse(textGroupNumber.Text) + "(" + textProgram.Text + ")";
                textGroupID.Text = GID;
                String SGID = textAcademicYearSemister.Text + "." + Int16.Parse(textGroupNumber.Text) + "." + Int16.Parse(textSubGroupNumber.Text) + "(" + textProgram.Text + ")";
                textSubGroupID.Text = SGID;

                conn.Open();
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@SGID", SGID);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                ArrayList list = new ArrayList();

                foreach (DataRow row in table.Rows)
                {
                    String temp = row["SubGroupID"].ToString();
                    list.Add(temp);
                }
                String[] Arr = (String[])list.ToArray(typeof(String));
                if (Arr.Length != 0)
                {
                    MessageBox.Show(textSubGroupID.Text + " Group is already exist. Please enter another Sub-Group ID!");
                }
                else
                {

                    sg.academicYearSemister = textAcademicYearSemister.Text;
                    sg.program = textProgram.Text;
                    sg.groupNumber = Int16.Parse(textGroupNumber.Text);
                    sg.subGroupNumber = Int16.Parse(textSubGroupNumber.Text);
                    sg.groupID = textGroupID.Text;
                    sg.subGroupID = textSubGroupID.Text;

                    String result = sg.Update(sg, gID);
                    MessageBox.Show(result);

                    if (result == "Success Update")
                    {
                        Clear();
                        Display();
                    }
                }
                conn.Close();
                Display();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (textAcademicYearSemister.Text == "" || textProgram.Text == "" || textGroupNumber.Value == 0 || textSubGroupNumber.Value == 0 || textGroupID.Text == "" || textSubGroupID.Text == "")
                {
                    MessageBox.Show("Please Select a Student Group");
                }
                else
                {
                    String q = "DELETE FROM StudentGroup WHERE ID=@id";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@id", gID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Display();
                    MessageBox.Show("Success Delete");
                    Clear();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
