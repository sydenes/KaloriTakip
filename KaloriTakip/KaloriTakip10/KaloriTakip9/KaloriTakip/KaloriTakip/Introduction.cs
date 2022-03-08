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
    public partial class Introduction : Form
    {
        private User user;
        UserService userService;
        public Introduction()
        {
            InitializeComponent();
        }

        public Introduction(User user)
        {
            InitializeComponent();
            this.user = user;
            userService = new UserService();

        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            userService.Activite(user.UserID);
            Calculator calculator = new Calculator(user);
            this.Hide();
            calculator.ShowDialog();

        }

        private void Introduction_Load(object sender, EventArgs e)
        {
            pbIntro.Image = KaloriTakip.Properties.Resources.Calculator1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pbIntro.Image = KaloriTakip.Properties.Resources.Calculator1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbIntro.Image = KaloriTakip.Properties.Resources.MealAdd1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pbIntro.Image = KaloriTakip.Properties.Resources.UserSettings1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pbIntro.Image = KaloriTakip.Properties.Resources.Reports1;
        }
    }
}
