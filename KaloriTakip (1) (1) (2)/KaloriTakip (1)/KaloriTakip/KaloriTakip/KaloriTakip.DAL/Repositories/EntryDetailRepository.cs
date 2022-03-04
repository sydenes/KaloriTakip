using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Repositories
{
    public class EntryDetailRepository
    {
        CalorieDbContext _context;
        public EntryDetailRepository()
        {
            _context = new CalorieDbContext();
        }
        public bool Insert(EntryDetails entryDetails,MealEntry mealEntry)
        {
            _context.EntryDetails.Add(entryDetails);
            _context.MealEntries.Add(mealEntry);
            return _context.SaveChanges()>0;
        }
    }
}
