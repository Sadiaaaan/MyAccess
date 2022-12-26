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
    public partial class FacultyHomepage : Form
    {
        public FacultyHomepage()
        {
            InitializeComponent();
        }

        private void gunabtnCreateprofile_Click(object sender, EventArgs e)
        {
            FacultyCreateProfileF1 facultyCreateProfileF1 = new FacultyCreateProfileF1();
            facultyCreateProfileF1.Show();
            this.Hide();
        }

        private void gunabtnShowProfile_Click(object sender, EventArgs e)
        {
            ShowFacultyinfo showFacultyinfo = new ShowFacultyinfo();    
            showFacultyinfo.Show();
            this.Hide();
        }

        private void gunabtnAIUBcontacts_Click(object sender, EventArgs e)
        {
            AIUBContacts aIUBContacts = new AIUBContacts();
            aIUBContacts.Show();
            this.Hide();
        }

        private void gunabtnStudentdetails_Click(object sender, EventArgs e)
        {
            ShowStudentProfile showStudentProfile=new ShowStudentProfile();
            showStudentProfile.Show();
            this.Hide();
        }

        private void gunabtnSemroutine_Click(object sender, EventArgs e)
        {
            SemesterRoutineforFaculty semesterRoutineforFaculty=new SemesterRoutineforFaculty();
            semesterRoutineforFaculty.Show();
            this.Hide();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }
    }
}
