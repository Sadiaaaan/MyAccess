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
    public partial class SignUp : Form
    {
       public string type;
        public SignUp()
        {
            InitializeComponent();
        }
        public SignUp(string type)
        {
            InitializeComponent();
            this.type = type; 
        }

        private void gunalblPassword_Click(object sender, EventArgs e)
        {

        }

        private void gunabtnsignup_Click(object sender, EventArgs e)
        {
            if (type == "Administration")
            {

                if (gunatxtboxpass.Text != gunatxtboxconfirmpass.Text)
                {
                    MessageBox.Show("Password does not match!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBAdminSignup;Integrated Security=True");

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Insert into DBAdminSignup(Name,[Username(ID)], Password) values('" + gunatxtboxname.Text + "', '" + gunatxtboxuserame.Text + "','" + gunatxtboxpass.Text + "')", conn);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data added to Admin DataHub!");
                    conn.Close();
                }
            }

            else if (type == "Faculty")
            {

                if (gunatxtboxpass.Text != gunatxtboxconfirmpass.Text)
                {
                    MessageBox.Show("Password does not match!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBFacultySignup;Integrated Security=True");

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Insert into DBFacultySignup(Name,[Username(ID)], Password) values('" + gunatxtboxname.Text + "', '" + gunatxtboxuserame.Text + "','" + gunatxtboxpass.Text + "')", conn);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data added to FacultyHub!");
                    conn.Close();
                }
            }

            else if(type == "Student")
            {
                if (gunatxtboxpass.Text != gunatxtboxconfirmpass.Text)
                {
                    MessageBox.Show("Password does not match!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBStudentSignup;Integrated Security=True");

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Insert into DBStudentSignup(Name,[Username(ID)], Password) values('" + gunatxtboxname.Text + "', '" + gunatxtboxuserame.Text + "','" + gunatxtboxpass.Text + "')", conn);
                    cmd.ExecuteNonQuery();  //


                    MessageBox.Show("Data added to StudentHud!");
                    conn.Close();

                }


            }

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            LoginPage login=new LoginPage();
            login.Show();
            this.Hide();

        }
    }
}
