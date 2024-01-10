using PharmacySystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.UI
{
    public partial class FormTransactions : Form
    {
        transactionDetailsDAL tddal = new transactionDetailsDAL();
        public FormTransactions()
        {
            InitializeComponent();
            this.dgvTransactions.DefaultCellStyle.ForeColor = Color.Black;

            refresh();
        }

        private void refresh()
        {
            DataTable dt = tddal.Select();
            dgvTransactions.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                refresh();
            }
            else
            {
                DataTable dt = tddal.Search(keywords);
                dgvTransactions.DataSource = dt;
            }
        }
    }
}
