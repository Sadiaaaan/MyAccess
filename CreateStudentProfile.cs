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
    public partial class CreateStudentProfile : Form
    {
        public CreateStudentProfile()
        {
            InitializeComponent();
        }

        private void gunabtnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBStudentinfo;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into DBStudentinfo(Name, ID, Sex, Department, [Total Credits], CGPA, Nationality, Religion, [Marital Status], [Blood Group], [Admission Date]) values('" + gunatxtboxName.Text + "', '" + gunatxtboxid.Text + "', '" + gunatxtboxsex.Text + "', '" + gunatxtboxdepname.Text + "', '" + gunatxtboxcomcreds.Text + "', '" + gunatxtboxcgpa.Text + "', '" + gunatxtboxNationality.Text + "', '" + gunatxtboxreligion.Text + "', '" + gunatxtboxMstatus.Text + "', '" + gunatxtboxbg.Text + "', '" + gunatxtboxAddate.Text + "')", con);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Your Student profile has been created!");
            con.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Studentinfo studentinfo = new Studentinfo();    
            studentinfo.Show();
            this.Hide();
        }
    }
}
