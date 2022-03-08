using KaloriTakip.BLL.Services;
using KaloriTakip.Model.TempleClass;
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
    public partial class ComparisonReports : Form
    {
        ReportsService reportsService;
        User user;
        public ComparisonReports(User user)
        {
            InitializeComponent();
            reportsService = new ReportsService();
            this.user = user;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
        
            if (rbtnWeekly.Checked)
            {
                 //Haftalık
                if (rbtnByCategory.Checked)
                {
                    //Kategoriye göre haftalık
                    GetReportsByCategoryWeek(user, dtpReport.Value);
                }
                else
                {
                    //Öğünlere göre haftalık
                    GetReportsByMealsWeek(user,dtpReport.Value);
                }
            }
            else
            {
                 //Aylık
                if (rbtnByCategory.Checked)
                {
                     //Kategoriye göre aylık
                    GetReportsByCategoryMounth(user,dtpReport.Value);

                }
                else
                {
                    //Öğünlere göre aylık
                    GetReportsByMealsMounth(user,dtpReport.Value);
                }
            }
        }

        private void GetReportsByCategoryWeek(User user,DateTime date)
        {
            chartAllReports.Series[0].Points.Clear();

            chartAllReports.Series[1].Points.Clear();
            List<List<CategoryReports>> catRepList = reportsService.GetReportsByCategoryWeek( user,date);

            int i = 0;
            foreach (var list in catRepList) //Fill chart
            {
                foreach (var item in list)
                {
                    chartAllReports.Series[i].Points.Add(item.TotalSerValue).AxisLabel = item.CategoryName; 
                }
                i++;
            }
        }
        private void GetReportsByCategoryMounth(User user, DateTime date)
        {
            chartAllReports.Series[0].Points.Clear();
            chartAllReports.Series[1].Points.Clear();
            List<List<CategoryReports>> catRepList = reportsService.GetReportsByCategoryMounth(user, date);

            int i = 0;
            foreach (var list in catRepList)
            {
                foreach (var item in list)
                {
                    chartAllReports.Series[i].Points.Add(item.TotalSerValue).AxisLabel = item.CategoryName; 
                }
                i++;
            }
        }
        private void GetReportsByMealsWeek(User user,DateTime dateTime)//Fill chart
        {
            chartAllReports.Series[0].Points.Clear();
            chartAllReports.Series[1].Points.Clear();
            List<List<CalorieByMeals>> calorieByMealsList = reportsService.GetReportsByMealsWeek(user,dateTime);
            int i = 0;
            foreach (var list in calorieByMealsList)
            {
                foreach (var item in list)
                {
                    chartAllReports.Series[i].Points.Add(Convert.ToDouble( item.TotalCalorie)).AxisLabel = item.MealsOfDayName;
                }
                i++;
            }
        }
        private void GetReportsByMealsMounth(User user, DateTime dateTime)
        {
            chartAllReports.Series[0].Points.Clear();
            chartAllReports.Series[1].Points.Clear();
            List<List<CalorieByMeals>> calorieByMealsList = reportsService.GetReportsByMealsMounth(user, dateTime);
            int i = 0;
            foreach (var list in calorieByMealsList)
            {
                foreach (var item in list)
                {
                    chartAllReports.Series[i].Points.Add(Convert.ToDouble(item.TotalCalorie)).AxisLabel = item.MealsOfDayName; 
                }
                i++;
            }
        }

        private void ComparisonReports_Load(object sender, EventArgs e)
        {
            UserSettings userSettings = this.MdiParent as UserSettings;
        }
    }
}
