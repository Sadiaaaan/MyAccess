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
    public partial class LoginPage : Form
    {
        private string type; //Encapsulation
        public LoginPage()
        {
            InitializeComponent();
        }

        public LoginPage(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        
        private void gunaLinklblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if(type == "Administration")
            {
                SignUp signUp = new SignUp();
                SignUp signUp1 = new SignUp("Administration");
                signUp1.Show();
                this.Hide();
               

            }
            else if(type == "Faculty")
            {
                SignUp signUp = new SignUp();
                SignUp signUp1 = new SignUp("Faculty");
                signUp1.Show();
                this.Hide();
                

            }
            else
            {
                SignUp signUp = new SignUp();
                SignUp signUp1 = new SignUp("Student");
                signUp1.Show();
                this.Hide();
                
            }
        }

        private void gunabtnLogin_Click(object sender, EventArgs e)
        {
            if (type == "Administration")
            {


                string Username = gunaTxtBoxUsername.Text;
                string Password = gunaTxtBoxPassword.Text;

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBAdminSignup;Integrated Security=True");

                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("select * from DBAdminSignup  where [Username(ID)]='" + gunaTxtBoxUsername.Text + "' and  Password='" + gunaTxtBoxPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Username = gunaTxtBoxUsername.Text;
                        Password = gunaTxtBoxPassword.Text;

                        StudentHomepage studentHomepage = new StudentHomepage();
                        studentHomepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account! Please Signup First.");
                        gunaTxtBoxUsername.Clear();
                        gunaTxtBoxPassword.Clear();

                        gunaTxtBoxUsername.Focus();

                    }

                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }

            }
            else if (type == "Faculty")
            {

                string Username = gunaTxtBoxUsername.Text;
                string Password = gunaTxtBoxPassword.Text;

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBFacultySignup;Integrated Security=True");

                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("select * from DBFacultySignup  where [Username(ID)]='" + gunaTxtBoxUsername.Text + "' and  Password='" + gunaTxtBoxPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Username = gunaTxtBoxUsername.Text;
                        Password = gunaTxtBoxPassword.Text;

                        FacultyHomepage facultyHomepage = new FacultyHomepage();
                        facultyHomepage.Show();
                        this.Hide();
                        

                    }
                    else
                    {
                        MessageBox.Show("Invalid Account! Please Signup First.");
                        gunaTxtBoxUsername.Clear();
                        gunaTxtBoxPassword.Clear();

                        gunaTxtBoxUsername.Focus();

                    }

                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }


            }
            else
            {
                string Username = gunaTxtBoxUsername.Text;
                string Password = gunaTxtBoxPassword.Text;

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBStudentSignup;Integrated Security=True");

                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("select * from DBStudentSignup  where [Username(ID)]='" + gunaTxtBoxUsername.Text + "' and  Password='" + gunaTxtBoxPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        Username = gunaTxtBoxUsername.Text;
                        Password = gunaTxtBoxPassword.Text;

                        StudentHomepage studentHomepage = new StudentHomepage();
                        studentHomepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account! Please Signup First.");
                        gunaTxtBoxUsername.Clear();
                        gunaTxtBoxPassword.Clear();

                        gunaTxtBoxUsername.Focus();

                    }

                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
                

            }
            

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
        {
            WelcomePage welcome=new WelcomePage();
            welcome.Show();
            this.Hide();


        }
    }
}
