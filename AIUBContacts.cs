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
    public partial class AIUBContacts : Form
    {
        public AIUBContacts()
        {
            InitializeComponent();
        }

        private void AIUBContacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBAIUBContactsDataSet.DBAIUBContacts' table. You can move, or remove it, as needed.
            //this.dBAIUBContactsTableAdapter.Fill(this.dBAIUBContactsDataSet.DBAIUBContacts);

        }

        private void gunabtnshowaiubinfo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBAIUBContacts;Integrated Security=True");

            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from DBAIUBContacts", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void gunabtnsearchinfo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NF2JQDUU;Initial Catalog=DBAIUBContacts;Integrated Security=True");

            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from DBAIUBContacts where [Faculty/ Department Designation]= '" + gunatxtboxsearchinfo.Text + "'", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
