﻿namespace ProjectA
{
    partial class frmPersonInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPFName = new System.Windows.Forms.TextBox();
            this.txtPLname = new System.Windows.Forms.TextBox();
            this.txtPContact = new System.Windows.Forms.TextBox();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.dtPDoB = new System.Windows.Forms.DateTimePicker();
            this.cmdPGender = new System.Windows.Forms.ComboBox();
            this.PFname = new System.Windows.Forms.Label();
            this.PLname = new System.Windows.Forms.Label();
            this.PContact = new System.Windows.Forms.Label();
            this.PEmail = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblViewAll = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblAdvisor = new System.Windows.Forms.LinkLabel();
            this.lblProject = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtPFName
            // 
            this.txtPFName.Location = new System.Drawing.Point(397, 63);
            this.txtPFName.Name = "txtPFName";
            this.txtPFName.Size = new System.Drawing.Size(182, 20);
            this.txtPFName.TabIndex = 0;
            // 
            // txtPLname
            // 
            this.txtPLname.Location = new System.Drawing.Point(397, 108);
            this.txtPLname.Name = "txtPLname";
            this.txtPLname.Size = new System.Drawing.Size(182, 20);
            this.txtPLname.TabIndex = 1;
            // 
            // txtPContact
            // 
            this.txtPContact.Location = new System.Drawing.Point(397, 146);
            this.txtPContact.Name = "txtPContact";
            this.txtPContact.Size = new System.Drawing.Size(182, 20);
            this.txtPContact.TabIndex = 2;
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(397, 188);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(182, 20);
            this.txtPEmail.TabIndex = 3;
            // 
            // dtPDoB
            // 
            this.dtPDoB.Location = new System.Drawing.Point(397, 228);
            this.dtPDoB.Name = "dtPDoB";
            this.dtPDoB.Size = new System.Drawing.Size(182, 20);
            this.dtPDoB.TabIndex = 4;
            // 
            // cmdPGender
            // 
            this.cmdPGender.FormattingEnabled = true;
            this.cmdPGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmdPGender.Location = new System.Drawing.Point(397, 269);
            this.cmdPGender.Name = "cmdPGender";
            this.cmdPGender.Size = new System.Drawing.Size(182, 21);
            this.cmdPGender.TabIndex = 5;
            // 
            // PFname
            // 
            this.PFname.AutoSize = true;
            this.PFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFname.Location = new System.Drawing.Point(252, 66);
            this.PFname.Name = "PFname";
            this.PFname.Size = new System.Drawing.Size(83, 16);
            this.PFname.TabIndex = 6;
            this.PFname.Text = "First Name";
            // 
            // PLname
            // 
            this.PLname.AutoSize = true;
            this.PLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLname.Location = new System.Drawing.Point(251, 111);
            this.PLname.Name = "PLname";
            this.PLname.Size = new System.Drawing.Size(82, 16);
            this.PLname.TabIndex = 7;
            this.PLname.Text = "Last Name";
            // 
            // PContact
            // 
            this.PContact.AutoSize = true;
            this.PContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PContact.Location = new System.Drawing.Point(252, 149);
            this.PContact.Name = "PContact";
            this.PContact.Size = new System.Drawing.Size(113, 16);
            this.PContact.TabIndex = 8;
            this.PContact.Text = "Person Contact";
            // 
            // PEmail
            // 
            this.PEmail.AutoSize = true;
            this.PEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PEmail.Location = new System.Drawing.Point(252, 191);
            this.PEmail.Name = "PEmail";
            this.PEmail.Size = new System.Drawing.Size(109, 16);
            this.PEmail.TabIndex = 9;
            this.PEmail.Text = "Email Address";
            // 
            // txtDOB
            // 
            this.txtDOB.AutoSize = true;
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(252, 234);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(93, 16);
            this.txtDOB.TabIndex = 10;
            this.txtDOB.Text = "Date of Birth";
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(252, 272);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(59, 16);
            this.txtGender.TabIndex = 11;
            this.txtGender.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(480, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblViewAll
            // 
            this.lblViewAll.AutoSize = true;
            this.lblViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAll.Location = new System.Drawing.Point(12, 227);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(72, 20);
            this.lblViewAll.TabIndex = 13;
            this.lblViewAll.TabStop = true;
            this.lblViewAll.Text = "View All";
            this.lblViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewAll_LinkClicked);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(12, 63);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(56, 20);
            this.lblHome.TabIndex = 14;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "Home";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 104);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Group CreationDate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisor.Location = new System.Drawing.Point(12, 145);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(68, 20);
            this.lblAdvisor.TabIndex = 16;
            this.lblAdvisor.TabStop = true;
            this.lblAdvisor.Text = "Advisor";
            this.lblAdvisor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAdvisor_LinkClicked);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(12, 186);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(65, 20);
            this.lblProject.TabIndex = 17;
            this.lblProject.TabStop = true;
            this.lblProject.Text = "Project";
            this.lblProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProject_LinkClicked);
            // 
            // frmPersonInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 351);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblAdvisor);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.PEmail);
            this.Controls.Add(this.PContact);
            this.Controls.Add(this.PLname);
            this.Controls.Add(this.PFname);
            this.Controls.Add(this.cmdPGender);
            this.Controls.Add(this.dtPDoB);
            this.Controls.Add(this.txtPEmail);
            this.Controls.Add(this.txtPContact);
            this.Controls.Add(this.txtPLname);
            this.Controls.Add(this.txtPFName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPersonInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPFName;
        private System.Windows.Forms.TextBox txtPLname;
        private System.Windows.Forms.TextBox txtPContact;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.DateTimePicker dtPDoB;
        private System.Windows.Forms.ComboBox cmdPGender;
        private System.Windows.Forms.Label PFname;
        private System.Windows.Forms.Label PLname;
        private System.Windows.Forms.Label PContact;
        private System.Windows.Forms.Label PEmail;
        private System.Windows.Forms.Label txtDOB;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel lblViewAll;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblAdvisor;
        private System.Windows.Forms.LinkLabel lblProject;
    }
}

