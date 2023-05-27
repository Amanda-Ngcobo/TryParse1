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
    public partial class SupplierLogin : Form
    {
        public SupplierLogin()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            SupplierInterface si = new SupplierInterface();
            si.Show();
            this.WindowState = FormWindowState.Minimized;  //This code minimises the login form
        }
    }
}
