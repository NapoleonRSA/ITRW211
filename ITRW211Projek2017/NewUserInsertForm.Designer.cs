namespace ITRW211Projek2017
{
    partial class NewUserInsertForm
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblVan = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdbAdminYes = new System.Windows.Forms.RadioButton();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(33, 23);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(41, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Name :";
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(33, 63);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(55, 13);
            this.lblVan.TabIndex = 1;
            this.lblVan.Text = "Surname :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbAdminYes
            // 
            this.rdbAdminYes.AutoSize = true;
            this.rdbAdminYes.Location = new System.Drawing.Point(126, 99);
            this.rdbAdminYes.Name = "rdbAdminYes";
            this.rdbAdminYes.Size = new System.Drawing.Size(62, 17);
            this.rdbAdminYes.TabIndex = 4;
            this.rdbAdminYes.TabStop = true;
            this.rdbAdminYes.Text = "Yes/No";
            this.rdbAdminYes.UseVisualStyleBackColor = true;
            this.rdbAdminYes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Location = new System.Drawing.Point(33, 99);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(75, 13);
            this.lblIsAdmin.TabIndex = 5;
            this.lblIsAdmin.Text = "Admin Rights :";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(109, 20);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(126, 20);
            this.txtNaam.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(109, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(126, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // NewUserInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(259, 194);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblIsAdmin);
            this.Controls.Add(this.rdbAdminYes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.lblNaam);
            this.Name = "NewUserInsertForm";
            this.Text = "NewUserInsertForm";
            this.Load += new System.EventHandler(this.NewUserInsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbAdminYes;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtSurname;
    }
}