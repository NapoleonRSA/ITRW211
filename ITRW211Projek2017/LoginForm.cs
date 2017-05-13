using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class LoginForm : Form
    {
        public OleDbConnection connect;

        public string DBFile;

        public LoginForm()
        {
            InitializeComponent();
            connect = new OleDbConnection(Global.connString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            var command =
                new OleDbCommand(
                    "SELECT * from Users where Employee_Id= '" + txtUsername.Text + "' AND Password= '" +
                    txtPasword.Text +
                    "'", connect);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.HasRows)
                {
                    Global.Name = reader["Employee_Name"].ToString();
                    Global.Admin = (bool) reader["Admin_rights"];

                    using (var userLogin = new StreamWriter(Global.userLoginInfoFile, true))
                    {
                        var time = DateTime.Now;
                        userLogin.WriteLine(Global.Name + " " + time.ToString("yyyy MMMM dd @ HH:mm:ss"));
                        var main = new HomePage();
                        main.Show();
                        Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect credentials.Please try again", "Error", MessageBoxButtons.OK);
                txtUsername.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtPasword.Clear();
        }
    }
}