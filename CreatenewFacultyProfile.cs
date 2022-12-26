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
    public partial class CreatenewFacultyProfile : Form
    {
        public CreatenewFacultyProfile()
        {
            InitializeComponent();
        }

        private void gunabtnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBFacultyinfo;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into DBFacultyinfo(Name, ID, Department, Designation,[Room Number], [Joining Date],[Blood Group], Sex,Religion, [Marital Status],Nationality) values('" + gunatxtboxName.Text + "', '" + gunatxtboxid.Text + "', '" + gunatxtboxdepname.Text + "', '" + gunatxtboxpost.Text + "', '" + gunatxtboxroomno.Text + "', '" + gunatxtboxjoindate.Text + "', '" + gunatxtboxbg.Text + "', '" + gunatxtboxsex.Text + "', '" + gunatxtboxreligion.Text + "', '" + gunatxtboxMstatus.Text + "', '" + gunatxtboxNationality.Text + "')", con);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Your Faculty profile has been created!");
            con.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            FacultyCreateProfileF1 facultyCreateProfileF1=new FacultyCreateProfileF1();
            facultyCreateProfileF1.Show();
            this.Hide();
        }
    }
}
