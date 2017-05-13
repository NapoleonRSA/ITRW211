using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class NewUserAddForm : Form
    {
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
                var passRandom = new Random();
                var intpassWord = passRandom.Next(1000, 9000);
                passWord = Convert.ToString(intpassWord);
                oleDbConnection.Open();
                var myCommand = new OleDbCommand();
                myCommand.Connection = oleDbConnection;
                myCommand.CommandText =
                    "INSERT INTO Users (Employee_Name,Employee_Surname,Employee_Id,Password,Admin_rights) Values('" +
                    Naam + "','" + Surname + "','" + userName + "','" + passWord + "'" + rdbAdmin.Checked + ")";
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