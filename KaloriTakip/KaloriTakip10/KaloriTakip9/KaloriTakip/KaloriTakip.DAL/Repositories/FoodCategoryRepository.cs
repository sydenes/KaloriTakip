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
        public List<FoodCategorie> GetCategories()
        {
            List<FoodCategorie> catList = new List<FoodCategorie>();
            catList = _context.FoodCategories.ToList();
            return catList;
        }
    }
}
