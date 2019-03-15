namespace ProjectA
{
    partial class AddGroup
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
            this.dtGrpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.LinkLabel();
            this.lblAdvisor = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.lblViewAll = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dtGrpCreationDate
            // 
            this.dtGrpCreationDate.Location = new System.Drawing.Point(351, 101);
            this.dtGrpCreationDate.Name = "dtGrpCreationDate";
            this.dtGrpCreationDate.Size = new System.Drawing.Size(200, 20);
            this.dtGrpCreationDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Date";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(471, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Assign Student";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(12, 183);
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
            this.lblAdvisor.Location = new System.Drawing.Point(12, 141);
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
            this.linkLabel1.Location = new System.Drawing.Point(12, 108);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Group CreationDate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(12, 62);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(56, 20);
            this.lblHome.TabIndex = 18;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "Home";
            this.lblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHome_LinkClicked_1);
            // 
            // lblViewAll
            // 
            this.lblViewAll.AutoSize = true;
            this.lblViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAll.Location = new System.Drawing.Point(12, 224);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(72, 20);
            this.lblViewAll.TabIndex = 22;
            this.lblViewAll.TabStop = true;
            this.lblViewAll.Text = "View All";
            this.lblViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewAll_LinkClicked);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 311);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblAdvisor);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrpCreationDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtGrpCreationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lblProject;
        private System.Windows.Forms.LinkLabel lblAdvisor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel lblViewAll;
    }
}