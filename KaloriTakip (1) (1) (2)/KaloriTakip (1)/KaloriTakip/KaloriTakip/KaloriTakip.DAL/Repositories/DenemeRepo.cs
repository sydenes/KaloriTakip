using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Repositories
{
    public class DenemeRepo
    {
        public DenemeRepo()
        {
            _context = new CalorieDbContext();
        }
        CalorieDbContext _context;
        public bool Deneme1(FoodCategories cat, Food food, MealsOfDay ofDay)
        {
            _context.FoodCategories.Add(cat);
            _context.Foods.Add(food);
            _context.MealsOfDays.Add(ofDay);

            return _context.SaveChanges() > 0;
        }
    }
}
