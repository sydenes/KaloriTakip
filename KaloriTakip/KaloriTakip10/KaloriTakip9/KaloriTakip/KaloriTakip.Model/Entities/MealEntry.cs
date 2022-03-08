using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class MealEntry
    {
        public MealEntry()
        {
            EntryDetail=new HashSet<EntryDetail>();
        }
        public int MealEntryID { get; set; }
        public int UserID { get; set; }
        public int MealsOfDayID { get; set; }
        public virtual DateTime EntryDate { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual MealsOfDay MealsOfDay{ get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<EntryDetail> EntryDetail { get; set; }
    }
}
