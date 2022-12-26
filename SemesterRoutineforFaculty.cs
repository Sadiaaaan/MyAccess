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
    public partial class SemesterRoutineforFaculty : Form
    {
        public SemesterRoutineforFaculty()
        {
            InitializeComponent();
        }

        private void gunabtnSemesterConsulting_Click(object sender, EventArgs e)
        {
            CreateSemesterConsultingTimeinFF createSemesterConsultingTimeinFF = new CreateSemesterConsultingTimeinFF();
            createSemesterConsultingTimeinFF.Show();
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
