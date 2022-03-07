using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class EntryDetails
    {
        public int EntryDetailsID { get; set; }
        public int FoodID { get; set; }
        public int ServiceValue { get; set; }
        public decimal TotalCalorie { get; set; }
        public decimal TotalCarbonhydrates { get; set; }
        public decimal TotalProtein { get; set; }
        public decimal TotalFat { get; set; }
        public int MealEntryID { get; set; }
        public Food Food { get; set; }
        public MealEntry MealEntries { get; set; }
    }
}
