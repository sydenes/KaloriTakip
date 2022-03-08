using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using KaloriTakip.Model.TempleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KaloriTakip.DAL.Repositories.MealEntryRepository;

namespace KaloriTakip.BLL.Services
{
    public class MealEntryService
    {
        MealEntryRepository mealEntryRepository;
        public MealEntryService()
        {
            mealEntryRepository = new MealEntryRepository();
        }

        public MealEntry InsertMealEntry(MealEntry mealEntry,int userID)
        {
            return mealEntryRepository.InsertMealEntry(mealEntry,userID);
        }

        public List<MealEntry> GetUserMealEntries(DateTime date, int userID)
        {
           return mealEntryRepository.GetUserMealEntries(date,userID);
        }
        

        public List<CalorieByMeals> GetUserMealCalories(DateTime date, int userID)
        {
            List<CalorieByMeals> calorieList = mealEntryRepository.GetUserMealCalories(date, userID);
            return calorieList;
        }
    }
}
