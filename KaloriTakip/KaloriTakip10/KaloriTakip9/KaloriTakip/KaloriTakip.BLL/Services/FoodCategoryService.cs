using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class FoodCategoryService
    {
        public FoodCategoryService()
        {
            foodCategoryRepository = new FoodCategoryRepository();
        }
        FoodCategoryRepository foodCategoryRepository;
        public List<FoodCategorie> GetCategories()
        {
            return foodCategoryRepository.GetCategories();
        }
    }
}
