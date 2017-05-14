namespace ITRW211Projek2017
{
    partial class UpdateAndSave
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
            this.lblDiscription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.BackColor = System.Drawing.Color.White;
            this.lblDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDiscription.Location = new System.Drawing.Point(25, 40);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(114, 16);
            this.lblDiscription.TabIndex = 1;
            this.lblDiscription.Text = "Product Name :";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.White;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblCost.Location = new System.Drawing.Point(25, 87);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(47, 16);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost :";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.BackColor = System.Drawing.Color.White;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.LblQuantity.Location = new System.Drawing.Point(25, 142);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(72, 16);
            this.LblQuantity.TabIndex = 3;
            this.LblQuantity.Text = "Quantity :";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.White;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblCat.Location = new System.Drawing.Point(25, 192);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(75, 16);
            this.lblCat.TabIndex = 4;
            this.lblCat.Text = "Category:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.images__1_;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(94, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(156, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(244, 20);
            this.txtProductName.TabIndex = 8;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(156, 96);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(156, 142);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(156, 188);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.images__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(217, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UpdateAndSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(412, 329);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDiscription);
            this.Name = "UpdateAndSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateAndSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnClose;
    }
}