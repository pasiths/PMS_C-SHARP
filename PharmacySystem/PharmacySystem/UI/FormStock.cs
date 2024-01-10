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
using System.Windows.Forms;

namespace PharmacySystem
{
    public partial class FormStock : Form
    {
        stockDAL dal;
        stockBLL s;
        userDAL udal;
        categoriesDAL cdal;
        categoriesBLL cbll;
        manufacturesDAL mdal;
        public FormStock()
        {
            InitializeComponent();
            this.dgvStock.DefaultCellStyle.ForeColor = Color.Black;

            dal = new stockDAL();
            s = new stockBLL();
            udal = new userDAL();
            cdal = new categoriesDAL();
            cbll = new categoriesBLL();
            mdal = new manufacturesDAL();
            refresh();
            cmbtype();
            cmbmanid();
        }

        private void refresh()
        {
            DataTable dt = dal.Select();
            dgvStock.DataSource = dt;
        }

        private void Clear()
        {
            cmbType.SelectedIndex = -1;
            cmbMan_id.SelectedIndex = -1;
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtManufacturerName.Clear();
        }


        public void cmbtype()
        {
            try
            {
                DataTable categoriesDT = cdal.Select();
                cmbType.DataSource = categoriesDT;
                cmbType.DisplayMember = "title";
                cmbType.ValueMember = "title";
                cmbType.SelectedIndex = -1;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cmbmanid()
        {
            try
            {
                DataTable categoriesDT = mdal.Select();
                cmbMan_id.DataSource = categoriesDT;
                cmbMan_id.DisplayMember = "id";
                cmbMan_id.ValueMember = "id";
                cmbMan_id.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" || cmbType.Text != "" || txtQty.Text != "" || txtPrice.Text != "" || cmbMan_id.Text != "" || txtManufacturerName.Text != "")
            {
                if (txtID.Text == "")
                {
                    if (cmbType.SelectedIndex != -1)
                    {
                        if(cmbMan_id.SelectedIndex != -1)
                        {
                            int qty;
                            if(int.TryParse(txtQty.Text, out qty) == false)
                            {
                                MessageBox.Show("Quantity should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtQty.Focus();
                                return;
                            }
                            else
                            {
                                decimal price;
                                if (decimal.TryParse(txtPrice.Text, out price) == false)
                                {
                                    MessageBox.Show("Price should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPrice.Focus();
                                    return;
                                }
                                else
                                {
                                    if(qty != 0)
                                    {
                                        if (price != 0)
                                        {
                                            Save();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Price should not be zero!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtPrice.Focus();
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Quantity should not be zero!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtQty.Focus();
                                        return;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check manufacturer ID !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmbMan_id.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check medicine type !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbType.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Alrady added Stock!!!");
                }
            }
        }

        private void Save()
        {
            s.name = txtName.Text;
            s.type = cmbType.Text;
            s.qty = int.Parse(txtQty.Text);
            s.price = decimal.Parse(txtPrice.Text);
            s.man_id = int.Parse(cmbMan_id.Text);
            s.added_date = DateTime.Now;
            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            s.added_by = usr.id;
            s.status = 1;
            bool success = dal.Insert(s);
            if (success == true)
            {
                MessageBox.Show("Stock add Successfully", "Success");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add Stock", "Fail");
            }
            refresh();
        }

        private void change_manName()
        {
            string manid = cmbMan_id.Text;
            if (cmbMan_id.Text == "")
            {
                txtManufacturerName.Text = "";
                txtManufacturerName.Clear();
            }
            else
            {
                txtManufacturerName.Text = mdal.FindName(manid);
            }
        }

        private void cmbMan_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_manName();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" || txtName.Text != "" || cmbType.Text != "" || txtQty.Text != "" || txtPrice.Text != "" || cmbMan_id.Text != "" || txtManufacturerName.Text != "")
            {
                if (cmbType.SelectedIndex != -1)
                {
                    if (cmbMan_id.SelectedIndex != -1)
                    {
                        int qty;
                        if (int.TryParse(txtQty.Text, out qty) == false)
                        {
                            MessageBox.Show("Quantity should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtQty.Focus();
                            return;
                        }
                        else
                        {
                            decimal price;
                            if (decimal.TryParse(txtPrice.Text, out price) == false)
                            {
                                MessageBox.Show("Price should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPrice.Focus();
                                return;
                            }
                            else
                            {
                                if (qty != 0)
                                {
                                    if (price != 0)
                                    {
                                        Update();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Price should not be zero!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtPrice.Focus();
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Quantity should not be zero!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtQty.Focus();
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check manufacturer ID !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbMan_id.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please check medicine type !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbType.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fill the all!!!");
            }
        }

        private void Update()
        {
            s.id = int.Parse(txtID.Text);
            s.name = txtName.Text;
            s.type = cmbType.Text;
            s.qty = int.Parse(txtQty.Text);
            s.price = decimal.Parse(txtPrice.Text);
            s.man_id = int.Parse(cmbMan_id.Text);
            s.updated_date = DateTime.Now;
            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            s.updated_by = usr.id;
            bool success = dal.Update(s);
            if (success == true)
            {
                MessageBox.Show("Stock Update Successfully", "Success");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update Stock", "Fail");
            }
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" || txtName.Text != "" || cmbType.Text != "" || txtQty.Text != "" || txtPrice.Text != "" || cmbMan_id.Text != "" || txtManufacturerName.Text != "")
            {
                if (MessageBox.Show("Are You Want Detele Data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    s.id = int.Parse(txtID.Text);
                    s.status = 0;
                    bool success = dal.Delete(s);
                    if (success == true)
                    {
                        MessageBox.Show("Stock Deleted Successfully", "Success");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Stock", "Fail");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Fill the all!!!");
            }
            refresh();
        }

        private void dgvStock_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtID.Text = dgvStock.Rows[RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvStock.Rows[RowIndex].Cells[1].Value.ToString();
            cmbType.Text = dgvStock.Rows[RowIndex].Cells[2].Value.ToString();
            txtQty.Text = dgvStock.Rows[RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dgvStock.Rows[RowIndex].Cells[4].Value.ToString();
            cmbMan_id.Text = dgvStock.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords == null || keywords == "")
            {
                refresh();
            }
            else
            {
                DataTable dt = dal.Search(keywords);
                dgvStock.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Reset Data?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clear();
            }
        }
    }
}
