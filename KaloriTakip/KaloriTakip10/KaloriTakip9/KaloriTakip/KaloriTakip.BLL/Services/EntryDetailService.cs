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
        public void Insert(List<EntryDetail> entryDetailsList)
        {
            entryDetailRepository.Insert(entryDetailsList);
        }

        public List<EntryDetail> GetEntryDetails(List<MealEntry> mealEntriesList)
        {
           return entryDetailRepository.GetEntryDetails(mealEntriesList);
        }

        public void Delete(int deleteID)
        {
            if (deleteID<=0)
            {
                throw new Exception("Silinecek besini seçiniz.");
            }
            else
            {
                entryDetailRepository.Delete(deleteID);
            }
        }
    }
}
