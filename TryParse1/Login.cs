using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryParse1
{
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointOfSale m = new PointOfSale();
            m.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {    
            //Opens the login form for supplier
            SupplierLogin Supplier = new SupplierLogin();
            Supplier.Show();

            // Login form is hidden when Supplier login is opened
             this.Hide();
           // this.WindowState = FormWindowState.Minimized;  //This code minimises the login form
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
