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
    public partial class StudentHomepage : Form
    {
        public StudentHomepage()
        {
            InitializeComponent();
        }

        private void gunabtnCreateprofile_Click(object sender, EventArgs e)
        {
            Studentinfo studentinfo = new Studentinfo();
            studentinfo.Show();
            this.Hide();
        }

        private void gunabtnShowProfile_Click(object sender, EventArgs e)
        {
            ShowStudentProfile showStudentProfile = new ShowStudentProfile();
            showStudentProfile.Show();
            this.Hide();
        }

        private void gunabtnSemroutine_Click(object sender, EventArgs e)
        {
            SemesterRoutine semesterRoutine= new SemesterRoutine();
            semesterRoutine.Show();
            this.Hide();
        }

        private void gunabtnAIUBcontacts_Click(object sender, EventArgs e)
        {
            AIUBContacts aIUBContacts = new AIUBContacts();
            aIUBContacts.Show();
            this.Hide();
        }

        private void gunabtnFacultydetails_Click(object sender, EventArgs e)
        {
            ShowfacultydetailsinSP showfacultydetailsinSP = new ShowfacultydetailsinSP();
            showfacultydetailsinSP.Show();
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
