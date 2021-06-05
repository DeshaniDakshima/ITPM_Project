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
    public partial class AddTags : Form
    {
        public AddTags()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        Tag t = new Tag();

        private void AddTags_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Subject_Table", con);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            ada.Fill(data);

            txtRelatedTag.DataSource = data;
            txtRelatedTag.DisplayMember = "SubjectCode";
            txtRelatedTag.SelectedIndex = -1;
        }

        private void clear()
        {
            txtTagName.Text = "";
            txtRelatedTag.SelectedIndex = -1;
            txtTagCode.Text = "";
        }

        private void check()
        {
            if (txtRelatedTag.Text == "")
            {
                MessageBox.Show("Please Enter Tag Code");
            }
            else if (txtTagName.Text == "")
            {
                MessageBox.Show("Please Enter Tag Name");
            }
            else if (txtTagCode.Text == "")
            {
                MessageBox.Show("Please Enter Related Tag");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            t.tagName = txtTagName.Text;
            t.tagCode = txtTagCode.Text;
            t.relatedTag = txtRelatedTag.Text;

            String result = "";

            String q = "SELECT TagName FROM Tag WHERE TagName=@TagName AND RelatedTag=@RelatedTag AND TagCode=@TagCode;";
            try
            {
                check();
                if (txtTagCode.Text == "" || txtTagName.Text == "" || txtRelatedTag.Text == "") {
                }
                else { 
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@TagName", txtTagName.Text);
                    cmd.Parameters.AddWithValue("@RelatedTag", txtRelatedTag.Text);
                    cmd.Parameters.AddWithValue("@TagCode", txtTagCode.Text);
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
                        MessageBox.Show(txtRelatedTag.Text + txtTagName.Text + txtTagCode.Text + " Group is already exist !");
                    }
                    else
                    {
                        result = t.Insert(t);
                        if (result == "Success Insert")
                        {
                            MessageBox.Show(result);
                            clear();
                        }
                    }
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
    }
}
