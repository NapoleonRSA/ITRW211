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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAndSave));
            this.lblId = new System.Windows.Forms.Label();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(25, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Product  ID :";
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.BackColor = System.Drawing.Color.White;
            this.lblDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDiscription.Location = new System.Drawing.Point(36, 97);
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
            this.lblCost.Location = new System.Drawing.Point(60, 144);
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
            this.LblQuantity.Location = new System.Drawing.Point(36, 186);
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
            this.lblCat.Location = new System.Drawing.Point(36, 227);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(75, 16);
            this.lblCat.TabIndex = 4;
            this.lblCat.Text = "Category:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnFind.Location = new System.Drawing.Point(70, 296);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 35);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(174, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(123, 46);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(75, 20);
            this.txtIdUpdate.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(156, 97);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(244, 20);
            this.txtProductName.TabIndex = 8;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(123, 140);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(123, 186);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(123, 227);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 11;
            // 
            // UpdateAndSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(412, 354);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtIdUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDiscription);
            this.Controls.Add(this.lblId);
            this.Name = "UpdateAndSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateAndSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCategory;
    }
}