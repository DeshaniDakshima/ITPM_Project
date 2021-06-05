using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WD_R_14.LocationsClasses;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;
using SeriesChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace WD_R_14
{
    public partial class Statistics : Form
    {
        
        LocationClass c = new LocationClass();
        static string myconstrng = @"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            
            
        }

        private void chartRoom_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Count();
            chartRoom.Series["Series1"].XValueMember = "Location";
            chartRoom.Series["Series1"].YValueMembers = "countloc";
            chartRoom.Series["Series1"].ChartType = SeriesChartType.Pie;
            chartRoom.DataBind();
        }

        private DataTable NoRoomtxt_TextChanged(object sender, EventArgs e)
        {
            

            SqlConnection conn = new SqlConnection(myconstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT COUNT(LocationID) as countlLoc FROM tbl_Location";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void btnRooms_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=wdr-14.database.windows.net;Initial Catalog=wdr-14;User ID=it19149936;Password=16011999b@;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(LocationID) FROM tbl_location", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Series sr = new Series();
            while (reader.Read())
            {
                chartRoom.Series[0].Points.AddY(reader.GetInt32(0));

            }
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = @"Data Source=wdr-14.database.windows.net;Initial Catalog=wdr-14;User ID=it19149936;Password=16011999b@;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT (LocationID),BuildingName FROM tbl_location GROUP BY BuildingName", conn1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            Series sr1 = new Series();
            while (reader1.Read())
            {
                chartRoom1.Series[0].Points.AddY(reader1.GetInt32(0));

            }
        }
    }
}
