using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ITRW211Projek2017.Models;

namespace ITRW211Projek2017
{
    public partial class UserForm : Form
    {
        private readonly OleDbConnection myDB;
        private readonly LoginForm myForm1 = new LoginForm();
        private readonly Random myRandom = new Random();
        private readonly List<Stock> userChart = new List<Stock>();
        private string InvoiceNumber = "";

        private double totalExcl;

        public UserForm()
        {
            InitializeComponent();
            myDB = new OleDbConnection(Global.connString);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            myForm1.connect.Open();
            var adpater = new OleDbDataAdapter(@"SELECT * FROM Stock WHERE Quantity > 0", myForm1.connect);
            var ds = new DataSet();
            adpater.Fill(ds, "Stock");
            dgProducts.DataSource = ds;
            dgProducts.DataMember = "Stock";
            myForm1.connect.Close();
            btnBuy.Enabled = false;
            btnDeleteCart.Enabled = false;

            InvoiceNumber = myRandom.Next(0, 1000).ToString();
            lblInvoiceNumber.Text = InvoiceNumber;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            myDB.Open();
            var adapt = new OleDbDataAdapter(
                $@"SELECT * FROM Stock WHERE Product LIKE '%{txtSearch.Text}%' AND Quantity > 0", myDB);
            var dt = new DataTable();
            adapt.Fill(dt);
            dgProducts.DataSource = dt;
            myDB.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgProducts.SelectedRows.Count != 0)
            {
                var row = dgProducts.SelectedRows[0];

                if (userChart.Count == 0)
                {
                    var stock = new Stock
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        Product = row.Cells["Product"].Value.ToString(),
                        Quantity = 1,
                        Cost = Convert.ToDouble(row.Cells["Cost"].Value),
                        Category = row.Cells["Category"].Value.ToString()
                    };
                    totalExcl += Convert.ToDouble(row.Cells["Cost"].Value);
                    userChart.Add(stock);
                }
                else
                {
                    var result = userChart.Any(product => product.Product == row.Cells["Product"].Value.ToString());
                    if (result)
                    {
                        foreach (var stock in userChart)
                            if (stock.Product == row.Cells["Product"].Value.ToString() &&
                                Convert.ToInt32(row.Cells["Quantity"].Value) > 0 &&
                                Convert.ToInt32(row.Cells["Quantity"].Value) > stock.Quantity)
                            {
                                if (stock.Product == row.Cells["Product"].Value.ToString())
                                    stock.Quantity++;
                                totalExcl += Convert.ToDouble(row.Cells["Cost"].Value);
                            }
                    }
                    else
                    {
                        if (Convert.ToInt32(row.Cells["Quantity"].Value) > 0)
                        {
                            var newStock = new Stock
                            {
                                Id = Convert.ToInt32(row.Cells["Id"].Value),
                                Product = row.Cells["Product"].Value.ToString(),
                                Quantity = 1,
                                Cost = Convert.ToDouble(row.Cells["Cost"].Value),
                                Category = row.Cells["Category"].Value.ToString()
                            };
                            totalExcl += Convert.ToDouble(row.Cells["Cost"].Value);
                            userChart.Add(newStock);
                        }
                    }
                }
                var BindingList = new BindingList<Stock>(userChart);
                var source = new BindingSource(BindingList, null);
                dgChart.DataSource = source;
                btnBuy.Enabled = true;
                btnDeleteCart.Enabled = true;
            }

            lblPrice.Text = string.Format("{0:c}", totalExcl);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            Hide();
            userForm.Show();
            userForm.StartPosition = FormStartPosition.Manual;
            userForm.Top = (Screen.PrimaryScreen.Bounds.Height - userForm.Height) / 2;
            userForm.Left = (Screen.PrimaryScreen.Bounds.Width - userForm.Width) / 2;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (var stock in userChart)
            {
                var update = new OleDbCommand(
                    "UPDATE Stock  SET Quantity = Quantity-'" + stock.Quantity + "' WHERE ID = " + stock.Id + "", myDB);

                myDB.Open();

                update.ExecuteNonQuery();

                myDB.Close();
            }

            using (var writer = new StreamWriter(Global.invoiceLocation + "\\Invoice-" + InvoiceNumber + ".txt"))
            {
                writer.Write("Invoice Number: " + InvoiceNumber);
                writer.Write("\n**************************\n");
                foreach (var stock in userChart)
                {
                    writer.Write("Product: " + stock.Product + "\r");
                    writer.Write("Category: " + stock.Category + "\r");
                    writer.Write("Quantity: " + stock.Quantity + "\r");
                    writer.Write("Total Cost: $" + stock.Cost * stock.Quantity + "\r");
                    writer.Write("\r");
                }
                writer.Write("\r**************************");
                writer.Write("\rTotal $" + totalExcl);
                writer.Write("\r**************************");
            }
            Process.Start("wordpad", Global.invoiceLocation + "\\Invoice-" + InvoiceNumber + ".txt");


            userChart.Clear();
            var BindingList = new BindingList<Stock>(userChart);
            var source = new BindingSource(BindingList, null);
            dgChart.DataSource = source;

            lblPrice.Text = string.Format("{0:c}", 0.00);

            myForm1.connect.Open();
            var adpater = new OleDbDataAdapter(@"SELECT * FROM Stock WHERE Quantity >0", myForm1.connect);
            var ds = new DataSet();
            adpater.Fill(ds, "Stock");
            dgProducts.DataSource = ds;
            dgProducts.DataMember = "Stock";
            myForm1.connect.Close();
            totalExcl = 0;
            InvoiceNumber = myRandom.Next(0, 1000).ToString();
            lblInvoiceNumber.Text = InvoiceNumber;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgChart.SelectedRows.Count != 0)
            {
                var row = dgChart.SelectedRows[0];

                var stockToRemove = new Stock();
                var moreThanOneProduct = userChart.Any(
                    product => product.Product == row.Cells["Product"].Value.ToString() && product.Quantity > 1);

                if (moreThanOneProduct)
                {
                    foreach (var stock in userChart)
                        if (stock.Product == row.Cells["Product"].Value.ToString())
                        {
                            stock.Quantity--;
                            totalExcl -= Convert.ToDouble(stock.Cost);
                        }
                }
                else
                {
                    foreach (var stock in userChart)
                        if (stock.Product == row.Cells["Product"].Value.ToString())
                        {
                            stockToRemove = stock;
                            totalExcl -= Convert.ToDouble(stock.Cost);
                        }
                    userChart.Remove(stockToRemove);
                }

                var BindingList = new BindingList<Stock>(userChart);
                var source = new BindingSource(BindingList, null);
                dgChart.DataSource = source;

                lblPrice.Text = string.Format("{0:c}", totalExcl);
            }
        }
    }
}