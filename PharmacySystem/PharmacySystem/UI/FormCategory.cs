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
    public partial class FormCategory : Form
    {
        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();
        public FormCategory()
        {
            InitializeComponent();
            refresh();

            this.dgvCategories.DefaultCellStyle.ForeColor = Color.Black;
            //this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Fill the all!!!");
            }
            else
            {
                if (txtCategoryID.Text == "")
                {
                    Save();
                }
                else
                {
                    MessageBox.Show("Alrady added category!!!");
                }
            }
        }

        private void Save()
        {
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            c.added_by = usr.id;

            c.status = 1;

            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New category inserted successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to insert new category");
            }
            refresh();
        }

        public void Clear()
        {
            txtCategoryID.Clear();
            txtDescription.Clear();
            txtTitle.Clear();
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text != "" || txtTitle.Text != "" || txtDescription.Text != "")
            {
                if (MessageBox.Show("Are You Want Detele Data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.id = int.Parse(txtCategoryID.Text);
                    c.status = 0;

                    bool success = dal.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Category Update successfully");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update category");
                    }
                }
                
            }
            else
            {
                return;
            }
            refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text != "" || txtTitle.Text != "" || txtDescription.Text != "")
            {
                Update();
            }
            else
            {
                return;
            }
            
        }

        private void Update()
        {
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.updated_date = DateTime.Now;

            string loggeduser = FormLogIn.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            c.updated_by = usr.id;

            bool success = dal.Update(c);

            if (success == true)
            {
                MessageBox.Show("Category Update successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update category");
            }
            refresh();
        }

        private void refresh()
        {
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                refresh();
            }
            else
            {
                DataTable dt = dal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
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