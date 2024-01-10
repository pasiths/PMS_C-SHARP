using PhamicySysytem.BLL;
using PhamicySysytem.DAL;
using PharmacySystem.BLL;
using PharmacySystem.DAL;
using PharmacySystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace PharmacySystem
{
    public partial class Form1 : Form
    {
        transactionDAL tdal = new transactionDAL();
        transctionsBLL t = new transctionsBLL();
        userDAL udal = new userDAL();
        transactionDetailsBLL td = new transactionDetailsBLL();
        stockDAL sdal = new stockDAL();
        transactionDetailsDAL tddal = new transactionDetailsDAL();

        DataTable transactionDT = new DataTable();

        int p_id = 0;
        decimal total = 0;


        public Form1()
        {
            InitializeComponent();
            this.dgvAddedProducts.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvStock.DefaultCellStyle.ForeColor = Color.Black;

            dgvHead();
        }

        private void dgvHead()
        {
            transactionDT.Columns.Add("ID");
            transactionDT.Columns.Add("Medicine Name");
            transactionDT.Columns.Add("Price");
            transactionDT.Columns.Add("Qty");
            transactionDT.Columns.Add("Total");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            if (txtCustomerName.Text == "" || total == 0)
            {
                return;
            }
            else
            {
                
                try
                {
                    DateTime dateTime = DateTime.Now;

                    t.c_name = txtCustomerName.Text;
                    t.total = total;
                    t.added_date = dateTime;
                    string username = FormLogIn.loggedIn;
                    userBLL u = udal.GetIDFromUsername(username);

                    t.added_by = u.id;
                    t.transactionDetails = transactionDT;
                    bool success = false;

                    using (TransactionScope scope = new TransactionScope())
                    {
                        int transactionID = 0;

                        bool w = tdal.Insert_Transaction(t, out transactionID);

                        for (int i = 0; i < transactionDT.Rows.Count; i++)
                        {
                            td.p_id = int.Parse(transactionDT.Rows[i][0].ToString());
                            td.price = decimal.Parse(transactionDT.Rows[i][2].ToString());
                            td.qty = int.Parse(transactionDT.Rows[i][3].ToString());
                            td.total = decimal.Parse(transactionDT.Rows[i][4].ToString());

                            td.c_id = transactionID;

                            td.added_by = u.id;
                            td.added_date = dateTime;
                            bool x = sdal.UpdateQuantity(td.p_id, td.qty);
                            bool y = tddal.InsertTransactionDetails(td);
                            success = w && x && y;
                        }
                        if (success == true)
                        {
                            scope.Complete();

                            MessageBox.Show("Transaction Completed Sucessfully");

                            dgvAddedProducts.DataSource=null;
                            transactionDT.Clear();
                            dgvAddedProducts.Rows.Clear();
                            dgvAddedProducts.Columns.Clear();
                            dgvAddedProducts.Refresh();

                            txtCustomerName.Clear();
                            lblTotal.Text = "Total in Rs :";
                            total = 0;
                        }
                        else
                        {
                            MessageBox.Show("Transaction Failed");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            if (txtMedicine.Text == "" || txtMedicine.Text == null || txtPrice.Text == "" || txtPrice.Text == null || txtQty.Text == "" || txtQty.Text == null)
            {
                MessageBox.Show("Select the product first. Try Again!!!");
            }
            else
            {

                string medicine = txtMedicine.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                int qty = int.Parse(txtQty.Text);

                decimal subTotal = price * qty;
                total = total + subTotal;
                transactionDT.Rows.Add(p_id, medicine, price, qty, subTotal);
                dgvAddedProducts.DataSource = transactionDT;
                lblTotal.Text = "Total in Rs :" + total.ToString();

                txtMedicine.Clear();
                txtPrice.Text = 0.ToString();
                txtQty.Text = 0.ToString();
                txtPrice.Text = "";
                txtQty.Text = "";
            }
        }

        private void txtMedicine_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtMedicine.Text;

            if (keyword == "" || keyword == null)
            {
                txtPrice.Clear();
                txtQty.Clear();

                dgvStock.DataSource = null;
                dgvStock.Rows.Clear();
                dgvStock.Columns.Clear();
                dgvStock.Refresh();
            }
            else
            {
                txtPrice.Clear();
                txtQty.Clear();

                DataTable dt = sdal.ViewStock(keyword);
                dgvStock.DataSource = dt;
            }
        }

        private void dgvStock_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            p_id = int.Parse(dgvStock.Rows[RowIndex].Cells[0].Value.ToString());
            txtMedicine.Text = dgvStock.Rows[RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvStock.Rows[RowIndex].Cells[4].Value.ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "" || txtQty.Text != "")
            {
                dgvStock.DataSource = null;
                dgvStock.Rows.Clear();
                dgvStock.Columns.Clear();
                dgvStock.Refresh();
            }
        }
    }
}
