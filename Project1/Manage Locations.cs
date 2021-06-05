using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using WD_R_14.LocationsClasses;

namespace WD_R_14
{
    public partial class Manage_Locations : Form
    {
        public Manage_Locations()
        {
            InitializeComponent();
        }

        LocationClass c = new LocationClass();


        private void back_btn_Click(object sender, EventArgs e)
        {
           
        }




        //Load Data on Data Gridview
        private void Manage_Locations_Load(object sender, EventArgs e)
        {
           
            DataTable dt = c.Select();
            Location_dataGridView.DataSource = dt;
        }



        private void Location_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtLocID.Text = Location_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            buildingtxt.Text = Location_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            room_cmb.Text = Location_dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Roomtxt.Text = Location_dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            Capacity_cmb.Text = Location_dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get data from database
            c.LocationID = int.Parse(txtLocID.Text);
            c.RoomName = room_cmb.Text;
            c.BuildingName = buildingtxt.Text;
            c.RoomType = Roomtxt.Text;
            c.Capacity = Capacity_cmb.Text;

            //update data in database
            bool success = c.Update(c);
            if (success == true)
            {
                //update successfuly
                MessageBox.Show("Location has been successfuly updated");
                DataTable dt = c.Select();
                Location_dataGridView.DataSource = dt;
            }
            else
            {
                //update unsuccessfuly
                MessageBox.Show("Failed to Update Location. Try Again");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.LocationID = Convert.ToInt32(txtLocID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Location has been successfuly Deleted");
                DataTable dt = c.Select();
                Location_dataGridView.DataSource = dt;

            }
            else
            {
                //update unsuccessfuly
                MessageBox.Show("Failed to Delete Location. Try Again");
            }
        }
    }
}
