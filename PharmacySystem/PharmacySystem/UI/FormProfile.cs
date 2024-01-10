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
    public partial class FormProfile : Form
    {
        userBLL u;
        userDAL uDal;
        public FormProfile()
        {
            InitializeComponent();
            u = new userBLL();
            uDal = new userDAL();
            uDal.DisplayProfile(u);
            display();
        }

        private void display()
        {
            lblShowUserID.Text = u.id.ToString();
            lblShowName.Text = u.name;
            lblShowDOB.Text = u.sDOB;
            lblShowEmail.Text = u.email;
            lblShowAddress.Text = u.address;
            lblShowMobile.Text = u.mobile;
            lblShowGender.Text = u.gender;
            lblShowUserType.Text = u.user_type;
        }
    }
}
