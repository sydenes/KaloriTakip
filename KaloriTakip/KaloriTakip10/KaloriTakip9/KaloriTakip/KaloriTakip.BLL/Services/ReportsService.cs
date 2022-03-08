using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.TempleClass;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class ReportsService
    {
        ReportsRepository reportsRepository;
        public ReportsService()
        {
            reportsRepository = new ReportsRepository();
        }

        public List<List<CategoryReports>> GetReportsByCategoryWeek(User user,DateTime dateTime)
        {
            List<List<CategoryReports>> catRepList = reportsRepository.GetReportsByCategoryAsIntervalWeek(user,dateTime);

            return catRepList;
        }
        public List<List<CategoryReports>> GetReportsByCategoryMounth(User user, DateTime dateTime)
        {
            List<List<CategoryReports>> catRepList = reportsRepository.GetReportsByCategoryAsIntervalMounth(user, dateTime);

            return catRepList;
        }


        //GetReportByMeals Metotu eklenecek
        public List<List<CalorieByMeals>> GetReportsByMealsWeek(User user,DateTime dateTime)
        {
            List<List<CalorieByMeals>> calorieByMealsList = reportsRepository.GetReportsByMealsAsIntervalWeek(user,dateTime);
            return calorieByMealsList;
        }
        public List<List<CalorieByMeals>> GetReportsByMealsMounth(User user, DateTime dateTime)
        {
            List<List<CalorieByMeals>> calorieByMealsList = reportsRepository.GetReportsByMealsAsIntervalMounth(user, dateTime);
            return calorieByMealsList;
        }

    }
}
