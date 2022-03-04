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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            userService = new UserService();

        }
        UserService userService;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text!=txtPassCont.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
                return;
            }

            try
            {
                User user = new User()
                {
                    BirthDate = dtpBirthdate.Value,
                    Gender = rbtnFemale.Checked ? true : false,
                    Weight = Convert.ToDecimal((txtWeight.Text)),
                    Height = Convert.ToDecimal(txtHeight.Text),
                    Activity = cmbActivity.SelectedItem.ToString(),
                    UserName = txtEmail.Text,
                    Password = txtPassword.Text,
                };
                bool check = userService.Insert(user);
                MessageBox.Show(check ? "Kayıt gerçekleşti" : "Bilgilerinizi kontrol ediniz");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
