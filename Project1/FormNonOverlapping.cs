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
    public partial class FormNonOverlapping : Form
    {
        public FormNonOverlapping()
        {
            InitializeComponent();
        }

        

        private void FormNonOverlapping_Load(object sender, EventArgs e)
        {
            Display();

            
            //dataGridView.Columns[1].HeaderText = "Tag Code";
            //dataGridView.Columns[2].HeaderText = "Tag Name";
            //dataGridView.Columns[3].HeaderText = "Releted Subject Code";
            //dataGridView.Columns[4].HeaderText = "Subject Name";
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

        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public void Display()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                String q = "SELECT * FROM Subject_Table";

                SqlCommand cmd = new SqlCommand(q, con);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.Columns["SubjectID"].Visible = false;
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data loading Eorr !  ");
            }
        }






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



        public String tagCode, subjectCode;

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

        public String SubjectName, subject;


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
                        SubjectName = row.Cells[4].Value.ToString();
                        SesionIDList.Add(SubjectName);
                    }
                }

                String[] SubjectNameArray = (String[])SesionIDList.ToArray(typeof(String));

                if (SubjectNameArray.Length == 1)
                {
                    MessageBox.Show("Please Select More Than Two item");
                }
                else
                {
                    String Subjects = string.Join(" ,", SubjectNameArray);
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Open();
                    try
                    {
                        String q = "SELECT SubjectNames FROM NonOverlapping WHERE SubjectNames=@SubjectNames";
                                if (con.State == ConnectionState.Open)
                                    con.Close();
                                con.Open();
                                SqlCommand cmd1 = new SqlCommand(q, con);
                                cmd1.Parameters.AddWithValue("@SubjectNames", Subjects);
                               
                                DataTable table1 = new DataTable();
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                                adapter.Fill(table1);

                     if (table1.Rows.Count != 0) {
                       MessageBox.Show("Already Exist");

                        }
                        else {
                                String sql = " INSERT INTO NonOverlapping (SubjectNames) VALUES (@Subjects); ";
                                SqlCommand cmd = new SqlCommand(sql, con);
                                cmd.Parameters.AddWithValue("@Subjects", Subjects);
                                cmd.ExecuteNonQuery();

                            MessageBox.Show("Successful Insert");
                            clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error while Inserting ");
                    }
                    finally
                    {
                        con.Close();
                    }
                }


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            openChildForm(new listOfNonOverlapping());
            panel2.Visible = false;
        }

        

    }
}
