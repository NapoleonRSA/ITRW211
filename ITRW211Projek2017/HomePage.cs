using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class HomePage : Form
    {
        private readonly LoginForm hForm1 = new LoginForm();
        public double Cost;
        public int Id, Quantity;
        private OleDbConnection oleDbConnection;
        public string Product, Category;

        public HomePage()
        {
            InitializeComponent();
            oleDbConnection = new OleDbConnection(Global.connString);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (Global.Admin != true)
            {
                productsToolStripMenuItem.Visible = false;
                usersToolStripMenuItem.Visible = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listfrm = new ListandSearch();
            listfrm.MdiParent = this;
            listfrm.StartPosition = FormStartPosition.CenterScreen;
            listfrm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updateProduct = new UpdateAndSave(this, hForm1);
            updateProduct.StartPosition = FormStartPosition.CenterScreen;
            updateProduct.MdiParent = this;
            updateProduct.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            userForm.StartPosition = FormStartPosition.CenterScreen;
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hForm1.Show();
            Close();
        }

        private void addAndRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userAdd = new AddandRemoveUser();
            userAdd.StartPosition = FormStartPosition.CenterScreen;
            userAdd.MdiParent = this;
            userAdd.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReport stockReportForm = new StockReport();
            stockReportForm.StartPosition = FormStartPosition.CenterScreen;
            stockReportForm.MdiParent = this;
            stockReportForm.Show();
        }

        private void programDescritionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0-2017\rCreated by Developers\rJaco A Vos & Danie J Schwartz ");
        }

        private void legalNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All product names, logos, and brands are property of their respective owners. " +
                            "All company, product and service names used in this website are for identification" +
                            " purposes only. Use of these names, logos, and brands does not imply endorsement.",
                "Legal",
                MessageBoxButtons.OK);
        }
    }
}