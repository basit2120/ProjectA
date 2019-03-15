namespace ProjectA
{
    partial class Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.LinkLabel();
            this.lblAdvisor = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.lblViewAll = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(390, 63);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(390, 109);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(26, 178);
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
            this.lblAdvisor.Location = new System.Drawing.Point(26, 136);
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
            this.linkLabel1.Location = new System.Drawing.Point(26, 103);
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
            this.lblHome.Location = new System.Drawing.Point(26, 57);
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
            this.lblViewAll.Location = new System.Drawing.Point(26, 220);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(72, 20);
            this.lblViewAll.TabIndex = 22;
            this.lblViewAll.TabStop = true;
            this.lblViewAll.Text = "View All";
            this.lblViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewAll_LinkClicked);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 297);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblAdvisor);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lblProject;
        private System.Windows.Forms.LinkLabel lblAdvisor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel lblViewAll;
    }
}