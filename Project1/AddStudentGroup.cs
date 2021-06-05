using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Project1
{
    public partial class AddStudentGroup : Form
    {
        public AddStudentGroup()
        {
            InitializeComponent();
        }
        String ckeckGenatareBtn = "";

        StudentGroup sg = new StudentGroup();

        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

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

        private void btnGenarateID_Click(object sender, EventArgs e)
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
                if (textGroupNumber.Value == 0 || textSubGroupNumber.Value == 0)
                    Clear();
                ckeckGenatareBtn = "OK";

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
                    textGroupID.Text = "";
                    textSubGroupID.Text = "";
                    ckeckGenatareBtn = "";
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Check();
            sg.academicYearSemister = textAcademicYearSemister.Text ;
            sg.program = textProgram.Text;
            sg.groupNumber = (int)textGroupNumber.Value;
            sg.subGroupNumber = (int)textSubGroupNumber.Value;
            sg.groupID = textGroupID.Text;
            sg.subGroupID = textSubGroupID.Text;
            if (textAcademicYearSemister.Text == "" || textProgram.Text == "" || textGroupNumber.Value == 0 || textSubGroupNumber.Value == 0)
            {
                
            }
            else
            {
                String result = "";

                if (ckeckGenatareBtn == "OK")
                {
                    result = sg.Insert(sg);
                }
                else
                {
                    MessageBox.Show("Please Genarate IDs");
                }
                if (result == "Success Insert")
                {
                    MessageBox.Show(result);
                    Clear();
                }
            }
            ckeckGenatareBtn = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddStudentGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
