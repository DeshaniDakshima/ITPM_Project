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

namespace WorkingDaysAndHours
{
    public partial class Working_Days : Form
    {
        public Working_Days()
        {
            InitializeComponent();
        }

        int id = 0;

        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        WorkingDay c = new WorkingDay();
        private void Display()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM WorkingDay", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data loading Eorr !");
            }
        }

        ArrayList arrDays = new ArrayList();



        

       

        public void Clear()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

       

        




        private void Working_Days_Load(object sender, EventArgs e)
        {
            Display();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                arrDays.Add("Monday");
            if (checkBox2.Checked)
                arrDays.Add("Tuesday");
            if (checkBox3.Checked)
                arrDays.Add("Wednesday");
            if (checkBox4.Checked)
                arrDays.Add("Thuresday");
            if (checkBox5.Checked)
                arrDays.Add("Friday");
            if (checkBox6.Checked)
                arrDays.Add("Saturday");
            if (checkBox7.Checked)
                arrDays.Add("Sunday");

            String[] Arr1 = (String[])arrDays.ToArray(typeof(String));
            String days = string.Join(",", Arr1);
            c.Days = days;

            var success = c.Insert(c);
            if (success == "true")
            {
                MessageBox.Show("New contact Successfull insert");
                Display();
                Clear();
                arrDays.Clear();
            }
            else
            {
                MessageBox.Show("New contact Unsuccessfull insert");
            }
            arrDays.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                arrDays.Add("Monday");
            if (checkBox2.Checked)
                arrDays.Add("Tuesday");
            if (checkBox3.Checked)
                arrDays.Add("Wednesday");
            if (checkBox4.Checked)
                arrDays.Add("Thuresday");
            if (checkBox5.Checked)
                arrDays.Add("Friday");
            if (checkBox6.Checked)
                arrDays.Add("Saturday");
            if (checkBox7.Checked)
                arrDays.Add("Sunday");

            String[] Arr1 = (String[])arrDays.ToArray(typeof(String));
            String days = string.Join(",", Arr1);
            c.Days = days;

            String success = c.Update(c, id);
            if (success == "true")
            {
                MessageBox.Show("Cotact has been Successfull Update");
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                Clear();
                Display();
            }
            else
            {
                MessageBox.Show("Cotact has been Unsuccessfull Update");
            }
            arrDays.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = c.Delete(c, id);
            if (success == true)
            {
                MessageBox.Show("Cotact has been Successfull Deleted");
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                Clear();
                Display();
            }
            else
            {
                MessageBox.Show("Cotact has been Unsuccessfull Deleted");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clear();
                int rowIndex = e.RowIndex;
                id = Int16.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                if (con.State == ConnectionState.Open)
                    con.Close();
                String q = "SELECT Days FROM WorkingDay WHERE EntryID=@ID";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@ID", id);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                ArrayList list1 = new ArrayList();

                String[] Arr;

                foreach (DataRow row in table.Rows)
                {
                    String temp = row["Days"].ToString();
                    list1.Add(temp);
                }
                Arr = (String[])list1.ToArray(typeof(String));
                string[] Arr1 = Arr[0].Split(',');
                for (int i = 0; i < Arr1.Length; i++)
                {
                    String day = Arr1[i];
                    if (day == "Monday")
                        checkBox1.Checked = true;
                    else if (day == "Tuesday")
                        checkBox2.Checked = true;
                    else if (day == "Wednesday")
                        checkBox3.Checked = true;
                    else if (day == "Thuresday")
                        checkBox4.Checked = true;
                    else if (day == "Friday")
                        checkBox5.Checked = true;
                    else if (day == "Saturday")
                        checkBox6.Checked = true;
                    else if (day == "Sunday")
                        checkBox7.Checked = true;
                }
                list1.Clear();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
