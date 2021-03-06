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
    public partial class AddGroup : Form
    {
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=ProjectA;Integrated Security=True";

        public AddGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string Insert = "INSERT INTO [dbo].[Group](Created_On) VALUES ('" + Convert.ToDateTime(dtGrpCreationDate.Value) + "')";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Date Added");

            }
        }

        private void lblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInformation frmPerson = new frmPersonInformation();
            this.Hide();
            frmPerson.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void lblHome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInformation frmPerson = new frmPersonInformation();
            this.Hide();
            frmPerson.Show();
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

        private void lblViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form ViewAll = new frmViewAll();
            this.Hide();
            ViewAll.Show();
        }
    }
}
