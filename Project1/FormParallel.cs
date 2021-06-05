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
    public partial class FormParallel : Form
    {
        public FormParallel()
        {
            InitializeComponent();
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

        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public void Display()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                String q = "SELECT * FROM Session_Table where Subject=@subjectName AND (Status IS NULL OR Status='')";

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
                MessageBox.Show("Data loading Eorr !  ");
            }
        }



        public String SessonID, subject;


        private void clear()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (chk.Value == chk.TrueValue)
                {
                    chk.Value = chk.FalseValue;
                }
            }
        }



        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public String tagCode, subjectCode;

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView.CurrentRow;
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];

                if (chk.Value == chk.TrueValue)
                {
                    chk.Value = chk.FalseValue;
                }
                else
                {
                    chk.Value = chk.TrueValue;
                }
            }
            catch (Exception ee)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ArrayList SesionIDList = new ArrayList();
            int Ts = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (chk.Value == chk.TrueValue)
                {
                    Ts++;
                }
            }

            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            if (Ts == 0)
            {
                MessageBox.Show("Please select items !");
            }

            else if (Ts != 0)
            {

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (chk.Value == chk.TrueValue)
                    {
                        SessonID = row.Cells[1].Value.ToString();
                        SesionIDList.Add(SessonID);
                    }
                }

                String[] SessionIDArray = (String[])SesionIDList.ToArray(typeof(String));

                if (SessionIDArray.Length == 1)
                {
                    MessageBox.Show("Please Select More Than Two item");
                }
                else
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Open();
                    try
                    {

                        for (int i = 0; i < SessionIDArray.Length; i++)
                        {
                            String sql = "UPDATE Session_Table SET Status = 'P' WHERE SessionID=@SessionID; ";

                            SqlCommand cmd1 = new SqlCommand(sql, con);
                            cmd1.Parameters.AddWithValue("@SessionID", SessionIDArray[i]);
                            cmd1.ExecuteNonQuery();
                        }


                        subject = List.Text;


                        MessageBox.Show("Successful Insert");
                        clear();
                        Display();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error while Iserting ");
                    }
                    finally
                    {
                        con.Close();
                    }
                }


            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            openChildForm(new listOfParallel());
            panel2.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void FormParallel_Load(object sender, EventArgs e)
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
                MessageBox.Show("Error while data binding");
            }
            //dataGridView.Columns[1].HeaderText = "Tag Code";
            //dataGridView.Columns[2].HeaderText = "Tag Name";
            //dataGridView.Columns[3].HeaderText = "Releted Subject Code";
            //dataGridView.Columns[4].HeaderText = "Subject Name";
        }
    }
}
