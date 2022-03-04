using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakip
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rgstr = new Register();
            this.Hide();
            rgstr.ShowDialog();
            this.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username =  Convert.ToString( txtUserName.Text);
            string password = txtPassword.Text;
            //User user = calorieDbContext.User.Where(a => a.UserName == username).SingleOrDefault();
            //MessageBox.Show("başarılı");
            //if (user.isActivate==false)
            //{
            //    //tanıtım formu
            //    user.isActivate = true;
            //}
            //else
            //{
            //    //calculator
            //}
        }
    }
}
