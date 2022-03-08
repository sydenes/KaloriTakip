using KaloriTakip.DAL.EntityConfigiration;
using KaloriTakip.DAL.Strategy;
using KaloriTakip.Enums;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL
{
    public class CalorieDbContext:DbContext
    {
        public CalorieDbContext() : base(@"Server=DESKTOP-DI00GF5\SQLSERVERBILADAM;Database=CalorieModel;Trusted_Connection=True;")
        {

            
            Database.SetInitializer(new KaloriTakipInitializeStrategy());


        }
        public DbSet<EntryDetail> EntryDetails { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategorie> FoodCategories { get; set; }
        public DbSet<MealEntry> MealEntries { get; set; }
        public DbSet<MealsOfDay> MealsOfDays { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new UserConfigiration());
            modelBuilder.Configurations.Add(new MealEntryConfigiration());
            
        }
    }
}
