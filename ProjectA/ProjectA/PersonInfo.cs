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
    public partial class frmPersonInformation : Form
    {
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=ProjectA;Integrated Security=True";


        public frmPersonInformation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query;
                if (cmdPGender.Text == "MALE")
                {
                    query = "Insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender)Values('" + txtPFName.Text + "','" + txtPLname.Text.ToString() + "','" + txtPContact.Text.ToString() + "','" + txtPEmail.Text.ToString() + "','" + Convert.ToDateTime(dtPDoB.Value) + "','" + 1 + "')";
                }
                else
                {
                    query = "Insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender)Values('" + txtPFName.Text + "','" + txtPLname.Text.ToString() + "','" + txtPContact.Text.ToString() + "','" + txtPEmail.Text.ToString() + "','" + Convert.ToDateTime(dtPDoB.Value) + "','" + 2 + "')";
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

        private void lblViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form ViewAll = new frmViewAll();
            this.Hide();
            ViewAll.Show();
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
    }
}
