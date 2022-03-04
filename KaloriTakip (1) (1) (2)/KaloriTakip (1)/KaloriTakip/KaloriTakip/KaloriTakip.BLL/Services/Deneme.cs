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
        public bool Deneme1(FoodCategories cat, Food food,MealsOfDay ofDay)
        {
            return denemeRepo.Deneme1(cat,food,ofDay);
        }
    }
}
