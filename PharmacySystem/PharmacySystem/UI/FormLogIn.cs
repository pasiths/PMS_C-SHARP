using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhamicySysytem.BLL;
using PhamicySysytem.DAL;

namespace PharmacySystem.UI
{
    public partial class FormLogIn : Form
    {
        loginBLL l;
        loginDAL dal;
        public static string loggedIn;

        public FormLogIn()
        {
            InitializeComponent();
            pass.Checked = true;
            l = new loginBLL();
            dal = new loginDAL();
        }
        private void clear()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Really want to EXIT Application?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == null || txtPassword.Text == null || txtUsername.Text == " " || txtPassword.Text == "")
            {
                MessageBox.Show("Plase Enter the username and password and try again!!!");
                txtUsername.Focus();
            }
            else
            {
                l.username = txtUsername.Text.Trim();
                l.password = txtPassword.Text.Trim();

                bool sucess = dal.loginCheck(l);
                if (sucess == true)
                {
                    loggedIn = l.username;
                    switch (l.user_type)
                    {
                        case "Admin":
                            {
                                FormBase admin = new FormBase();
                                admin.Show();
                                this.Hide();
                            }
                            break;

                        case "User":
                            {
                                FormBaseUser user = new FormBaseUser();
                                user.Show();
                                this.Hide();
                            }
                            break;

                        default:
                            {
                                MessageBox.Show("Invalid User Type.");
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed. Try Again", "Fail");
                    txtUsername.Focus();
                    clear();
                }
            }
        }

        private void pass_CheckedChanged(object sender, EventArgs e)
        {
            if(pass.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = false;

                this.pass.Image = global::PharmacySystem.Properties.Resources.eye_24;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                this.pass.Image = global::PharmacySystem.Properties.Resources.hidden_eye_icon;
            }
        }
    }
}
