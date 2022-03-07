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
        public void Insert(List<EntryDetails> entryDetailsList)
        {
            foreach (var item in entryDetailsList)
            {
                _context.EntryDetails.Add(item);
                
            }
            _context.SaveChanges();
        }

        public List<EntryDetails> GetEntryDetails(List<MealEntry> mealEntriesList)
        {
            List<EntryDetails> entryDetailsList = new List<EntryDetails>();
            foreach (var item in mealEntriesList)
            {
                List<EntryDetails> templateList = new List<EntryDetails>();
                templateList = _context.EntryDetails.Where(a => a.MealEntryID == item.MealEntryID).ToList();
                foreach (var item2 in templateList)
                {
                    entryDetailsList.Add(item2);
                }
            }
            return entryDetailsList;
        }
    }
}
