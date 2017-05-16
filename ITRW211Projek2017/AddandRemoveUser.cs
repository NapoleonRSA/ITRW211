using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class AddandRemoveUser : Form
    {
        private readonly OleDbConnection oleDbConnection;
        public int userID;

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
                    var addRemoveAndUpdate = new AddandRemoveUser();
                    Close();
                    addRemoveAndUpdate.Show();

                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            oleDbConnection.Open();

            var adapt = new OleDbDataAdapter($@"SELECT * FROM Users WHERE Employee_Name LIKE '%{txtUserName.Text}%' OR Employee_Surname LIKE '%{txtUserName.Text}%'",
                oleDbConnection);
            var dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            oleDbConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var insertUser = new NewUserAddForm();
            insertUser.Show();
            Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var row = dataGridView1.SelectedRows[0];
                userID = Convert.ToInt32(row.Cells["ID"].Value);
                var updateForm = new UpdateUser(userID);
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