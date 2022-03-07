using KaloriTakip.Model.Entities;
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
        public MealEntry InsertMealEntry(MealEntry mealEntry)
        {
            if (_context.MealEntries.Where(a => a.MealsOfDayID == mealEntry.MealsOfDayID && a.EntryDate == mealEntry.EntryDate).Count()==0)
            {
                _context.MealEntries.Add(mealEntry);
                _context.SaveChanges();
                return mealEntry;
            }
            else
            {
                var entryID = _context.MealEntries.Where(a => a.MealsOfDayID == mealEntry.MealsOfDayID && a.EntryDate == mealEntry.EntryDate).Select(b=>new {EntryID=b.MealEntryID }).SingleOrDefault();
                mealEntry.MealEntryID = entryID.EntryID;
                return mealEntry;
            }
        }

        public List<MealEntry> GetUserMealEntries(DateTime date, int userID)
        {
           List<MealEntry> mealEntriesList=_context.MealEntries.Where(a => a.EntryDate == date && a.UserID == userID).ToList();
            return mealEntriesList;
        }
    }
}
