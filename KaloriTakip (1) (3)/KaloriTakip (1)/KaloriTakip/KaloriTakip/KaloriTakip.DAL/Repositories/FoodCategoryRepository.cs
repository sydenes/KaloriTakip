using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Repositories
{
    public class FoodCategoryRepository
    {
        CalorieDbContext _context;
        public FoodCategoryRepository()
        {
            _context = new CalorieDbContext();
        }
        public List<FoodCategories> GetCategories()
        {
            List<FoodCategories> catList = new List<FoodCategories>();
            catList = _context.FoodCategories.ToList();
            return catList;
        }
    }
}
