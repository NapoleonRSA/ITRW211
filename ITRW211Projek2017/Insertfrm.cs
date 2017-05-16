using System;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ITRW211Projek2017
{
    public partial class Insertfrm : Form
    {
        public int insId, insQuantity;
        public string insProduct, insCategory;

        public Insertfrm()
        {
            InitializeComponent();
        }

        private void Insertfrm_Load(object sender, EventArgs e)
        {
            txtProduct.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var inForm = new ListandSearch();
            inForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation.ProductName(txtProduct.Text))
            {
                lblProduct.ForeColor = Color.Red;
            }
            else
            {
                lblProduct.ForeColor = Color.Black;
            }


            if (!Validation.Cost(txtCost.Text))
            {
                lblCost.ForeColor = Color.Red;
            }
            else
            {
                lblCost.ForeColor = Color.Black;
            }

            if (!Validation.Quantity(txtQuantity.Text))
            {
                lblQuantity.ForeColor = Color.Red;
            }
            else
            {
                lblQuantity.ForeColor = Color.Black;
            }
            if (!Validation.CategoryName(txtCategory.Text))
            {
                lblCategory.ForeColor = Color.Red;
            }
            else
            {
                lblCategory.ForeColor = Color.Black;
            }

            if (Validation.ProductName(txtProduct.Text) && Validation.Cost(txtCost.Text) &&
                Validation.Quantity(txtQuantity.Text) &&
                Validation.CategoryName(txtCategory.Text))
            {
                if (Validation.Cost(txtCost.Text) && Validation.Quantity(txtQuantity.Text))
                {
                    insProduct = txtProduct.Text;
                    insQuantity = Convert.ToInt16(txtQuantity.Text);
                    insCategory = txtCategory.Text;
                    double insCost = Convert.ToDouble(txtCost.Text.Replace('.',','));
                    
                    var oleDbConnection = new OleDbConnection(Global.connString);
                    oleDbConnection.Open();
                    var insert = new OleDbCommand(
                        @"Insert Into Stock(Product,Cost,Quantity,Category)Values('" + insProduct + "','" +
                        insCost + "'," + insQuantity + ",'" + insCategory + "')",
                        oleDbConnection);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully", "Database Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    oleDbConnection.Close();
                    var list = new ListandSearch();
                    Close();
                    list.Show();
                }
                else
                {
                    MessageBox.Show("Invalid field", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCost.Clear();
                    txtQuantity.Clear();
                    txtCost.Focus();
                }
            }
            else
                MessageBox.Show("Invalid fields", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}