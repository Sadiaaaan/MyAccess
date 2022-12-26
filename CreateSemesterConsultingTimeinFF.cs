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
    public partial class CreateSemesterConsultingTimeinFF : Form
    {
        public CreateSemesterConsultingTimeinFF()
        {
            InitializeComponent();
        }

        private void gunabtnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBFacultyConsulting;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into DBFacultyConsulting(Name, ID,[Consulting Session 1],[Consulting Session 2],[Consulting Session 3],[Consulting Session 4]) values('" + gunatxtboxName.Text + "', '" + gunatxtboxid.Text + "','" + gunatxtbox1.Text + "', '" + gunatxtbox2.Text + "', '" + gunatxtbox3.Text + "', '" + gunatxtbox4.Text +  "')", con);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Your Semester Consulting Session has been created!");
            con.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            SemesterRoutineforFaculty semesterRoutineforFaculty = new SemesterRoutineforFaculty();
            semesterRoutineforFaculty.Show();
            this.Hide();
        }
    }
}
