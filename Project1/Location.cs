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
using PagedList;

namespace Project1
{
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        string con = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private void Location_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);  //Connect to DB
            string sql = "select * from tbl_location";
            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataReader LecturerRead;

            try
            {
                conn.Open();
                LecturerRead = cmd.ExecuteReader();

                while (LecturerRead.Read())
                {
                    string FirstName = LecturerRead["BuildingName"].ToString();
                    string LastName = LecturerRead["RoomName"].ToString();

                    cmdLecturer1.Items.Add(" " + FirstName + "  " + LastName);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            dataGridView.Columns.Add("Column", "");
            dataGridView.Columns.Add("Column", "Monday");
            dataGridView.Columns.Add("Column", "Tuesday");
            dataGridView.Columns.Add("Column", "Wednesday");
            dataGridView.Columns.Add("Column", "Thursday");
            dataGridView.Columns.Add("Column", "Friday");
            dataGridView.Columns.Add("Column", "Saturday");
            dataGridView.Columns.Add("Column", "Sunday");
            dataGridView.Columns.Add("Column", "");

            dataGridView.Rows.Add("7.30 - 8.30");
            dataGridView.Rows.Add("8.30 - 9.30");
            dataGridView.Rows.Add("9.30 - 10.30");
            dataGridView.Rows.Add("10.30 - 11.30");
            dataGridView.Rows.Add("11.30 - 12.30");
            dataGridView.Rows.Add("12.30 - 13.30");
            dataGridView.Rows.Add("13.30 - 14.30");
            dataGridView.Rows.Add("14.30 - 15.30");
            dataGridView.Rows.Add("15.30 - 16.30");
            dataGridView.Rows.Add("16.30 - 17.30");

        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printBitmap = new Bitmap(this.dataGridView.Width, this.dataGridView.Height);
            dataGridView.DrawToBitmap(printBitmap, new Rectangle(0,0,this.dataGridView.Width, this.dataGridView.Height));
            e.Graphics.DrawImage(printBitmap, 0, 0);
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog();
            dialog.Document = printDocument1;

            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //printDocument1.DocumentName = "File Name";

                printDocument1.Print();
            }
        }
    }
}
