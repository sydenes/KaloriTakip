using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class EntryService
    {
        public EntryService()
        {
            entryDetailRepository = new EntryDetailRepository() ;
        }
        EntryDetailRepository entryDetailRepository;
        public bool Insert(EntryDetails entryDetail,MealEntry mealEntry)
        {
            return entryDetailRepository.Insert(entryDetail, mealEntry);
        }
    }
}
