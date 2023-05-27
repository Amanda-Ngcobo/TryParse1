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
    public partial class PointOfSale : Form
    {
        public PointOfSale()
        {
            InitializeComponent();
            // WindowState = FormWindowState.Maximized; 
        }

        private void CusSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            cusTableAdapter2.FillByCustPhoneNo(groupWst8DataSet.Cus, CusSearchTxtBox.Text);

            /* cus1TableAdapter.FillByPhoneNmbr(groupWst8DataSet.Cus1, CusSearchTxtBox.Text);
            
            // enables the Add Customer Button if there are no customer matches according to the customer search
            if (dataGridView1 != null)
            {
                AddCusBtn.Enabled = false;
            }
            else
            {
                AddCusBtn.Enabled = true;
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst8DataSet.CusSaleDetail' table. You can move, or remove it, as needed.
            this.cusSaleDetailTableAdapter.Fill(this.groupWst8DataSet.CusSaleDetail);
            // TODO: This line of code loads data into the 'groupWst8DataSet.Prod' table. You can move, or remove it, as needed.
            this.cusTableAdapter1.Fill(this.groupWst8DataSet.Cus);

            // TODO: This line of code loads data into the 'groupWst8DataSet.Prod' table. You can move, or remove it, as needed.
            this.prodTableAdapter.Fill(this.groupWst8DataSet.Prod);

            // TimeLabel.Text = DateTime.Now.ToString();
            //TimeLabel.Text = CurrentDateTime.ToString(); 
            timer1.Start();
            comboBox1.SelectedIndex = -1;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();


            /*Code to filter search by customer Type
             if (comboBox1.Items.Count > 1)
            {
                cusTableAdapter.FillByCusType(groupWst8DataSet.Cus, comboBox1.Text);
            }*/


        }


        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //When a row is double clicked, the sales tab will open
            tabControl1.SelectedIndex = 1;

            /*DataRow dr;
            dr = groupWst8DataSet.Cus.NewRow(); 

           for (int i =0; i< dr.ItemArray.Length; i++)
            {
                dr[i] = dataGridView1.CurrentRow.Cells[i].Value; 
            }
             //dataGridView2.ClearSelection(); clears the selection before adding
            groupWst8DataSet.Cus.Rows.Add(dr);*/


        }

        private void EditCusBtn_Click(object sender, EventArgs e)
        {
            /* EditCusGroupBox.Enabled = true;
             dataGridView2.Enabled = true;

             /*DataRow dr;
             dr = groupWst8DataSet.Cus.NewRow();

             dr[1] = dataGridView1.CurrentRow.Cells[1].Value;
             dr[2] = dataGridView1.CurrentRow.Cells[2].Value;
             dr[3] = dataGridView1.CurrentRow.Cells[3].Value;
             dr[4] = dataGridView1.CurrentRow.Cells[4].Value;
             dr[5] = dataGridView1.CurrentRow.Cells[5].Value;

             groupWst8DataSet.Cus.Rows.Add(dr);*/
        }

        private void AddCusBtn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProdSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            //prodTableAdapter.FillByProdName(groupWst8DataSet.Prod, ProdSearchTxtBox.Text); 
        }

        private void MenuDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Displays the sale records of the selected customer
            cusSaleTableAdapter2.FillByCustID(groupWst8DataSet.CusSale, (int)dataGridView1.CurrentRow.Cells[0].Value);
            //TimeLabel.Text = DateTime.Now.ToString();
            // CustLabel.Text = "ORDER FOR:  " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //Displays the selected customer's name and surname on the Order GroupBox's text field
            CusOrderGroupBox.Text = "ORDER FOR:  " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tabControl1.SelectedIndex = 1;
        }

        private void ViewCusRecBtn_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogOuT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out? You will have to log in again to uilise these resources.", "Confirm log out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CashPaymBtn_Click(object sender, EventArgs e)
        {
            /*  DialogResult dialogResult = MessageBox.Show("Confirm Order to " + CusOrderGroupBox.Text + " for an amount of " + TotalTxtBox.Text, "Order Confirmation", MessageBoxButtons.YesNo);
              if (dialogResult == DialogResult.Yes)
              {
                  /*cusSaleTableAdapter1.Insert(decimal.Parse(TotalTxtBox.Text), int.Parse(CusGroupBox.Text), DateTime.Now, null);
                  cusSaleTableAdapter1.FillByCustID(groupWst8DataSet, (int)dataGridView1.CurrentRow.Cells[0].Value); 
              }
              else if (dialogResult == DialogResult.No)
              {
                  dataGridView3.Rows.Clear();
                  TotalTxtBox.Text = ""; 
              }*/
        }
    }
}
