using System;
using System.Data.OleDb;
using System.Drawing;
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

            if (!Validation.EmployeeName(txtName.Text))
            {
                lblNaam.ForeColor = Color.Red;
            }
            else
            {
                lblNaam.ForeColor = Color.Black;
            }

            if (!Validation.EmployeeSurname(txtSurname.Text))
            {
                lblSurname.ForeColor = Color.Red;
            }
            else
            {
                lblSurname.ForeColor = Color.Black;
            }
            var oleDbConnection = new OleDbConnection(Global.connString);
            if (Validation.EmployeeName(txtName.Text) && Validation.EmployeeSurname(txtSurname.Text))
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
            else
            {
                MessageBox.Show("Please enter values into all field", "Error in field", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}