using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Repositories
{
    public class FoodRepository
    {
        CalorieDbContext _context;
        public FoodRepository()
        {
            _context = new CalorieDbContext();
        }
        public List<Food> GetFoods(int categoryID)
        {
            List<Food> foodList = new List<Food>();
            foodList=_context.Foods.Where(a => a.FoodCategoriesID == categoryID).ToList();
            return foodList;
        }

        public List<Food> GetFoodsBySearch(string foodName)
        {
            List<Food> foodList = (from a in _context.Foods
                                   where a.FoodName.Contains(foodName)
                                   select a).ToList() ;
            return foodList;
        }

        public string GetFoodsById(int foodID)
        {
            string foodName = _context.Foods.Where(a => a.FoodID == foodID).SingleOrDefault().FoodName;
            return foodName;
        }
    }
}
