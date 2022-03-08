using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class FoodCategorie
    {
        public FoodCategorie()
        {
            Foods=new HashSet<Food>();
        }
        public int FoodCategorieID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //public int FoodID { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
