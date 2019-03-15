using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class frmViewAll : Form
    {
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
    }
}
