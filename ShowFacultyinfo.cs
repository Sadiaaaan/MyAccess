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
    public partial class ShowFacultyinfo : Form
    {
        public string pressed_id;
        public ShowFacultyinfo()
        {
            InitializeComponent();
        }

        private void ShowFacultyinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBFacultyinfoDataSet.DBFacultyinfo' table. You can move, or remove it, as needed.
            //this.dBFacultyinfoTableAdapter.Fill(this.dBFacultyinfoDataSet.DBFacultyinfo);

        }

        private void gunabtnpress_Click(object sender, EventArgs e)
        {
            pressed_id = gunatxtboxId.Text;
        }

        private void gunatxtboxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunabtnshow_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBFacultyinfo;Integrated Security=True");

            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from DBFacultyinfo where ID= '" + pressed_id + "'", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void gunalblId_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            FacultyHomepage facultyHomepage = new FacultyHomepage();
            facultyHomepage.Show();
            this.Hide();
        }
    }
}
