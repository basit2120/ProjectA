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

namespace ProjectA
{
    public partial class frmViewAll : Form
    {
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=ProjectA;Integrated Security=True";


        public frmViewAll()
        {
            InitializeComponent();
        }

        private void lblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form p = new frmPersonInformation();
            this.Hide();
            p.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInformation frmPerson = new frmPersonInformation();
            this.Hide();
            frmPerson.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            this.Hide();
            addGroup.Show();
        }

        private void lblAdvisor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Advisor advisor = new Advisor();
            this.Hide();
            advisor.Show();
        }

        private void lblProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Project project = new Project();
            this.Hide();
            project.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmViewAll_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string show = "select * from Person";
                DataTable table = new DataTable();
                SqlDataAdapter dat = new SqlDataAdapter(show, con);
                dat.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
    }
}
