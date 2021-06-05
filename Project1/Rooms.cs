using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WD_R_14
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        private void btnlectuer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Lecturer Rl = new Room_Lecturer();
            Rl.ShowDialog();
        }

        private void btngroup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Group Rg = new Room_Group();
            Rg.ShowDialog();
        }

        private void btnsession_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Session Rs = new Room_Session();
            Rs.ShowDialog();
        }

        private void btncs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Consecutive_Sessions Rns = new Room_Consecutive_Sessions();
            Rns.ShowDialog();
        }

        private void btnnrt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Non_Reservable_Time_for_a_Room Rnt = new Non_Reservable_Time_for_a_Room();
            Rnt.ShowDialog();
        }

        private void btnTag_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rooms_Tag Rt = new Rooms_Tag();
            Rt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            openChildForm(new Rooms_Tag());
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
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnsubj_Click(object sender, EventArgs e)
        {
            openChildForm(new Rooms_Subject_and_Tag());
        }

        private void btnlectuer_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Room_Lecturer());
        }

        private void btngroup_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Room_Group());
        }

        private void btnsession_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Room_Session());
        }

        private void btncs_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Room_Consecutive_Sessions());
        }

        private void btnnrt_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Non_Reservable_Time_for_a_Room());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }
    }
}
