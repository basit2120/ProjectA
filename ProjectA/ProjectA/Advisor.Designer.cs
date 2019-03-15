namespace ProjectA
{
    partial class Advisor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.LinkLabel();
            this.lblAdvisor = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.lblViewAll = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.cmbDesignation.Location = new System.Drawing.Point(333, 77);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(121, 21);
            this.cmbDesignation.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(333, 138);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 20);
            this.txtSalary.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(370, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(12, 189);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(65, 20);
            this.lblProject.TabIndex = 21;
            this.lblProject.TabStop = true;
            this.lblProject.Text = "Project";
            this.lblProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProject_LinkClicked);
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisor.Location = new System.Drawing.Point(12, 147);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(68, 20);
            this.lblAdvisor.TabIndex = 20;
            this.lblAdvisor.TabStop = true;
            this.lblAdvisor.Text = "Advisor";
            this.lblAdvisor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAdvisor_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 114);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Group CreationDate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(12, 68);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(56, 20);
            this.lblHome.TabIndex = 18;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "Home";
            this.lblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHome_LinkClicked);
            // 
            // lblViewAll
            // 
            this.lblViewAll.AutoSize = true;
            this.lblViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAll.Location = new System.Drawing.Point(12, 233);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(72, 20);
            this.lblViewAll.TabIndex = 22;
            this.lblViewAll.TabStop = true;
            this.lblViewAll.Text = "View All";
            this.lblViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewAll_LinkClicked);
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 286);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblAdvisor);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Advisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel lblProject;
        private System.Windows.Forms.LinkLabel lblAdvisor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel lblViewAll;
    }
}