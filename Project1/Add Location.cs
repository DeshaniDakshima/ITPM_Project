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
    public partial class Add_Location : Form
    {
        public Add_Location()
        {
            InitializeComponent();
        }

        LocationClass c = new LocationClass();


        private void btnClear_Click(object sender, EventArgs e)
        {
           ClearLocationData();
        }


        
        private void ClearLocationData()
        {
            building_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
            Capacity_cmb.SelectedIndex = -1;
            roomtype_cmb.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if ((building_cmb.Text != string.Empty) && (room_cmb.Text != string.Empty) && (Capacity_cmb.Text != string.Empty)
                && (roomtype_cmb.Text != string.Empty))

            {
                c.BuildingName = building_cmb.Text.ToString();
                c.RoomName = room_cmb.Text.ToString();
                c.RoomType = roomtype_cmb.Text.ToString();
                c.Capacity = Capacity_cmb.Text.ToString();

                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("Location Added!", "Location Add Successful");

                    ClearLocationData();
                }

            }
            else
            {
                MessageBox.Show("All fields must be filled. Try Again.", "Location Add Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearLocationData();
        }

        private void Add_Location_Load(object sender, EventArgs e)
        {

        }
    }

}
