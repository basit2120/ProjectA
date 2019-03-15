﻿using System;
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
    public partial class Advisor : Form
    {
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=ProjectA;Integrated Security=True";

        public Advisor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query="";
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                if (cmbDesignation.Text == "Professor")
                {
                    query = "Insert into Advisor(Designation,Salary)Values('" + 6 + "','" + decimal.Parse(txtSalary.Text) + "')";
                }
                if (cmbDesignation.Text == "Associate Professor")
                {
                    query = "Insert into Advisor(Designation,Salary)Values('" + 7 + "','" + decimal.Parse(txtSalary.Text) + "')";
                }
                if (cmbDesignation.Text == "Assisstant Professor")
                {
                    query = "Insert into Advisor(Designation,Salary)Values('" + 8 + "','" + decimal.Parse(txtSalary.Text) + "')";
                }
                if (cmbDesignation.Text == "Lecturer")
                {
                    query = "Insert into Advisor(Designation,Salary)Values('" + 9 + "','" + decimal.Parse(txtSalary.Text) + "')";
                }
                if (cmbDesignation.Text == "Industry Professional")
                {
                    query = "Insert into Advisor(Designation,Salary)Values('" + 10 + "','" + decimal.Parse(txtSalary.Text) + "')";
                }

                SqlCommand cmd = new SqlCommand(query, con);
                try
                {

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("added in database");

                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString());
                }
            }
        }
    }
}
