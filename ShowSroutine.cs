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
    public partial class ShowSroutine : Form
    {
        public ShowSroutine()
        {
            InitializeComponent();
        }

        private void ShowSroutine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBStudSemesterRoutineDataSet.DBStudSemesteRroutine' table. You can move, or remove it, as needed.
            //this.dBStudSemesteRroutineTableAdapter.Fill(this.dBStudSemesterRoutineDataSet.DBStudSemesteRroutine);

        }

        
    private void gunabtnShowroutine_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBStudSemesterRoutine;Integrated Security=True");

            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from DBStudSemesterRoutine", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
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
