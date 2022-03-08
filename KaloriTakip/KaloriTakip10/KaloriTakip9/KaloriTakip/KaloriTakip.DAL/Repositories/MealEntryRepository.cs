using KaloriTakip.Model.Entities;
using KaloriTakip.Model.TempleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Repositories
{
    public class MealEntryRepository
    {
        CalorieDbContext _context;
        public MealEntryRepository()
        {
            _context = new CalorieDbContext();
        }
        public MealEntry InsertMealEntry(MealEntry mealEntry,int userID)
        {
            if (_context.MealEntries.Where(a => a.MealsOfDayID == mealEntry.MealsOfDayID && a.EntryDate == mealEntry.EntryDate && a.UserID==userID).Count() == 0) //TODO:Hata yeri
            {
                _context.MealEntries.Add(mealEntry);
                _context.SaveChanges();
                return mealEntry;
            }
            else
            {
                var entryID = _context.MealEntries.Where(a => a.MealsOfDayID == mealEntry.MealsOfDayID && a.EntryDate == mealEntry.EntryDate && a.UserID == userID).Select(b => new { EntryID = b.MealEntryID }).SingleOrDefault();
                mealEntry.MealEntryID = entryID.EntryID;
                return mealEntry;
            }
        }

        public List<CalorieByMeals> GetUserMealCalories(DateTime date, int userID)
        {
            //YÖNTEM 1 QuerySyntax
            List<CalorieByMeals> caloriebymealList = (from me in _context.MealEntries
                                                      join ed in _context.EntryDetails
                                                      on me.MealEntryID equals ed.MealEntryID
                                                      where me.EntryDate == date
                                                      group me by me.MealsOfDayID into a
                                                      //group new { me, ed } by new { me.MealsOfDayID } into a
                                                      select new CalorieByMeals
                                                      {
                                                          MealsOfDaysId = a.Key,
                                                          TotalCalorie = a.Sum(x => x.EntryDetail.Sum(t => t.TotalCalorie))
                                                          //TotalCalorie = a.Sum(x => x.ed.TotalCalorie),
                                                      }).ToList();


            //YÖNTEM 2 METOT SYNTAX
            //List<CalorieByMeals> falanList = _context.MealEntries.Where(a => a.EntryDate == date && a.UserID == userID).
            //    GroupBy(b => b.MealsOfDayID).
            //    Select(g => new CalorieByMeals
            //    {
            //        MealsOfDaysId = g.Key,
            //        TotalCalorie = g.Sum(s => s.EntryDetail.Select(t => t.TotalCalorie).Sum())
            //    }).ToList();

            return caloriebymealList;
        }

        public List<MealEntry> GetUserMealEntries(DateTime date, int userID)
        {
            List<MealEntry> mealEntriesList = _context.MealEntries.Where(a => a.EntryDate == date && a.UserID == userID).ToList();
            return mealEntriesList;
        }



    }
}
