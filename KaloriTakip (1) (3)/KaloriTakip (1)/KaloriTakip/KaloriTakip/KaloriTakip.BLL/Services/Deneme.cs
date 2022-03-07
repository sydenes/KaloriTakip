using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class Deneme
    {
        DenemeRepo denemeRepo = new DenemeRepo();
        public void AddCategories(List<FoodCategories> foodCategoriesList)
        {
            denemeRepo.AddCategories(foodCategoriesList);
        }

        public void AddFoods(List<Food> foodList)
        {
            denemeRepo.AddFoods(foodList);
        }

        public void AddMealsOfDay(List<MealsOfDay> mealsOfDaysList)
        {
            denemeRepo.AddMealsOfDay(mealsOfDaysList);
        }
    }
}
