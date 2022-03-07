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

        public Introduction()
        {
            InitializeComponent();
        }
        UserService userService;
        public Introduction(User user)
        {
            InitializeComponent();
            this.user = user;
            
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator(user);
            this.Hide();
            calculator.ShowDialog();

        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }
    }
}
