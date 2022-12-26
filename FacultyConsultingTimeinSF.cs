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
    public partial class FacultyConsultingTimeinSF : Form
    {
        public string pressed_id;
        public FacultyConsultingTimeinSF()
        {
            InitializeComponent();
        }

        private void gunabtnpress_Click(object sender, EventArgs e)
        {
            pressed_id = gunatxtboxId.Text;

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBFacultyConsulting;Integrated Security=True");

            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from DBFacultyConsulting where ID= '" + pressed_id + "'", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void FacultyConsultingTimeinSF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBFacultyConsultingDataSet.DBFacultyConsulting' table. You can move, or remove it, as needed.
            this.dBFacultyConsultingTableAdapter.Fill(this.dBFacultyConsultingDataSet.DBFacultyConsulting);

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            ShowfacultydetailsinSP showfacultydetailsinSP=new ShowfacultydetailsinSP();
            showfacultydetailsinSP.Show();
            this.Hide();
        }
    }
}
