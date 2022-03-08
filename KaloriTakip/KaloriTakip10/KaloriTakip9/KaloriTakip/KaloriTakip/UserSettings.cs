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
    public partial class UserSettings : Form
    {
        private User user;
        private DateTime date;
        UserService userService;
        public UserSettings()
        {
            
        }

        public UserSettings(User user,DateTime date)
        {
            InitializeComponent();
            this.user = user;
            this.date = date;
            userService=new UserService();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {

        }


        private void günSonuRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DailyReports reportsDaily = new DailyReports(date,user);
            reportsDaily.MdiParent = this;
            reportsDaily.Dock = DockStyle.Fill;
            reportsDaily.Show();
        }

        private void kullanıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSet userSet = new UserSet(date,user);
            userSet.MdiParent = this;
            userSet.Dock = DockStyle.Fill;
            userSet.Show();
        }

        private void kıyasRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComparisonReports comparisonReports = new ComparisonReports(user);
            comparisonReports.MdiParent = this;
            comparisonReports.Dock = DockStyle.Fill;
            comparisonReports.Show();
        }
    }
}
