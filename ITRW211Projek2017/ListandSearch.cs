﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class ListandSearch : Form
    {
        private readonly LoginForm myForm1 = new LoginForm();
        public OleDbConnection connect;
        private int productId;


        public string DBFile;

        public ListandSearch()
        {
            InitializeComponent();
            connect = new OleDbConnection(Global.connString);
        }

        public string SearchData { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connect.Open();

            var adapt = new OleDbDataAdapter($@"SELECT * FROM Stock WHERE Product LIKE '%{txtSearch.Text}%' OR Category LIKE '%{txtSearch.Text}%'",
                myForm1.connect);
            var dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ListandSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();

            dataGridView1.Visible = true;

            myForm1.connect.Open();
            var adpater = new OleDbDataAdapter(@"SELECT * FROM Stock", myForm1.connect);
            var ds = new DataSet();
            adpater.Fill(ds, "Stock");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Stock";
            myForm1.connect.Close();
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var result = MessageBox.Show("Do you want to delete this product?", "Delete Product",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var row = dataGridView1.SelectedRows[0];
                    var id = row.Cells["Id"].Value.ToString();

                    var oleDbConnection = new OleDbConnection(Global.connString);

                    var update = new OleDbCommand("DELETE FROM Stock WHERE ID = " + id + "", oleDbConnection);

                    oleDbConnection.Open();

                    update.ExecuteNonQuery();
                    oleDbConnection.Close();

                    oleDbConnection.Open();
                    var adapt = new OleDbDataAdapter($@"SELECT * FROM Stock WHERE Product LIKE '%{txtSearch.Text}%'",
                        oleDbConnection);
                    var dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    oleDbConnection.Close();
                    var list = new ListandSearch();
                    Close();
                    list.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inForm = new Insertfrm();
            inForm.Show();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var row = dataGridView1.SelectedRows[0];
                productId = Convert.ToInt32(row.Cells["ID"].Value);
                var updateForm = new UpdateAndSave(productId);
                updateForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Please Select user to Update", "Select Error", MessageBoxButtons.OK);
            }
        }
    }
}