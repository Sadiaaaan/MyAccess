using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyAccess
{
    public partial class ShowStudentProfile : Form
    {
        public string pressed_id;
        public ShowStudentProfile()
        {
            InitializeComponent();
        }

        private void ShowStudentProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBStudentinfoDataSet.DBStudentinfo' table. You can move, or remove it, as needed.
            //this.dBStudentinfoTableAdapter.Fill(this.dBStudentinfoDataSet.DBStudentinfo);

        }

        
        private void gunabtnpress_Click(object sender, EventArgs e)
        {
            pressed_id = gunatxtboxId.Text;
        }
        private void gunabtnshow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBStudentinfo;Integrated Security=True");

            con.Open();
                             
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from DBStudentinfo where ID= '" + pressed_id + "'", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            StudentHomepage studentHomepage = new StudentHomepage();
            studentHomepage.Show();
            this.Hide();
        }
    }
}
