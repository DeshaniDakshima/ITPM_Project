using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class SesionAndNotAvailableTime : Form
    {
        public SesionAndNotAvailableTime()
        {
            InitializeComponent();
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new formConsecutive());
            iconBtnConsecutive.BackColor = Color.FromArgb(204, 255, 255);
            iconBtnNonOverlapping.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNotAvailableTime.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnParallel.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void SesionAndNotAvailableTime_Load(object sender, EventArgs e)
        {
            iconBtnConsecutive.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNonOverlapping.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNotAvailableTime.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnParallel.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void iconBtnParallel_Click(object sender, EventArgs e)
        {
            openChildForm(new FormParallel());
            iconBtnConsecutive.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNonOverlapping.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNotAvailableTime.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnParallel.BackColor = Color.FromArgb(204, 255, 255);
        }

        private void iconBtnNonOverlapping_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNonOverlapping());
            iconBtnConsecutive.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNonOverlapping.BackColor = Color.FromArgb(204, 255, 255);
            iconBtnNotAvailableTime.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnParallel.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void iconBtnNotAvailableTime_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNotAvailableTime());
            iconBtnConsecutive.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNonOverlapping.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnNotAvailableTime.BackColor = Color.FromArgb(204, 255, 255);
            iconBtnParallel.BackColor = Color.FromArgb(77, 169, 255);
        }
    }
}
