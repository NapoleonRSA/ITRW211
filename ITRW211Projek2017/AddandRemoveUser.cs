using System;
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
    public partial class AddandRemoveUser : Form
    {
        private OleDbConnection oleDbConnection;

        public AddandRemoveUser()
        {
            InitializeComponent();
            oleDbConnection = new OleDbConnection(Global.connString);
        }

        private void AddandRemoveUser_Load(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            var adpater = new OleDbDataAdapter(@"SELECT * FROM Users", oleDbConnection);
            var ds = new DataSet();
            adpater.Fill(ds, "User");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "User";
            oleDbConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var result = MessageBox.Show("Do you want to delete this user?", "Delete User",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var row = dataGridView1.SelectedRows[0];
                    var id = row.Cells["Id"].Value.ToString();

                    var oleDbConnection = new OleDbConnection(Global.connString);

                    var update = new OleDbCommand("DELETE FROM Users WHERE ID = " + id + "", oleDbConnection);

                    oleDbConnection.Open();

                    update.ExecuteNonQuery();
                    oleDbConnection.Close();

                    oleDbConnection.Open();
                    var adapt = new OleDbDataAdapter(
                        $@"SELECT * FROM Users WHERE EmployeeName LIKE '%{txtUserName.Text}%'",
                        oleDbConnection);
                    var dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    oleDbConnection.Close();
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            oleDbConnection.Open();

            var adapt = new OleDbDataAdapter($@"SELECT * FROM Users WHERE EmployeeName LIKE '%{txtUserName.Text}%'",
                oleDbConnection);
            var dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            oleDbConnection.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewUserAddForm insertUser = new NewUserAddForm();
            insertUser.Show();
            this.Hide();
        }
    }
}
