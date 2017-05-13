using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class NewUserAddForm : Form
    {
        Random passRandom = new Random();

        public NewUserAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Naam, Surname, userName;
            string passWord;
            var oleDbConnection = new OleDbConnection(Global.connString);
            if (txtName.Text != "" && txtSurname.Text != "")
            {
                Naam = txtName.Text;
                Surname = txtSurname.Text;
                userName = Naam.Substring(0, 1) + Surname.Substring(0, 3);
                passWord = Convert.ToString(passRandom.Next(1000,9999));
                oleDbConnection.Open();
                var myCommand = new OleDbCommand();
                myCommand.Connection = oleDbConnection;
                myCommand.CommandText = "INSERT INTO Users(Password) VALUES(" + passWord + ")";
                //myCommand.CommandText =
                //    "INSERT INTO Users (Employee_Name,Employee_Surname,Employee_Id,Admin_rights) Values('" +
                //    Naam + "','" + Surname + "','" + userName + "'," + rdbAdmin.Checked + ")";
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
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