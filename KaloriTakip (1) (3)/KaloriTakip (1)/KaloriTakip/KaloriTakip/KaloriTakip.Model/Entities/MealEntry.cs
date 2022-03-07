using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class MealEntry
    {
        public int MealEntryID { get; set; }
        public int UserID { get; set; }
        public int MealsOfDayID { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public MealsOfDay MealsOfDay{ get; set; }
        public User User { get; set; }
        public ICollection<EntryDetails> EntryDetail { get; set; }


    }
}
