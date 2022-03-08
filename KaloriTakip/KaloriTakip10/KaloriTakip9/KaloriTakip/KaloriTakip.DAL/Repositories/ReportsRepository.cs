using KaloriTakip.Model.Entities;
using KaloriTakip.Model.TempleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Repositories
{
    public class ReportsRepository
    {
        CalorieDbContext _context;
        public ReportsRepository()
        {
            _context = new CalorieDbContext();
        }

       

        public List<List<CategoryReports>> GetReportsByCategoryAsIntervalWeek(User user,DateTime dateTime) //List içinde List döndürmece
        {
            DateTime dateTime1 = dateTime.AddDays(-7).Date;
            DateTime dateTime2 = dateTime.Date;
            List<CategoryReports> catRepUser = (from me in _context.MealEntries
                                                join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                                join f in _context.Foods on ed.FoodID equals f.FoodID
                                                join fc in _context.FoodCategories on f.FoodCategoriesID equals fc.FoodCategorieID
                                                where me.UserID == user.UserID && me.EntryDate>=dateTime1 && me.EntryDate<=dateTime2 
                                                group new { f, ed, fc } by new { f.FoodCategoriesID } into a
                                                select new CategoryReports
                                                {
                                                    CategoryID = a.Key.FoodCategoriesID,
                                                    CategoryName = a.Select(x => x.fc.CategoryName).FirstOrDefault(),
                                                    TotalSerValue = a.Sum(t => t.ed.ServiceValue)
                                                }).ToList();
            List<CategoryReports> catRepOthers = (from me in _context.MealEntries
                                                  join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                                  join f in _context.Foods on ed.FoodID equals f.FoodID
                                                  join fc in _context.FoodCategories on f.FoodCategoriesID equals fc.FoodCategorieID
                                                  where me.UserID != user.UserID && me.EntryDate>= dateTime1 && me.EntryDate <= dateTime2
                                                  group new { f, ed, fc } by new { f.FoodCategoriesID } into a
                                                  select new CategoryReports
                                                  {
                                                      CategoryID = a.Key.FoodCategoriesID,
                                                      CategoryName = a.Select(x => x.fc.CategoryName).FirstOrDefault(),
                                                      TotalSerValue = a.Sum(t => t.ed.ServiceValue)
                                                  }).ToList();
            List<List<CategoryReports>> catRepList = new List<List<CategoryReports>>();
            catRepList.Add(catRepUser);
            catRepList.Add(catRepOthers);
            return catRepList;
        }
        public List<List<CategoryReports>> GetReportsByCategoryAsIntervalMounth(User user, DateTime dateTime) //List içinde List döndürmece
        {
            List<CategoryReports> catRepUser = (from me in _context.MealEntries
                                                join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                                join f in _context.Foods on ed.FoodID equals f.FoodID
                                                join fc in _context.FoodCategories on f.FoodCategoriesID equals fc.FoodCategorieID
                                                where me.UserID == user.UserID && me.EntryDate.Month==dateTime.Date.Month
                                                group new { f, ed, fc } by new { f.FoodCategoriesID } into a
                                                select new CategoryReports
                                                {
                                                    CategoryID = a.Key.FoodCategoriesID,
                                                    CategoryName = a.Select(x => x.fc.CategoryName).FirstOrDefault(),
                                                    TotalSerValue = a.Sum(t => t.ed.ServiceValue)
                                                }).ToList();
            List<CategoryReports> catRepOthers = (from me in _context.MealEntries
                                                  join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                                  join f in _context.Foods on ed.FoodID equals f.FoodID
                                                  join fc in _context.FoodCategories on f.FoodCategoriesID equals fc.FoodCategorieID
                                                  where me.UserID != user.UserID && me.EntryDate.Month == dateTime.Date.Month
                                                  group new { f, ed, fc } by new { f.FoodCategoriesID } into a
                                                  select new CategoryReports
                                                  {
                                                      CategoryID = a.Key.FoodCategoriesID,
                                                      CategoryName = a.Select(x => x.fc.CategoryName).FirstOrDefault(),
                                                      TotalSerValue = a.Sum(t => t.ed.ServiceValue)
                                                  }).ToList();
            List<List<CategoryReports>> catRepList = new List<List<CategoryReports>>();
            catRepList.Add(catRepUser);
            catRepList.Add(catRepOthers);
            return catRepList;
        }
        public List<List<CalorieByMeals>> GetReportsByMealsAsIntervalWeek(User user,DateTime dateTime)
        {
            DateTime dateTime1 = dateTime.AddDays(-7).Date;
            DateTime dateTime2 = dateTime.Date;
            List<CalorieByMeals> mealRepUser= (from me in _context.MealEntries
                                               join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                               join mod in _context.MealsOfDays on me.MealsOfDayID equals mod.MealsOfDayID
                                               where me.UserID == user.UserID && me.EntryDate >= dateTime1 && me.EntryDate <= dateTime2
                                               group new { ed,me,mod } by new {me.MealsOfDayID } into a
                                               select new CalorieByMeals
                                               {
                                                   MealsOfDaysId = a.Key.MealsOfDayID,
                                                   MealsOfDayName=a.Select(x=> x.mod.MealName).FirstOrDefault(),
                                                   TotalCalorie=a.Sum(x=>x.ed.TotalCalorie)
                                               }).ToList();
            List<CalorieByMeals> mealOtherUser = (from me in _context.MealEntries
                                                join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                                join mod in _context.MealsOfDays on me.MealsOfDayID equals mod.MealsOfDayID
                                                where me.UserID != user.UserID && me.EntryDate >= dateTime1 && me.EntryDate <= dateTime2
                                                  group new { ed, me,mod } by new { me.MealsOfDayID } into a
                                                select new CalorieByMeals
                                                {
                                                    MealsOfDaysId = a.Key.MealsOfDayID,
                                                    MealsOfDayName=a.Select(x=> x.mod.MealName).FirstOrDefault(),

                                                    TotalCalorie = a.Sum(x => x.ed.TotalCalorie)
                                                }).ToList();
            List<List<CalorieByMeals>> calorieByMealsList = new List<List<CalorieByMeals>>();
            calorieByMealsList.Add(mealRepUser);
            calorieByMealsList.Add(mealOtherUser);
            return calorieByMealsList;

        }
        public List<List<CalorieByMeals>> GetReportsByMealsAsIntervalMounth(User user,DateTime dateTime)
        {
            List<CalorieByMeals> mealRepUser = (from me in _context.MealEntries
                                                join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                                join mod in _context.MealsOfDays on me.MealsOfDayID equals mod.MealsOfDayID
                                                where me.UserID == user.UserID && me.EntryDate.Month == dateTime.Date.Month
                                                group new { ed, me, mod } by new { me.MealsOfDayID } into a
                                                select new CalorieByMeals
                                                {
                                                    MealsOfDaysId = a.Key.MealsOfDayID,
                                                    MealsOfDayName = a.Select(x => x.mod.MealName).FirstOrDefault(),
                                                    TotalCalorie = a.Sum(x => x.ed.TotalCalorie)
                                                }).ToList();
            List<CalorieByMeals> mealOtherUser = (from me in _context.MealEntries
                                                  join ed in _context.EntryDetails on me.MealEntryID equals ed.MealEntryID
                                                  join mod in _context.MealsOfDays on me.MealsOfDayID equals mod.MealsOfDayID
                                                  where me.UserID != user.UserID && me.EntryDate.Month == dateTime.Date.Month
                                                  group new { ed, me, mod } by new { me.MealsOfDayID } into a
                                                  select new CalorieByMeals
                                                  {
                                                      MealsOfDaysId = a.Key.MealsOfDayID,
                                                      MealsOfDayName = a.Select(x => x.mod.MealName).FirstOrDefault(),

                                                      TotalCalorie = a.Sum(x => x.ed.TotalCalorie)
                                                  }).ToList();
            List<List<CalorieByMeals>> calorieByMealsList = new List<List<CalorieByMeals>>();
            calorieByMealsList.Add(mealRepUser);
            calorieByMealsList.Add(mealOtherUser);
            return calorieByMealsList;

        }

    }

}
