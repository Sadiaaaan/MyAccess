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
    public partial class SemesterRoutine : Form
    {
        public SemesterRoutine()
        {
            InitializeComponent();
        }

        private void gunabtnroutinCreate_Click(object sender, EventArgs e)
        {
            StudSemesterRoutine studSemesterRoutine = new StudSemesterRoutine();
            studSemesterRoutine.Show();
            this.Hide();
        }

        private void gunabtnRoutineShow_Click(object sender, EventArgs e)
        {
            ShowSroutine showSroutine=new ShowSroutine();
            showSroutine.Show();
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
