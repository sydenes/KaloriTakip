using KaloriTakip.BLL.Services;
using KaloriTakip.Model.Entities;
using KaloriTakip.Model.TempleClass;
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
    public partial class DailyReports : Form
    {
        private DateTime date;
        private User user;

        public DailyReports()
        {
            InitializeComponent();
        }
        MealEntryService mealEntryService;
        public DailyReports(DateTime date, User user)
        {
            this.date = date;
            this.user = user;
            InitializeComponent();
            mealEntryService = new MealEntryService();
        }



        private void Totals_Load(object sender, EventArgs e)
        {
            UserSettings userSettings = this.MdiParent as UserSettings;
            DailyLoadMetot();
        }

        
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            date = dtpDate.Value;
            DailyLoadMetot();
        }
        private void DailyLoadMetot()
        {
            chartDailyCalories.Series["Kalori"].Points.Clear();

            List<CalorieByMeals> calorieList = mealEntryService.GetUserMealCalories(date.Date, user.UserID);

            int totalAksamCalorie = 0;
            int totalOgle = 0;
            int totalSabahCalorie = 0;
            int total1Ara = 0;
            int totatl2Ara = 0;

            foreach (var entry in calorieList)
            {
                switch (entry.MealsOfDaysId)
                {
                    case 1:
                        totalSabahCalorie += Convert.ToInt32(entry.TotalCalorie);
                        break;
                    case 2:
                        total1Ara += Convert.ToInt32(entry.TotalCalorie);
                        break;
                    case 3:
                        totalOgle += Convert.ToInt32(entry.TotalCalorie);
                        break;
                    case 4:
                        totatl2Ara += Convert.ToInt32(entry.TotalCalorie);
                        break;
                    case 5:
                        totalAksamCalorie += Convert.ToInt32(entry.TotalCalorie);
                        break;
                }
            }

            chartDailyCalories.Series["Kalori"].Points.Add(totalSabahCalorie);
            chartDailyCalories.Series["Kalori"].Points.Add(total1Ara);
            chartDailyCalories.Series["Kalori"].Points.Add(totalOgle);
            chartDailyCalories.Series["Kalori"].Points.Add(totatl2Ara);
            chartDailyCalories.Series["Kalori"].Points.Add(totalAksamCalorie);
            chartDailyCalories.Series["Kalori"].Points[0].AxisLabel = "Sabah";
            chartDailyCalories.Series["Kalori"].Points[1].AxisLabel = "1.Ara";
            chartDailyCalories.Series["Kalori"].Points[2].AxisLabel = "Öğle";
            chartDailyCalories.Series["Kalori"].Points[3].AxisLabel = "2.Ara";
            chartDailyCalories.Series["Kalori"].Points[4].AxisLabel = "Akşam";

            chartDailyCalories.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
        }
    }
}
