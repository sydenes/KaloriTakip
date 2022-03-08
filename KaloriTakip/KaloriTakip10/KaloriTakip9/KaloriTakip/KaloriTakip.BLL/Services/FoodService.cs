using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class FoodService
    {
        public FoodService()
        {
            foodRepository = new FoodRepository();
        }
        FoodRepository foodRepository;
        public List<Food> GetFoods(int categoryID)
        {
            return foodRepository.GetFoods(categoryID);
        }
        public List<Food> GetFoodsBySearch(string foodName)
        {
            return foodRepository.GetFoodsBySearch(foodName);
        }

        public string GetFoodsById(int foodID)
        {
            if (foodID<=0)
            {
                throw new Exception("Listeden ekleyeceğiniz besini seçiniz");
            }
            else
            {
                return foodRepository.GetFoodsById(foodID);
            }
        }
    }
}
