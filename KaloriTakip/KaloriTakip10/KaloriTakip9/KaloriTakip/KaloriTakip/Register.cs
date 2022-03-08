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
                    Weight = string.IsNullOrEmpty(txtWeight.Text) ? 0 : Convert.ToDecimal(txtWeight.Text),
                    Height = string.IsNullOrEmpty(txtHeight.Text) ? 0 : Convert.ToDecimal(txtHeight.Text),
                    Activity = cmbActivity.SelectedItem == null ? throw new Exception("Aktivite boş geçilemez") : cmbActivity.SelectedItem.ToString(),
                    UserName = txtEmail.Text,
                    Password = txtPassword.Text,
                };
                bool check = userService.Insert(user);
                MessageBox.Show(check ? "Kayıt gerçekleşti" : "Bilgilerinizi kontrol ediniz");
                if (check)
                {
                    Login login = new Login();
                    this.Hide();
                    //this.Close();
                    login.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
