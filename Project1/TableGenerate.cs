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
    public partial class TableGenerate : Form
    {
        public TableGenerate()
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


        private void TableGenerate_Load_1(object sender, EventArgs e)
        {

        }

        private void iconLecturer_Click(object sender, EventArgs e)
        {
            openChildForm(new Lectuere());
            iconLecturer.BackColor = Color.FromArgb(204, 255, 255);
            iconBtnLocation.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnStudet.BackColor = Color.FromArgb(77, 169, 255);
        }

        private void iconBtnStudet_Click(object sender, EventArgs e)
        {
            openChildForm(new Student());
            iconLecturer.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnLocation.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnStudet.BackColor = Color.FromArgb(204, 255, 255);
        }

        private void iconBtnLocation_Click(object sender, EventArgs e)
        {
            openChildForm(new Location());
            iconLecturer.BackColor = Color.FromArgb(77, 169, 255);
            iconBtnLocation.BackColor = Color.FromArgb(204, 255, 255);
            iconBtnStudet.BackColor = Color.FromArgb(77, 169, 255);
        }
    }
}
