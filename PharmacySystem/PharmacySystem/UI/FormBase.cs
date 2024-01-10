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
    public partial class FormBase : Form
    {
        bool sidebarExpand;
        Form1 sell;
        FormBase Base;
        FormBaseUser BaseUser;
        FormCategory category;
        FormHome home;
        FormLogIn Login;
        FormManufactures manufactures;
        FormProfile profile;
        FormStock Stock;
        FormTransactions transactions;
        FormUsers users;
        FormViewStock viewStock;

        public FormBase()
        {
            InitializeComponent();
            sidebarTimer_Trick.Start();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new FormHome();
                home.FormClosed += home_FormClosed;
                home.MdiParent = this;
                home.Show();
                home.Dock = DockStyle.Fill;

            }
            else
            {
                home.Activate();
            }
        }


        private void sidebarTimerTick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer_Trick.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer_Trick.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer_Trick.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new FormHome();
                home.FormClosed += home_FormClosed;
                home.MdiParent = this;
                home.Show();
                home.Dock = DockStyle.Fill;
                
            }
            else {
                home.Activate();
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            if (sell == null)
            {
                sell = new Form1();
                sell.FormClosed += sell_FormClosed;
                sell.MdiParent = this;
                sell.Show();
                sell.Dock = DockStyle.Fill;
            }
            else
            {
                sell.Activate();
            }
        }

        private void sell_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (Stock == null)
            {
                Stock = new FormStock();
                Stock.FormClosed += Stock_FormClosed;
                Stock.MdiParent = this;
                Stock.Show();
                Stock.Dock = DockStyle.Fill;
            }
            else
            {
                Stock.Activate();
            }
        }

        private void Stock_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                category = new FormCategory();
                category.FormClosed += category_FormClosed;
                category.MdiParent = this;
                category.Show();
                category.Dock = DockStyle.Fill;
            }
            else
            {
                category.Activate();
            }
        }

        private void category_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnManufactures_Click(object sender, EventArgs e)
        {
            if (manufactures == null)
            {
                manufactures = new FormManufactures();
                manufactures.FormClosed += manufactures_FormClosed;
                manufactures.MdiParent = this;
                manufactures.Show();
                manufactures.Dock = DockStyle.Fill;
            }
            else
            {
                manufactures.Activate();
            }
        }

        private void manufactures_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (transactions == null)
            {
                transactions = new FormTransactions();
                transactions.FormClosed += transactions_FormClosed;
                transactions.MdiParent = this;
                transactions.Show();
                transactions.Dock = DockStyle.Fill;
            }
            else
            {
                transactions.Activate();
            }
        }

        private void transactions_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (users == null)
            {
                users = new FormUsers();
                users.FormClosed += users_FormClosed;
                users.MdiParent = this;
                users.Show();
                users.Dock = DockStyle.Fill;
            }
            else
            {
                users.Activate();
            }
        }

        private void users_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                profile = new FormProfile();
                profile.FormClosed += profile_FormClosed;
                profile.MdiParent = this;
                profile.Show();
                profile.Dock = DockStyle.Fill;
            }
            else
            {
                profile.Activate();
            }
        }

        private void profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Really want to EXIT Application?","Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Really want to Log Out?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogIn login = new FormLogIn();
                login.Show();
                this.Hide();
            }
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnSelling_MouseEnter(object sender, EventArgs e)
        {
            btnSelling.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnSelling_MouseLeave(object sender, EventArgs e)
        {
            btnSelling.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnStock_MouseEnter(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnCategory_MouseEnter(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnCategory_MouseLeave(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnManufactures_MouseEnter(object sender, EventArgs e)
        {
            btnManufactures.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnManufactures_MouseLeave(object sender, EventArgs e)
        {
            btnManufactures.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnTransactions_MouseEnter(object sender, EventArgs e)
        {
            btnTransactions.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnTransactions_MouseLeave(object sender, EventArgs e)
        {
            btnTransactions.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            //btnSettings.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            //btnSettings.BackColor = Color.FromArgb(18, 124, 214);
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(40, 168, 234);
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(18, 124, 214);
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            if (transactions == null)
            {
                transactions = new FormTransactions();
                transactions.FormClosed += home_FormClosed;
                transactions.MdiParent = this;
                transactions.Show();
                transactions.Dock = DockStyle.Fill;

            }
            else
            {
                transactions.Activate();
            }
        }
    }
}
