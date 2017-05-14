using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class NewUserAddForm : Form
    {
        private readonly Random passRandom = new Random();

        public NewUserAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Naam, Surname, userName;
            int passWord;
            bool isAdmin = false;
            if (rdbAdminYes.Checked)
            {
                isAdmin = true;
            }
            else if (rdbAdminNo.Checked)
            {
                isAdmin = false;
            }
            var oleDbConnection = new OleDbConnection(Global.connString);
            if (txtName.Text != "" && txtSurname.Text != "")
            {
                Naam = txtName.Text;
                Surname = txtSurname.Text;
                userName = Naam.Substring(0, 1) + Surname.Substring(0, 3);
                passWord = passRandom.Next(1000, 9999);
                oleDbConnection.Open();
                var myCommand = new OleDbCommand();
                myCommand.Connection = oleDbConnection;
                myCommand.CommandText =
                    "INSERT INTO Users (Employee_Name,Employee_Surname,Employee_Id,Admin_rights,Employee_Password) Values ('" +
                    Naam + "','" + Surname + "','" + userName + "'," + isAdmin + ","+ passWord +")";
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully","Inserted Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
                oleDbConnection.Close();

                Hide();
                var form = new AddandRemoveUser();
                form.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}