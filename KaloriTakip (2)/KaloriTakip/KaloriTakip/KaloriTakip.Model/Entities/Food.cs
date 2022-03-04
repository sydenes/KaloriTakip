using KaloriTakip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int Gramaj { get; set; }
        public decimal Carbonhydrates { get; set; }
        public decimal Protein { get; set; }      
        public decimal Fat { get; set; }//Yağ Oranı
        public ServiceType Service { get; set; }
        public int FoodCategoriesID { get; set; }
        public FoodCategories FoodCategories { get; set; }
        


    }
}
