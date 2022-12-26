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
    public partial class UpdateFacultyProfile : Form
    {
        public UpdateFacultyProfile()
        {
            InitializeComponent();
        }

        private void gunabtnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBFacultyinfo;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Update DBFacultyinfo set Name = '" + gunatxtboxName.Text + "' , Department = '" + gunatxtboxdepname.Text + "', Designation = '" + gunatxtboxpost.Text + "',  [Room Number]='" + gunatxtboxroomno.Text + "',  [Joining Date]='" + gunatxtboxjoindate.Text + "', [Blood Group]='" + gunatxtboxbg.Text + "', Sex='" + gunatxtboxsex.Text + "', Religion='" + gunatxtboxreligion.Text + "', [Marital Status]='" + gunatxtboxMstatus.Text + "', Nationality='" + gunatxtboxNationality.Text + "' where ID = '" + gunatxtboxid.Text + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your Faculty Profile has been updated!");
            con.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

            FacultyCreateProfileF1 facultyCreateProfileF1 = new FacultyCreateProfileF1();
            facultyCreateProfileF1.Show();
            this.Hide();
        }

        private void gunatxtboxNationality_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
