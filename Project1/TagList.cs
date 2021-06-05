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
    public partial class TagList : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        Tag t = new Tag();
        public TagList()
        {
            InitializeComponent();
        }
        int Tid;
        private void clear()
        {
            txtTagName.Text = "";
            RelatedTag.SelectedIndex = -1;
            txtTagCodetxt.Text = "";
        }

        private void Clear()
        {
            txtTagName.Text = "";
            RelatedTag.SelectedIndex = -1;
            txtTagCodetxt.Text = "";
        }


        private void Display()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Tag", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.Columns["ID"].Visible = false;
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data loading Eorr !");
            }
        }

        private void TagList_Load(object sender, EventArgs e)
        {
            Display();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Subject_Table", conn);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            ada.Fill(data);

            RelatedTag.DataSource = data;
            RelatedTag.DisplayMember = "SubjectCode";
            RelatedTag.SelectedIndex = -1;

            dataGridView.Columns[1].HeaderText = "Tag Name";
            dataGridView.Columns[2].HeaderText = "Tag Code";
            dataGridView.Columns[3].HeaderText = "Related Subject Code";

        }




        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            try
            {
                Tid = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTagName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                String code = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTagCodetxt.SelectedText =  code.ToString();
                RelatedTag.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ee)
            {

            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (RelatedTag.Text == "")
            {
                MessageBox.Show("Please Enter Tag Code");
            }
            else if (txtTagName.Text == "")
            {
                MessageBox.Show("Please Enter Tag Name");
            }
            else if (txtTagCodetxt.Text == "")
            {
                MessageBox.Show("Please Enter Related Tag");
            }
            else
            {
                String result = "";

                String q = "SELECT TagName FROM Tag WHERE TagName=@TagName AND RelatedTag=@RelatedTag AND TagCode=@TagCode;";
                t.tagName = txtTagName.Text;
                t.tagCode = txtTagCodetxt.Text;
                t.relatedTag = RelatedTag.Text;
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@TagName", txtTagName.Text);
                    cmd.Parameters.AddWithValue("@RelatedTag", txtTagCodetxt.Text);
                    cmd.Parameters.AddWithValue("@TagCode", RelatedTag.Text);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    ArrayList list = new ArrayList();

                    foreach (DataRow row in table.Rows)
                    {
                        String temp = row["TagName"].ToString();
                        list.Add(temp);
                    }
                    String[] Arr = (String[])list.ToArray(typeof(String));
                    if (Arr.Length != 0)
                    {
                        MessageBox.Show("This Tag is already exist !");
                    }
                    else
                    {
                        result = t.Update(t, Tid);
                    }    
                        MessageBox.Show(result);
                        Display();
                        clear();
                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (txtTagCodetxt.Text == "" || RelatedTag.Text == "" || txtTagName.Text == "")
                {
                    MessageBox.Show("Please Select a Student Group");
                }
                else
                {
                    String q = "DELETE FROM Tag WHERE Id=@id";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@id", Tid);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Display();
                    Clear();
                    MessageBox.Show("Success Delete");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
