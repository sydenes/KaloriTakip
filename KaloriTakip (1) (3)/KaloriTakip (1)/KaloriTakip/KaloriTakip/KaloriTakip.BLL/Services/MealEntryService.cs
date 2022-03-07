using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class MealEntryService
    {
        MealEntryRepository mealEntryRepository;
        public MealEntryService()
        {
            mealEntryRepository = new MealEntryRepository();
        }

        public MealEntry InsertMealEntry(MealEntry mealEntry)
        {
            return mealEntryRepository.InsertMealEntry(mealEntry);
        }

        public List<MealEntry> GetUserMealEntries(DateTime date, int userID)
        {
           return mealEntryRepository.GetUserMealEntries(date,userID);
        }
    }
}
