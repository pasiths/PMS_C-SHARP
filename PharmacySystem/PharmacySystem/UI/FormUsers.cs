using PhamicySysytem.BLL;
using PhamicySysytem.DAL;
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
    public partial class FormUsers : Form
    {
        userBLL u;
        userDAL dal;
        public FormUsers()
        {
            InitializeComponent(); 
            this.dgvUsers.DefaultCellStyle.ForeColor = Color.Black;

            u = new userBLL();
            dal = new userDAL();
            addcmb();
            refresh();
        }

        private void addcmb()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Not Special");

            cmbUserType.Items.Add("Admin");
            cmbUserType.Items.Add("User");
        }

        private void refresh()
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }
        private void Clear()
        {
            txtUserID.Text = string.Empty;
            txtName.Text = string.Empty;
            dtpDob.Value = DateTime.Now;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            cmbUserType.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || cmbUserType.Text == "" || cmbGender.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtMobile.Text == "")
            {
                MessageBox.Show("Fill the all!!!");
            }
            else
            {
                if (txtUserID.Text == "")
                {
                    if (cmbGender.SelectedIndex != -1)
                    {
                        if (cmbUserType.SelectedIndex != -1)
                        {
                            Int64 mobile;
                            if (Int64.TryParse(txtMobile.Text, out mobile) == false)
                            {
                                MessageBox.Show("Mobile number should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMobile.Focus();
                                return;
                            }
                            else
                            {
                                if (txtMobile.Text.Length < 10 || txtMobile.Text.Length > 15)
                                {
                                    MessageBox.Show("Mobile number should be 10 or above!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtMobile.Focus();
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
                            MessageBox.Show("Please check User type !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmbUserType.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check Gender !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbGender.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Alrady added user!!!");
                    return;
                }
            }
            refresh();
        }

        private void Save()
        {
            u.name = txtName.Text;
            u.DOB = dtpDob.Value;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.mobile = txtMobile.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            u.status = 1;

            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggeduser);
            u.added_by = usr.id;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("User Successfuly Created", "Success");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed To Add New User", "Fail");
                Clear();
            }
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            dtpDob.CustomFormat = "yyyy/MM/dd";
            dtpDob.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtMobile.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtName.Text == "" || txtAddress.Text == "" || cmbUserType.Text == "" || cmbGender.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtMobile.Text == "")
            {
                return;
            }
            else
            {
                if (cmbGender.SelectedIndex != -1)
                {
                    if (cmbUserType.SelectedIndex != -1)
                    {
                        Int64 mobile;
                        if (Int64.TryParse(txtMobile.Text, out mobile) == false)
                        {
                            MessageBox.Show("Mobile number should be numberical!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMobile.Focus();
                            return;
                        }
                        
                        else
                        {
                            if (txtMobile.Text.Length < 10 || txtMobile.Text.Length > 15)
                            {
                                MessageBox.Show("Mobile number should be 10 or 15!!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMobile.Focus();
                                return;
                            }
                            else
                            {
                                Update();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check User type !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbUserType.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please check Gender !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbGender.Focus();
                    return;
                }
            }
        }

        private void Update()
        {
            u.id = Convert.ToInt32(txtUserID.Text);
            u.name = txtName.Text;
            u.DOB = dtpDob.Value;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.mobile = txtMobile.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.updated_date = DateTime.Now;

            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggeduser);
            u.updated_by = usr.id;
            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("User Successfully Updated", "Success");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update User", "Fail");
            }
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtName.Text == "" || txtAddress.Text == "" || cmbUserType.Text == "" || cmbGender.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtMobile.Text == "")
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Are You Want Detele Data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    u.id = Convert.ToInt32(txtUserID.Text);
                    u.status = 0;
                    bool success = dal.Delete(u);
                    if (success == true)
                    {
                        MessageBox.Show("User Deleted Successfully", "Success");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete user", "Fail");
                    }
                }
                
                refresh();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtName.Text == "" || txtAddress.Text == "" || cmbUserType.Text == "" || cmbGender.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtMobile.Text == "")
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Are You Want To Reset Data?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clear();
                }
            }
        }
    }
}
