namespace ITRW211Projek2017
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAndRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programDescritionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legalNoticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listProductsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            //this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // listProductsToolStripMenuItem
            // 
            this.listProductsToolStripMenuItem.Name = "listProductsToolStripMenuItem";
            this.listProductsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listProductsToolStripMenuItem.Text = "List";
            this.listProductsToolStripMenuItem.Click += new System.EventHandler(this.listProductsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reportToolStripMenuItem.Text = "Low Stock Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem,
            this.openInvoiceToolStripMenuItem});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.checkOutToolStripMenuItem.Text = "Check out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // openInvoiceToolStripMenuItem
            // 
            this.openInvoiceToolStripMenuItem.Name = "openInvoiceToolStripMenuItem";
            this.openInvoiceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openInvoiceToolStripMenuItem.Text = "Open Invoice";
            this.openInvoiceToolStripMenuItem.Click += new System.EventHandler(this.openInvoiceToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAndRemoveToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addAndRemoveToolStripMenuItem
            // 
            this.addAndRemoveToolStripMenuItem.Name = "addAndRemoveToolStripMenuItem";
            this.addAndRemoveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addAndRemoveToolStripMenuItem.Text = "Add and Remove";
            this.addAndRemoveToolStripMenuItem.Click += new System.EventHandler(this.addAndRemoveToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programDescritionToolStripMenuItem,
            this.legalNoticeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // programDescritionToolStripMenuItem
            // 
            this.programDescritionToolStripMenuItem.Name = "programDescritionToolStripMenuItem";
            this.programDescritionToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.programDescritionToolStripMenuItem.Text = "About";
            this.programDescritionToolStripMenuItem.Click += new System.EventHandler(this.programDescritionToolStripMenuItem_Click);
            // 
            // legalNoticeToolStripMenuItem
            // 
            this.legalNoticeToolStripMenuItem.Name = "legalNoticeToolStripMenuItem";
            this.legalNoticeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.legalNoticeToolStripMenuItem.Text = "Legal Notice";
            this.legalNoticeToolStripMenuItem.Click += new System.EventHandler(this.legalNoticeToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITRW211Projek2017.Properties.Resources.db9b953f_f88f_48eb_8f78_37ed5da358f3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(434, 375);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programDescritionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legalNoticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAndRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInvoiceToolStripMenuItem;
    }
}