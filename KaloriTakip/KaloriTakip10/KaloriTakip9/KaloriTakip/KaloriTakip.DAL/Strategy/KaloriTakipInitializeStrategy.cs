using KaloriTakip.Enums;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Strategy
{
     class KaloriTakipInitializeStrategy:DropCreateDatabaseIfModelChanges<CalorieDbContext>
    {
        protected override void Seed(CalorieDbContext context)
        {
         
            List<FoodCategorie> foodCategoriesList = new List<FoodCategorie>();
            foodCategoriesList.Add(new FoodCategorie { CategoryName = "Atıştırmalık", Description = "AburCubur" });
            foodCategoriesList.Add(new FoodCategorie { CategoryName = "Çorba", Description = "Sımsıcak" });
            foodCategoriesList.Add(new FoodCategorie { CategoryName = "Sebze", Description = "Taze sebze topraktan." });
            foodCategoriesList.Add(new FoodCategorie { CategoryName = "İçecek", Description = "LıkırLıkır" });

            List<Food> foodList = new List<Food>();
            foodList.Add(new Food() { FoodName = "Cips", Carbonhydrates = 56, Protein = 0.7M, Fat = 0.5M, CalorieForService = 58, Service = ServiceType.Quantity, FoodCategoriesID = 1, PicturePath = "..\\..\\..\\KaloriTakip.Model\\Pictures\\Cips.png" });
            foodList.Add(new Food() { FoodName = "Çikolata", Carbonhydrates = 45, Protein = 0.6M, Fat = 0.4M, CalorieForService = 65, Service = ServiceType.Quantity, FoodCategoriesID = 1, PicturePath = "..\\..\\..\\KaloriTakip.Model\\Pictures\\Çikolata.png" });
            foodList.Add(new Food() { FoodName = "Ezogelin", Carbonhydrates = 23, Protein = 0.8M, Fat = 0.3M, CalorieForService = 45, Service = ServiceType.Cup, FoodCategoriesID = 2, PicturePath = "..\\..\\..\\KaloriTakip.Model\\Pictures\\Ezogelin.png" });
            foodList.Add(new Food() { FoodName = "Lahana", Carbonhydrates = 78, Protein = 0.2M, Fat = 0.1M, CalorieForService = 27, Service = ServiceType.Gram, FoodCategoriesID = 3, PicturePath = "..\\..\\..\\KaloriTakip.Model\\Pictures\\Lahana.png" });
            foodList.Add(new Food() { FoodName = "Kola", Carbonhydrates = 64, Protein = 0.3M, Fat = 0.4M, CalorieForService = 74, Service = ServiceType.Cup, FoodCategoriesID = 4, PicturePath = "..\\..\\..\\KaloriTakip.Model\\Pictures\\Kola.png" });
            foodList.Add(new Food() { FoodName = "Gazoz", Carbonhydrates = 12, Protein = 0.8M, Fat = 0.3M, CalorieForService = 41, Service = ServiceType.Cup, FoodCategoriesID = 4, PicturePath = "..\\..\\..\\KaloriTakip.Model\\Pictures\\Gazoz.png" });

            List<MealsOfDay> mealsOfDaysList = new List<MealsOfDay>();
            mealsOfDaysList.Add(new MealsOfDay() { MealName = "Kahvaltı" });
            mealsOfDaysList.Add(new MealsOfDay() { MealName = "1.AraÖğün" });
            mealsOfDaysList.Add(new MealsOfDay() { MealName = "Öğle" });
            mealsOfDaysList.Add(new MealsOfDay() { MealName = "2.AraÖğün" });
            mealsOfDaysList.Add(new MealsOfDay() { MealName = "Akşam" });

            context.FoodCategories.AddRange(foodCategoriesList);
            context.Foods.AddRange(foodList);
            context.MealsOfDays.AddRange(mealsOfDaysList);
            context.SaveChanges();
            //Deneme deneme = new Deneme();
            //deneme.AddCategories(foodCategoriesList); //Kategorileri DB'ye toplu basan metot
            //deneme.AddFoods(foodList); //Food'ları DB'ye toplu basan metot
            //deneme.AddMealsOfDay(mealsOfDaysList);
        }
    }
}
