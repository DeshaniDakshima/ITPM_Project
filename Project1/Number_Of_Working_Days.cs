using System;
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
    public partial class Number_Of_Working_Days : Form
    {
        public Number_Of_Working_Days()
        {
            InitializeComponent();
        }
        int id=0;

        SqlConnection con = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        NoOfWorkingDays c = new NoOfWorkingDays();
        private void Display()
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                try
                {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM NoWorkingDays", con);
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

         

            public void Clear()
            {
                numericUpDown1.Text = "";
               

            }


      


        private void Number_Of_Working_Days_Load(object sender, EventArgs e)
        {
            Display();
        }

 

        private void SubGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                id = Int16.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                numericUpDown1.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ee)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.Number_Of_Working_Days = numericUpDown1.Value.ToString();
            if (c.Number_Of_Working_Days == "0")
            {
                MessageBox.Show("Please fill data");
            }
            else
            {

                var success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("New contact Successfull insert");
                    Display();
                    Clear();
                }
                else
                {
                    MessageBox.Show("New contact Unsuccessfull insert");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.Number_Of_Working_Days = numericUpDown1.Value.ToString();


            String success = c.Update(c, id);
            if (success == "true")
            {
                MessageBox.Show("Cotact has been Successfull Update");
                Clear();
                Display();
            }
            else
            {
                MessageBox.Show(success);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.Number_Of_Working_Days = numericUpDown1.Value.ToString();
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
            numericUpDown1.Value = 0;
        }

       
    }
}
