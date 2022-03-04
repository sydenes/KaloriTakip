using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class FoodCategories
    {
        public int FoodCategoriesID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //public int FoodID { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
