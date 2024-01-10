using PharmacySystem.BLL;
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
    public partial class FormHome : Form
    {
        stockDAL sdal;
        transactionDetailsDAL tddal;
        public FormHome()
        {
            InitializeComponent();
            this.dgvSales.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvStock.DefaultCellStyle.ForeColor = Color.Black;
            sdal = new stockDAL();
            tddal = new transactionDetailsDAL();
            showNoStock();
            showSales();
            timer1.Start();
            timer2.Start();
        }

        private void showNoStock()
        {
            DataTable dt = sdal.ViewNoStock();
            dgvStock.DataSource = dt;
        }


        private void showSales()
        {
            DataTable dt = tddal.Select();
            dgvSales.DataSource = dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnTime.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            showNoStock();
            showSales();
        }
    }
}
