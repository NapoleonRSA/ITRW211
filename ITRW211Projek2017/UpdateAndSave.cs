using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class UpdateAndSave : Form
    {
        private readonly LoginForm frm1;
        private readonly HomePage home;
        private readonly OleDbConnection myDb;
        public int productId;


        public UpdateAndSave(HomePage hp, LoginForm f1)
        {
            home = hp;
            frm1 = f1;
            myDb = new OleDbConnection(Global.connString);
            InitializeComponent();
        }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        public string Product { get; set; }

        public short Id { get; set; }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtIdUpdate.Text != "")
            {
                productId = Convert.ToInt16(txtIdUpdate.Text);
                myDb.Open();
                var adpater =
                    new OleDbDataAdapter(@"SELECT * FROM Stock WHERE ID =" + txtIdUpdate.Text + "", myDb);
                var dtSet = new DataSet();
                adpater.Fill(dtSet, "List");
                var dTable = dtSet.Tables[0];
                foreach (DataRow dtRow in dTable.Rows)
                {
                    txtProductName.Text = dtRow["Product"].ToString();
                    txtCost.Text = dtRow["Cost"].ToString();
                    txtQuantity.Text = dtRow["Quantity"].ToString();
                    txtCategory.Text = dtRow["Category"].ToString();
                }
                myDb.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid Product Id.", "No Product Selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


            txtIdUpdate.Enabled = false;
            txtProductName.Enabled = true;
            txtCost.Enabled = true;
            txtQuantity.Enabled = true;
            txtCategory.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt16(txtIdUpdate.Text);
            Product = txtProductName.Text;
            Cost = double.Parse(txtCost.Text);
            Quantity = int.Parse(txtQuantity.Text);
            Category = txtCategory.Text;
            UpdateProduct(); // roep die method hier
            Close();
        }

        private void UpdateAndSave_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        public void UpdateProduct()
        {
            var update = new OleDbCommand("UPDATE Stock  SET Product = '" + Product +
                                          "', Cost = '" + Cost + "', Quantity = '" + Quantity + "', Category = '" +
                                          Category + "' WHERE ID = " + Id + "", myDb);

            myDb.Open();

            update.ExecuteNonQuery();

            myDb.Close();
        }
    }
}