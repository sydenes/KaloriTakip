using KaloriTakip.BLL.Services;
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
            userService = new UserService();
        }
        UserService userService;
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
            User user = userService.CheckLogin(username, password);
            if (user!=null)
            {
                if (user.isActivate == false)
                {
                    //Tanıtım
                    Introduction intro = new Introduction(user);
                    this.Hide();
                    intro.ShowDialog();
                    userService.Activite(user.UserID);
                }
                else
                {
                    //calculator
                    Calculator calculator = new Calculator(user);
                    this.Hide();
                    calculator.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("null");
            }
        }
    }
}
