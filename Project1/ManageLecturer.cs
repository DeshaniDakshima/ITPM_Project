using ITPM_Project.LecturerClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_Project
{
    public partial class ManageLecturer : Form
    {
        public ManageLecturer()
        {
            InitializeComponent();
        }

        int id;
        LecturerClass l = new LecturerClass();
        bool isEmpty = false;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Display the all delails in DataGridView
        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private void Display()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Lecturer_Table", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                lecGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ee)
            {
                //MessageBox.Show("Data loading Error!");
                MessageBox.Show("Data loading Error!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lecGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void ManageLecturer_Load(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        //Generate Rank using Rankmap 
        public Boolean rankMap()
        {
            Dictionary<String, int> rankMap = new Dictionary<String, int>();

            //Assign numbers to relevant level
            rankMap.Add("Professor", 1);
            rankMap.Add("Assistant Professor", 2);
            rankMap.Add("Senior Lecturer(HG)", 3);
            rankMap.Add("Senior Lecturer", 4);
            rankMap.Add("Lecturer", 5);
            rankMap.Add("Assistant Lecturer", 6);

            //Check level, lecture ID are empty or not and generate rank
            if (txtLevelBoxML.Text != "" && txtLecturerIDBoxML.Text != "")
            {
                int value = rankMap[txtLevelBoxML.Text];

                StringBuilder sb = new StringBuilder();
                sb.Append(value + "." + txtLecturerIDBoxML.Text);

                txtRankBoxML.Text = sb.ToString();
                return true;
            }
            else
            {
                
                return false;
            }

            
        }


        ArrayList arrDays = new ArrayList();
        ArrayList arrTimes = new ArrayList();


        //User can insert number only to LectureID
        public void numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtLecturerIDBoxML_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberonly(sender, e);
        }


        public void Clear()
        {
            txtTitleBoxML.SelectedIndex = -1;
            txtFnameBoxML.Clear();
            txtLnameBoxML.Clear();
            txtFacultyBoxML.SelectedIndex = -1;
            txtDepBoxML.SelectedIndex = -1;
            txtLecturerIDBoxML.Clear();
            txtCenterBoxML.SelectedIndex = -1;
            txtBuildingBoxML.SelectedIndex = -1;
            txtLevelBoxML.SelectedIndex = -1;
            txtRankBoxML.Clear();
            txtSearchBoxML.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
        }

        //Lecturer details are view 
        static string myconnstring = "Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        
        private void txtSearchBoxML_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchBoxML.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Lecturer_Table WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR LecturerID LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lecGridView.DataSource = dt;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            try
            {
                int rowIndex = e.RowIndex;
                id = Int16.Parse(lecGridView.Rows[rowIndex].Cells[0].Value.ToString());
                txtTitleBoxML.Text = lecGridView.Rows[rowIndex].Cells[1].Value.ToString();
                txtFnameBoxML.Text = lecGridView.Rows[rowIndex].Cells[2].Value.ToString();
                txtLnameBoxML.Text = lecGridView.Rows[rowIndex].Cells[3].Value.ToString();
                txtFacultyBoxML.Text = lecGridView.Rows[rowIndex].Cells[4].Value.ToString();
                txtDepBoxML.Text = lecGridView.Rows[rowIndex].Cells[5].Value.ToString();
                txtLecturerIDBoxML.Text = lecGridView.Rows[rowIndex].Cells[6].Value.ToString();
                txtCenterBoxML.Text = lecGridView.Rows[rowIndex].Cells[7].Value.ToString();
                txtBuildingBoxML.Text = lecGridView.Rows[rowIndex].Cells[8].Value.ToString();
                txtLevelBoxML.Text = lecGridView.Rows[rowIndex].Cells[9].Value.ToString();
                txtRankBoxML.Text = lecGridView.Rows[rowIndex].Cells[10].Value.ToString();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                String q1 = "SELECT ActiveDays FROM Lecturer_Table WHERE ID=@ID";
                conn.Open();
                SqlCommand cmd = new SqlCommand(q1, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                ArrayList list1 = new ArrayList();

                String[] Arr;

                foreach (DataRow row in table.Rows)
                {
                    String temp = row["ActiveDays"].ToString();
                    list1.Add(temp);
                }
                Arr = (String[])list1.ToArray(typeof(String));
                string[] Arr1 = Arr[0].Split(',');
                for (int i = 0; i < Arr1.Length; i++)
                {
                    String day = Arr1[i];
                    if (day == "Monday")
                        checkBox1.Checked = true;
                    if (day == "Tuesday")
                        checkBox2.Checked = true;
                    if (day == "Wednesday")
                        checkBox3.Checked = true;
                    if (day == "Thursday")
                        checkBox4.Checked = true;
                    if (day == "Friday")
                        checkBox5.Checked = true;

                }



                if (conn.State == ConnectionState.Open)
                    conn.Close();
                String q2 = "SELECT ActiveTimes FROM Lecturer_Table WHERE ID=@ID";
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(q2, conn);
                cmd2.Parameters.AddWithValue("@ID", id);
                DataTable table2 = new DataTable();
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                adapter2.Fill(table2);
                ArrayList list2 = new ArrayList();

                String[] Arr3;

                foreach (DataRow row in table2.Rows)
                {
                    String temp2 = row["ActiveTimes"].ToString();
                    list2.Add(temp2);
                }
                Arr3 = (String[])list2.ToArray(typeof(String));
                string[] Arr4 = Arr3[0].Split(',');
                for (int i = 0; i < Arr4.Length; i++)
                {
                    String time = Arr4[i];
                    if (time == "8.30-9.30")
                        checkBox6.Checked = true;
                    if (time == "9.30-10.30")
                        checkBox7.Checked = true;
                    if (time == "10.30-11.30")
                        checkBox8.Checked = true;
                    if (time == "11.30-12.30")
                        checkBox9.Checked = true;
                    if (time == "12.30-13.30")
                        checkBox10.Checked = true;
                    if (time == "13.30-14.30")
                        checkBox11.Checked = true;
                    if (time == "14.30-15.30")
                        checkBox12.Checked = true;
                    if (time == "15.30-16.30")
                        checkBox13.Checked = true;
                    if (time == "16.30-17.30")
                        checkBox14.Checked = true;
                }
                Arr = null;
                Arr1 = null;
                Arr3 = null;
                Arr4 = null;
                list1.Clear();
                list2.Clear();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Boolean rankMapResult = rankMap();

            if (checkBox1.Checked)
                arrDays.Add("Monday");
            if (checkBox2.Checked)
                arrDays.Add("Tuesday");
            if (checkBox3.Checked)
                arrDays.Add("Wednesday");
            if (checkBox4.Checked)
                arrDays.Add("Thursday");
            if (checkBox5.Checked)
                arrDays.Add("Friday");
            if (checkBox6.Checked)
                arrTimes.Add("8.30-9.30");
            if (checkBox7.Checked)
                arrTimes.Add("9.30-10.30");
            if (checkBox8.Checked)
                arrTimes.Add("10.30-11.30");
            if (checkBox9.Checked)
                arrTimes.Add("11.30-12.30");
            if (checkBox10.Checked)
                arrTimes.Add("12.30-13.30");
            if (checkBox11.Checked)
                arrTimes.Add("13.30-14.30");
            if (checkBox12.Checked)
                arrTimes.Add("14.30-15.30");
            if (checkBox13.Checked)
                arrTimes.Add("15.30-16.30");
            if (checkBox14.Checked)
                arrTimes.Add("16.30-17.30");

            String[] Arr1 = (String[])arrDays.ToArray(typeof(String));
            String days = string.Join(",", Arr1);

            String[] Arr2 = (String[])arrTimes.ToArray(typeof(String));
            String times = string.Join(",", Arr2);

            //Check all text fields are empty or not
            if (txtTitleBoxML.Text != "" && txtFnameBoxML.Text != "" && txtLnameBoxML.Text != "" && txtFacultyBoxML.Text != "" && txtDepBoxML.Text != "" && txtLecturerIDBoxML.Text != "" && txtCenterBoxML.Text != "" && txtBuildingBoxML.Text != "" && txtLevelBoxML.Text != "" && txtRankBoxML.Text != "")
            {
                l.Title = txtTitleBoxML.Text;
                l.FirstName = txtFnameBoxML.Text;
                l.LastName = txtLnameBoxML.Text;
                l.Faculty = txtFacultyBoxML.Text;
                l.Department = txtDepBoxML.Text;
                l.LecturerID = int.Parse(txtLecturerIDBoxML.Text);
                l.Center = txtCenterBoxML.Text;
                l.Building = txtBuildingBoxML.Text;
                l.LecturerLevel = txtLevelBoxML.Text;
                l.Rank = txtRankBoxML.Text;
                l.ActiveDays = days;
                l.ActiveTimes = times;
                isEmpty = false;

            }
            else
            {
                MessageBox.Show("Please Select Relavent Row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isEmpty = true;

            }

            if (!isEmpty)
            {

                if (l.Update(l, id))
                {
                    MessageBox.Show("Lecturer has been Successfully Updated!");
                    Clear();
                    Display();
                }
                else
                {
                    MessageBox.Show("Failed to Update Lecturer. Try Again!");
                    Clear();
                }
            }

            days = null;
            times = null;

            arrDays.Clear();
            arrTimes.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTitleBoxML.Text != "" && txtFnameBoxML.Text != "" && txtLnameBoxML.Text != "" && txtFacultyBoxML.Text != "" && txtDepBoxML.Text != "" && txtLecturerIDBoxML.Text != "" && txtCenterBoxML.Text != "" && txtBuildingBoxML.Text != "" && txtLevelBoxML.Text != "" && txtRankBoxML.Text != "")
            {
                l.ID = Convert.ToInt32(txtLecturerIDBoxML.Text);
                bool success = l.Delete(l, id);

            
                if (success == true)
                {
                    MessageBox.Show("Lecturer Successfully Deleted!");
                    Clear();
                    Display();

                }
                else
                {
                    MessageBox.Show("Failed to Delete Lecturer. Try Again!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Relavent Row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
