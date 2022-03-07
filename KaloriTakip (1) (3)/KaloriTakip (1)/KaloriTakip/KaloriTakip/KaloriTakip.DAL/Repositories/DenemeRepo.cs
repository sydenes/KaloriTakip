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
        public void AddCategories(List<FoodCategories> foodCategoriesList)
        {
            foreach (var item in foodCategoriesList)
            {
                _context.FoodCategories.Add(item);
            }
            _context.SaveChanges();
        }

        public void AddFoods(List<Food> foodList)
        {
            foreach (var item in foodList)
            {
                _context.Foods.Add(item);
            }
            _context.SaveChanges();
        }

        public void AddMealsOfDay(List<MealsOfDay> mealsOfDaysList)
        {
            foreach (var item in mealsOfDaysList)
            {
                _context.MealsOfDays.Add(item);
            }
            _context.SaveChanges();
        }
    }
}
