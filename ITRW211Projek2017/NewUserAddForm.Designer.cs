﻿namespace ITRW211Projek2017
{
    partial class NewUserAddForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.rdbAdminYes = new System.Windows.Forms.RadioButton();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbAdminNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.images__1_;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(43, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(18, 27);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(41, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Name :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(16, 58);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname :";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(19, 93);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(70, 13);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "Admin RIghts";
            // 
            // rdbAdminYes
            // 
            this.rdbAdminYes.AutoSize = true;
            this.rdbAdminYes.Location = new System.Drawing.Point(134, 93);
            this.rdbAdminYes.Name = "rdbAdminYes";
            this.rdbAdminYes.Size = new System.Drawing.Size(43, 17);
            this.rdbAdminYes.TabIndex = 4;
            this.rdbAdminYes.TabStop = true;
            this.rdbAdminYes.Text = "Yes";
            this.rdbAdminYes.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(134, 58);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.images__1_;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(153, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbAdminNo
            // 
            this.rdbAdminNo.AutoSize = true;
            this.rdbAdminNo.Location = new System.Drawing.Point(195, 93);
            this.rdbAdminNo.Name = "rdbAdminNo";
            this.rdbAdminNo.Size = new System.Drawing.Size(39, 17);
            this.rdbAdminNo.TabIndex = 8;
            this.rdbAdminNo.TabStop = true;
            this.rdbAdminNo.Text = "No";
            this.rdbAdminNo.UseVisualStyleBackColor = true;
            // 
            // NewUserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(261, 179);
            this.Controls.Add(this.rdbAdminNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.rdbAdminYes);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnAdd);
            this.Name = "NewUserAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.RadioButton rdbAdminYes;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbAdminNo;
    }
}