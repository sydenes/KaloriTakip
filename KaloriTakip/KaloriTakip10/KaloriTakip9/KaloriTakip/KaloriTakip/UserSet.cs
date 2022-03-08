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
    public partial class UserSet : Form
    {
        private User user;
        private DateTime date;
        UserService userService;
        public UserSet(DateTime date, User user)
        {
            InitializeComponent();
            this.date = date;
            this.user = user;
            userService = new UserService();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                user.Height = Convert.ToDecimal(txtHeight.Text);
                user.Weight = Convert.ToDecimal(txtWeight.Text);
                user.BirthDate = dtpBirthDate.Value;
                userService.UpdateUser(user);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UserSet_Load_1(object sender, EventArgs e)
        {
            UserSettings userSettings = this.MdiParent as UserSettings;

            lblUserName.Text = user.UserName;
            txtHeight.Text = user.Height.ToString();
            lblGender.Text = user.Gender ? "Kadın" : "Erkek";
            txtWeight.Text = user.Weight.ToString();
            dtpBirthDate.Value = (DateTime)user.BirthDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Password = txtPassword.Text;
            userService.UpdateUser(user);
        }
    }
}
