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
    public partial class UpdateStudentProfile : Form
    {
        public UpdateStudentProfile()
        {
            InitializeComponent();
        }

        private void gunabtnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBStudentinfo;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Update DBStudentinfo set Name = '" + gunatxtboxName.Text + "' , Sex= '" + gunatxtboxsex.Text + "', Department = '" + gunatxtboxdepname.Text + "',  [Total Credits]='" + gunatxtboxcomcreds.Text + "',  CGPA='" + gunatxtboxcgpa.Text + "', Nationality='" + gunatxtboxNationality.Text + "', Religion='" + gunatxtboxreligion.Text + "', [Marital Status]='" + gunatxtboxMstatus.Text + "', [Blood Group]='" + gunatxtboxbg.Text + "', [Admission Date]='" + gunatxtboxAddate.Text + "' where ID = '" + gunatxtboxid.Text + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your profile has been updated!");
            con.Close();
        }

        private void UpdateStudentProfile_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Studentinfo studentinfo = new Studentinfo();
            studentinfo.Show();
            this.Hide();
        }
    }
}
