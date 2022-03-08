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
        public void Insert(List<EntryDetail> entryDetailsList)
        {
            foreach (var item in entryDetailsList)
            {
                if (_context.EntryDetails.Where(a => a.EntryDetailID == item.EntryDetailID).Count()==0  )
                {
                    _context.EntryDetails.Add(item);
                   int a= _context.SaveChanges();
                }
                if (_context.EntryDetails.Where(a => a.EntryDetailID == item.EntryDetailID).Count() != 0 && _context.EntryDetails.Where(a => a.FoodID == item.FoodID).Count() != 0)
                {
                    EntryDetail updateDetail =_context.EntryDetails.Find(item.EntryDetailID);
                    updateDetail.ServiceValue = item.ServiceValue;
                    updateDetail.TotalCalorie = item.TotalCalorie;
                    updateDetail.TotalCarbonhydrates = item.TotalCarbonhydrates;
                    updateDetail.TotalFat = item.TotalFat;
                    updateDetail.TotalProtein = item.TotalProtein;
                    _context.SaveChanges();
                }
            }
            int x=_context.SaveChanges();
        }

        public void Delete(int deleteID)
        {
            EntryDetail deleteDetail = _context.EntryDetails.Find(deleteID);
            _context.EntryDetails.Remove(deleteDetail);
            _context.SaveChanges();
        }

        public List<EntryDetail> GetEntryDetails(List<MealEntry> mealEntriesList)
        {
            List<EntryDetail> entryDetailsList = new List<EntryDetail>();
            foreach (var item in mealEntriesList)
            {
                List<EntryDetail> templateList = new List<EntryDetail>();
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
