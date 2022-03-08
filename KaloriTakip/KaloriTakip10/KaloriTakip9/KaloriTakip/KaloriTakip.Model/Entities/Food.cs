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
        public Food()
        {
            EntryDetail=new HashSet<EntryDetail>();
        }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public decimal Carbonhydrates { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }//Yağ Oranı
        public decimal CalorieForService { get; set; }
        public virtual ServiceType Service { get; set; }
        public string PicturePath { get; set; }
        public int FoodCategoriesID { get; set; }
        public virtual FoodCategorie FoodCategories { get; set; }
        public virtual ICollection<EntryDetail> EntryDetail { get; set; }
    }
}
