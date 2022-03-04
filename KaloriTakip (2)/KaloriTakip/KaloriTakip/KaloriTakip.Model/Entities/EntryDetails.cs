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
        public decimal Gram { get; set; }
        public Food Food { get; set; }
        public ICollection<MealEntry> MealEntries { get; set; }
    }
}
