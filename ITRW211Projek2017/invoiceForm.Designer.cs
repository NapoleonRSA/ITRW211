namespace ITRW211Projek2017
{
    partial class invoiceForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ltbInvoice = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.images__1_;
            this.btnOpen.Location = new System.Drawing.Point(18, 311);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 42);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.images__1_;
            this.btnCancel.Location = new System.Drawing.Point(178, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 42);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ltbInvoice
            // 
            this.ltbInvoice.FormattingEnabled = true;
            this.ltbInvoice.Location = new System.Drawing.Point(18, 19);
            this.ltbInvoice.Name = "ltbInvoice";
            this.ltbInvoice.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ltbInvoice.Size = new System.Drawing.Size(244, 277);
            this.ltbInvoice.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(277, 365);
            this.Controls.Add(this.ltbInvoice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpen);
            this.Name = "invoiceForm";
            this.Text = "Invoice View Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox ltbInvoice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}