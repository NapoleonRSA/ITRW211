using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class Insertfrm : Form
    {
        public double insCost;
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
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var costValue = double.TryParse(txtCost.Text, out insCost);
            var quanValue = int.TryParse(txtQuantity.Text, out insQuantity);
            if (txtProduct.Text != "" && txtCost.Text != "" && txtQuantity.Text != "" &&
                txtCategory.Text != "")
                if (costValue && quanValue)
                {
                    insProduct = txtProduct.Text;
                    insCost = Convert.ToInt16(txtCost.Text);
                    insQuantity = Convert.ToInt16(txtQuantity.Text);
                    insCategory = txtCategory.Text;
                    var oleDbConnection = new OleDbConnection(Global.connString);
                    oleDbConnection.Open();
                    var insert = new OleDbCommand(
                        @"Insert Into Stock(Product,Cost,Quantity,Category)Values('" + insProduct + "'," +
                        insCost + "," + insQuantity + ",'" + insCategory + "')", oleDbConnection);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully");
                    oleDbConnection.Close();
                    var list = new ListandSearch();
                    Close();
                    list.Show();
                }
                else
                {
                    MessageBox.Show("Invalid fields", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCost.Clear();
                    txtQuantity.Clear();
                    txtCost.Focus();
                }
            else
                MessageBox.Show("Invalid fields", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}