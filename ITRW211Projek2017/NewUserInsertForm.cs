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
    public partial class NewUserInsertForm : Form
    {
        public string Naam { get; set; }
        public string Surname { get; set; }
        public NewUserInsertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName;
            string passWord;
            //int admin = 0;
            //if (rdbAdminYes.Checked)
            //{
            //     admin = -1 ;
            //}
            
            var oleDbConnection = new OleDbConnection(Global.connString);
            if (txtNaam.Text != "" && txtSurname.Text != "")
            {
                Naam = txtNaam.Text;
                Surname = txtSurname.Text;
                userName = Naam.Substring(0, 1) + Surname.Substring(0, 3);
                Random passRandom = new Random();
                passWord = (passRandom.Next(1000, 9000)).ToString();
                oleDbConnection.Open();
                var myCommand = new OleDbCommand();
                myCommand.Connection = oleDbConnection;
                myCommand.CommandText =
                    "INSERT INTO Users (Employee_Name,Employee_Surname,Employee_Id,Admin_rights) values('" +
                    Naam + "','"+Surname+"','"+userName+"',"+rdbAdminYes.Checked+")";

                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
                oleDbConnection.Close();

                Hide();
                AddandRemoveUser form = new AddandRemoveUser();
                form.Show();
            }
            else
                MessageBox.Show("Invalid fields", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewUserInsertForm_Load(object sender, EventArgs e)
        {

        }
    }
}
