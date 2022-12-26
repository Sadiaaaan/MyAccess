﻿using System;
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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void gunabtnAdministration_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            LoginPage loginPage1 = new LoginPage("Administration");
            loginPage1.Show();
            this.Hide();
           
        }

        private void gunabtnFaculty_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            LoginPage loginPage1 = new LoginPage("Faculty");
            loginPage1.Show();
            this.Hide();
            
        }

        private void gunabtnStudent_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            LoginPage loginPage1 = new LoginPage("Student");
            loginPage1.Show();
            this.Hide();
            
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
