using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccess
{
    public partial class Studentinfo : Form
    {
        public Studentinfo()
        {
            InitializeComponent();
        }

        private void gunabtnStudprofilecreate_Click(object sender, EventArgs e)
        {
            CreateStudentProfile createStudentProfile=new CreateStudentProfile();
            createStudentProfile.Show();
            this.Hide();
        }

        private void gunabtnStudprofileUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudentProfile updateStudentProfile=new UpdateStudentProfile();   
            updateStudentProfile.Show();
            this.Hide();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            StudentHomepage studentHomepage=new StudentHomepage();  
            studentHomepage.Show();
            this.Hide();
        }
    }
}
