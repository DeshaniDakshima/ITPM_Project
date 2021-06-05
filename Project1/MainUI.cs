using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WD_R_14;
using WorkingDaysAndHours;
using ITPM_Project;


namespace Project1
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelSubStudentMenu.Visible = false;
            panelSubSubjectAndLecturerMenu.Visible = false;
            panelSubWorkingDaysAndHours.Visible = false;
            panelSubLocationAndStatistics.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubStudentMenu.Visible == true)
                panelSubStudentMenu.Visible = false;
            if (panelSubSubjectAndLecturerMenu.Visible == true)
                panelSubSubjectAndLecturerMenu.Visible = false;
            if (panelSubWorkingDaysAndHours.Visible == true)
                panelSubWorkingDaysAndHours.Visible = false;
            if (panelSubLocationAndStatistics.Visible == true)
                panelSubLocationAndStatistics.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStudentGroup_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubStudentMenu);

            iconButton111.BackColor = Color.FromArgb(77, 169, 255); 
            btnStudentGroup.BackColor = Color.White;
            btnSubjectAndbtnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnWorkingDaysAndHours.BackColor = Color.FromArgb(77, 169, 255);
            btnLocationAndStatistics.BackColor = Color.FromArgb(77, 169, 255);
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void btnAddStudentGroup_Click(object sender, EventArgs e)
        {
            iconButton0.BackColor = Color.White;
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new AddStudentGroup());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.White;
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new StudentGroupList());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.White;
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new AddTags());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.White;
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new TagList());
        }

        private void btnSubjectAndbtnStudentGroup_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSubjectAndLecturerMenu);

            iconButton111.BackColor = Color.FromArgb(77, 169, 255); 
            btnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnSubjectAndbtnStudentGroup.BackColor = Color.White;
            btnWorkingDaysAndHours.BackColor = Color.FromArgb(77, 169, 255);
            btnLocationAndStatistics.BackColor = Color.FromArgb(77, 169, 255);
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            iconButton40.BackColor = Color.White;
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new AddSubject());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.White;
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new ManageSubject());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.White;
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new AddLecturer());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.White;
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new ManageLecturer());
        }

        private void btnLocationAndStatistics_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubLocationAndStatistics);
            btnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnSubjectAndbtnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnWorkingDaysAndHours.BackColor = Color.FromArgb(77, 169, 255);
            btnLocationAndStatistics.BackColor = Color.White;
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton111.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void btnWorkingDaysAndHours_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubWorkingDaysAndHours);

            iconButton111.BackColor = Color.FromArgb(77, 169, 255); 
            btnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnSubjectAndbtnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnWorkingDaysAndHours.BackColor = Color.White;
            btnLocationAndStatistics.BackColor = Color.FromArgb(77, 169, 255);
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

            iconButton111.BackColor = Color.FromArgb(77, 169, 255); 
            iconButton80.BackColor = Color.White;
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new Add_session_to_time_table());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            iconButton111.BackColor = Color.FromArgb(77, 169, 255); 
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.White;
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new Number_Of_Working_Days());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            iconButton111.BackColor = Color.FromArgb(77, 169, 255); 
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.White;
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new Working_Days());
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton111.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.White;
            openChildForm(new Working_Time());
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            iconButton120.BackColor = Color.White;
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new Add_Location());
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.White;
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new Manage_Locations());
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.White;
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new Statistics());
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.White;
            openChildForm(new Rooms());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new MainChild());
            panelSubStudentMenu.Visible = false;
            panelSubSubjectAndLecturerMenu.Visible = false;
            panelSubWorkingDaysAndHours.Visible = false;
            panelSubLocationAndStatistics.Visible = false;

            btnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnSubjectAndbtnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnWorkingDaysAndHours.BackColor = Color.FromArgb(77, 169, 255);
            btnLocationAndStatistics.BackColor = Color.FromArgb(77, 169, 255);
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton4.BackColor = Color.White;
            openChildForm(new SesionAndNotAvailableTime());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void iconButton71_Click(object sender, EventArgs e)
        {
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.White;
            iconButton72.BackColor = Color.FromArgb(77, 169, 255);
            openChildForm(new AddSession());
        }

        private void iconButton72_Click(object sender, EventArgs e)
        {
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton71.BackColor = Color.FromArgb(77, 169, 255);
            iconButton72.BackColor = Color.White;
            openChildForm(new ManageSession());
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TableGenerate());
            panelSubStudentMenu.Visible = false;
            panelSubSubjectAndLecturerMenu.Visible = false;
            panelSubWorkingDaysAndHours.Visible = false;
            panelSubLocationAndStatistics.Visible = false;

            btnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnSubjectAndbtnStudentGroup.BackColor = Color.FromArgb(77, 169, 255);
            btnWorkingDaysAndHours.BackColor = Color.FromArgb(77, 169, 255);
            btnLocationAndStatistics.BackColor = Color.FromArgb(77, 169, 255);
            iconButton0.BackColor = Color.FromArgb(77, 169, 255);
            iconButton1.BackColor = Color.FromArgb(77, 169, 255);
            iconButton2.BackColor = Color.FromArgb(77, 169, 255);
            iconButton3.BackColor = Color.FromArgb(77, 169, 255);
            iconButton40.BackColor = Color.FromArgb(77, 169, 255);
            iconButton50.BackColor = Color.FromArgb(77, 169, 255);
            iconButton60.BackColor = Color.FromArgb(77, 169, 255);
            iconButton70.BackColor = Color.FromArgb(77, 169, 255);
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            iconButton120.BackColor = Color.FromArgb(77, 169, 255);
            iconButton13.BackColor = Color.FromArgb(77, 169, 255);
            iconButton14.BackColor = Color.FromArgb(77, 169, 255);
            iconButton15.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click_2(object sender, EventArgs e)
        {
            openChildForm(new AddLoc());
            iconButton80.BackColor = Color.FromArgb(77, 169, 255);
            iconButton90.BackColor = Color.FromArgb(77, 169, 255);
            iconButton100.BackColor = Color.FromArgb(77, 169, 255);
            iconButton110.BackColor = Color.FromArgb(77, 169, 255);
            iconButton111.BackColor = Color.White;
        }
    }
}
