using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class ListandSearch : Form
    {
        private readonly Form1 myForm1 = new Form1();
        public OleDbConnection connect;
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

            var adapt = new OleDbDataAdapter($@"SELECT * FROM Stock WHERE Product LIKE '%{txtSearch.Text}%'",
                connect);
            var dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    DBFile = openFileDialog1.FileName;
            //}
            //connect = new OleDbConnection(connString + DBFile);
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
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this product?","Delete Product",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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
                }

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inForm = new Insertfrm();
            inForm.Show();
            Close();
        }
    }
}