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
    public partial class ShowfacultydetailsinSP : Form
    {
        public ShowfacultydetailsinSP()
        {
            InitializeComponent();
        }

        private void gunabtnFacultyRoomno_Click(object sender, EventArgs e)
        {
            FacultyRoomNoinSF facultyRoomNoinSF = new FacultyRoomNoinSF();
            facultyRoomNoinSF.Show();
            this.Hide();
        }

        private void gunabtnFacultyConsultingH_Click(object sender, EventArgs e)
        {
            FacultyConsultingTimeinSF facultyConsultingTimeinSF = new  FacultyConsultingTimeinSF();
            facultyConsultingTimeinSF.Show();
            this.Hide();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            StudentHomepage studentHomepage = new StudentHomepage();
            studentHomepage.Show();
            this.Hide();
        }
    }
}
