using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class MealsOfDay
    {
        public MealsOfDay()
        {
            MealEntries=new HashSet<MealEntry>();
        }
        public int MealsOfDayID { get; set; }
        public string MealName { get; set; }
        public virtual ICollection<MealEntry> MealEntries { get; set; }
    }
}
