﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class UpdateAndSave : Form
    {
        private readonly OleDbConnection myDb;
        public int productId;


        public UpdateAndSave(int prodId)
        {
            myDb = new OleDbConnection(Global.connString);
            InitializeComponent();
            productId = prodId;
        }

        public UpdateAndSave()
        {
            throw new NotImplementedException();
        }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        public string Product { get; set; }

        public short Id { get; set; }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "" && txtCost.Text != "" && txtCategory.Text != "" && txtQuantity.Text != "")
            {
                Product = txtProductName.Text;
                Cost = double.Parse(txtCost.Text.Replace('.',','));
                Quantity = int.Parse(txtQuantity.Text);
                Category = txtCategory.Text;
                UpdateProduct(); // roep die method hier
                Close();

                ListandSearch listandSearch = new ListandSearch();
                listandSearch.Show();
            }
            else
            {
                MessageBox.Show("Please enter values into all field", "Missing Entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void UpdateAndSave_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            myDb.Open();
            var adpater =
                new OleDbDataAdapter(@"SELECT * FROM Stock WHERE ID =" + productId + "", myDb);
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

        public void UpdateProduct()
        {
            var update = new OleDbCommand("UPDATE Stock  SET Product = '" + Product +
                                          "', Cost = '" + Cost + "', Quantity = '" + Quantity + "', Category = '" +
                                          Category + "' WHERE ID = " + productId + "", myDb);
            try
            {
                myDb.Open();
                update.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with updating product" + e.Message, "Failed Update", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                myDb.Close();
            }

            MessageBox.Show("Product Updated", "Update", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            ListandSearch listandSearch = new ListandSearch();
            listandSearch.Show();
        }
    }
}