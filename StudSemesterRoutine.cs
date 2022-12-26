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
    public partial class StudSemesterRoutine : Form
    {
        public StudSemesterRoutine()
        {
            InitializeComponent();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunabtnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBStudSemesterRoutine;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into DBStudSemesterRoutine(Saturday, Sunday, Monday,Tuesday, Wednesday, Thursday, Friday) values('" + gunatxtbox1.Text + "', '" + gunatxtbox2.Text + "', '" + gunatxtbox3.Text + "', '" + gunatxtbox4.Text + "', '" + gunatxtbox5.Text + "', '" + gunatxtbox6.Text + "', '" + gunatxtbox7.Text +  "')", con);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Your Semester Routine has been created!");
            con.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            SemesterRoutine semesterRoutine = new SemesterRoutine();
            semesterRoutine.Show();
            this.Hide();
        }
    }
}
