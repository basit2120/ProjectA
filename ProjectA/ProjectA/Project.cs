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

namespace ProjectA
{
    public partial class Project : Form
    {
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=ProjectA;Integrated Security=True";

        public Project()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection s = new SqlConnection(conSt);
            s.Open();

            string q = "Insert into Project (Title, Description) " +
                "Values ('" + txtTitle.Text + "', '" + txtDescription.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(q, s);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Added to Database");

        }
    }
}
