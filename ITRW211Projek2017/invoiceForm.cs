using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRW211Projek2017
{
    public partial class invoiceForm : Form
    {
        public invoiceForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string info;
            openFileDialog1.InitialDirectory = Global.invoiceLocation;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader invoiceRead = new StreamReader(openFileDialog1.FileName))
                {
                    while ((info = invoiceRead.ReadLine()) != null)
                    {
                        ltbInvoice.Items.Add(info);
                    }
                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
