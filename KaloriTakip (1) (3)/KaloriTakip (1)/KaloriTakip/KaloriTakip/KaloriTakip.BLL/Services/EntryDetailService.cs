using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class EntryDetailService
    {
        EntryDetailRepository entryDetailRepository;
        public EntryDetailService()
        {
            entryDetailRepository = new EntryDetailRepository();
        }
        public void Insert(List<EntryDetails> entryDetailsList)
        {
            entryDetailRepository.Insert(entryDetailsList);
        }

        public List<EntryDetails> GetEntryDetails(List<MealEntry> mealEntriesList)
        {
           return entryDetailRepository.GetEntryDetails(mealEntriesList);
        }
    }
}
