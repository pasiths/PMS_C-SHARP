using PhamicySysytem.BLL;
using PhamicySysytem.DAL;
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
    public partial class FormManufactures : Form
    {
        public FormManufactures()
        {
            InitializeComponent();
            this.dgvManufacturer.DefaultCellStyle.ForeColor = Color.Black;

            refresh();
        }

        manufacturesBLL m = new manufacturesBLL();
        manufacturesDAL dal = new manufacturesDAL();
        userDAL udal = new userDAL();

        private void refresh()
        {
            DataTable dt = dal.Select();
            dgvManufacturer.DataSource = dt;
        }

        private void Clear()
        {
            txtManufacturerID.Clear();
            txtManufacturerName.Clear();
            txtManufacturerAddress.Clear();
            txtManufacturerEmail.Clear();
            txtManufacturerMobile.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "" || txtManufacturerAddress.Text == "" || txtManufacturerEmail.Text == "" || txtManufacturerMobile.Text == "")
            {
                MessageBox.Show("Fill the all!!!");
            }
            else
            {
                if (txtManufacturerID.Text == "")
                {
                    Int64 mobile;
                    if (Int64.TryParse(txtManufacturerMobile.Text, out mobile) == false)
                    {
                        MessageBox.Show("Mobile number should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtManufacturerMobile.Focus();
                        return;
                    }
                    else
                    {
                        if (txtManufacturerMobile.Text.Length < 10 || txtManufacturerMobile.Text.Length > 15)
                        {
                            MessageBox.Show("Mobile number should be 10 or above!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtManufacturerMobile.Focus();
                            return;
                        }
                        else
                        {
                            Save();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Alrady added Manufacturer!!!");
                }
            }
        }

        private void Save()
        {
            m.manufacturerName = txtManufacturerName.Text;
            m.manufacturerAddress = txtManufacturerAddress.Text;
            m.manufacturerEmail = txtManufacturerEmail.Text;
            m.manufacturerMobile = txtManufacturerMobile.Text;
            m.added_date = DateTime.Now;
            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            m.added_by = usr.id;
            m.status = 1;
            bool success = dal.Insert(m);

            if (success == true)
            {
                MessageBox.Show("New Manufacturer inserted successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to insert new Manufacturer");
            }
            refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtManufacturerID.Text == "" || txtManufacturerName.Text == "" || txtManufacturerAddress.Text == "" || txtManufacturerEmail.Text == "" || txtManufacturerMobile.Text == "")
            {
                return;
            }
            else
            {
                Int64 mobile;
                if (Int64.TryParse(txtManufacturerMobile.Text, out mobile) == false)
                {
                    MessageBox.Show("Mobile number should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtManufacturerMobile.Focus();
                    return;
                }
                else
                {
                    if (txtManufacturerMobile.Text.Length < 10 || txtManufacturerMobile.Text.Length > 15)
                    {
                        MessageBox.Show("Mobile number should be 10 or above!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtManufacturerMobile.Focus();
                        return;
                    }
                    else
                    {
                        Update();
                    }
                }
                
            }
        }

        private void Update()
        {
            m.manufacturerID = int.Parse(txtManufacturerID.Text);
            m.manufacturerName = txtManufacturerName.Text;
            m.manufacturerAddress = txtManufacturerAddress.Text;
            m.manufacturerEmail = txtManufacturerEmail.Text;
            m.manufacturerMobile = txtManufacturerMobile.Text;
            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            m.updated_by = usr.id;
            m.updated_date = DateTime.Now;

            bool success = dal.Update(m);

            if (success == true)
            {
                MessageBox.Show("Manufacturer Update successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update Manufacturer");
            }
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtManufacturerID.Text == "" || txtManufacturerName.Text == "" || txtManufacturerAddress.Text == "" || txtManufacturerEmail.Text == "" || txtManufacturerMobile.Text == "")
            {
                MessageBox.Show("No user Details!!!");
            }
            else
            {
                if (MessageBox.Show("Are You Want Detele Data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m.manufacturerID = int.Parse(txtManufacturerID.Text);
                    m.status = 0;
                    bool success = dal.Delete(m);
                    if (success == true)
                    {
                        MessageBox.Show("Manufacturer Deleted Successfully", "Success");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Manufacturer", "Fail");
                    }
                }
                
                refresh();
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords == null || keywords == "")
            {
                refresh();
            }
            else
            {
                DataTable dt = dal.Search(keywords);
                dgvManufacturer.DataSource = dt;
            }
        }

        private void dgvManufacturer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtManufacturerID.Text = dgvManufacturer.Rows[RowIndex].Cells[0].Value.ToString();
            txtManufacturerName.Text = dgvManufacturer.Rows[RowIndex].Cells[1].Value.ToString();
            txtManufacturerAddress.Text = dgvManufacturer.Rows[RowIndex].Cells[2].Value.ToString();
            txtManufacturerEmail.Text = dgvManufacturer.Rows[RowIndex].Cells[3].Value.ToString();
            txtManufacturerMobile.Text = dgvManufacturer.Rows[RowIndex].Cells[4].Value.ToString();
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
