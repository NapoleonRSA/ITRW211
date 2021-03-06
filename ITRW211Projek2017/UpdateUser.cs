﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class UpdateUser : Form
    {
        private readonly OleDbConnection oleDbConnection;
        private readonly int userID;

        public UpdateUser(int userID)
        {
            this.userID = userID;
            InitializeComponent();
            oleDbConnection = new OleDbConnection(Global.connString);
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            txtName.Focus(); 
            oleDbConnection.Open();
            var adpater = new OleDbDataAdapter(@"SELECT * FROM Users WHERE ID =" + userID + "", oleDbConnection);
            var ds = new DataSet();
            adpater.Fill(ds, "List");
            var dTable = ds.Tables[0];
            foreach (DataRow dtRow in dTable.Rows)
            {
                txtName.Text = dtRow["Employee_Name"].ToString();
                txtSurname.Text = dtRow["Employee_Surname"].ToString();
                txtUsername.Text = dtRow["Employee_Id"].ToString();
                if ((bool) dtRow["Admin_rights"])
                    rdbAdminYes.Checked = true;
                else
                    rdbAdminNo.Checked = true;
                txtPassword.Text = dtRow["Employee_Password"].ToString();
            }
            oleDbConnection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var isAdmin = false;
            if (rdbAdminYes.Checked)
                isAdmin = true;
            if (txtName.Text != "" && txtSurname.Text != "")
            {
                oleDbConnection.Open();
                var myCommand = new OleDbCommand();
                myCommand.Connection = oleDbConnection;
                myCommand.CommandText = "Update Users set Employee_Name = '" + txtName.Text + "',Employee_Surname ='" +
                                        txtSurname.Text + "',Employee_Id = '" + txtUsername.Text
                                        + "',Admin_rights = " + isAdmin + ",Employee_Password ='"+txtPassword.Text+"' WHERE ID =" + userID + "";
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully","Database Updated",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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