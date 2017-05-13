﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class StockReport : Form
    {
        private OleDbConnection connect;
        public StockReport()
        {
            InitializeComponent();
            connect = new OleDbConnection(Global.connString);
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            connect.Open();
            var adpater = new OleDbDataAdapter(@"SELECT * FROM Stock WHERE Quantity < 5", connect);
            var ds = new DataSet();
            adpater.Fill(ds, "Stock");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Stock";
            connect.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
