using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccess
{
    public partial class FacultyCreateProfileF1 : Form
    {
        public FacultyCreateProfileF1()
        {
            InitializeComponent();
        }

        private void gunabtnFacultyprofilecreate_Click(object sender, EventArgs e)
        {
            CreatenewFacultyProfile createnewFacultyProfile = new CreatenewFacultyProfile();
            createnewFacultyProfile.Show();
            this.Hide();
        }

        private void gunabtnFacultyprofileUpdate_Click(object sender, EventArgs e)
        {
            UpdateFacultyProfile updateFacultyProfile=new UpdateFacultyProfile();
            updateFacultyProfile.Show();
            this.Hide();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            FacultyHomepage facultyHomepage = new FacultyHomepage();
            facultyHomepage.Show();
            this.Hide();
        }
    }
}
