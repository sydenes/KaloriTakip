using KaloriTakip.BLL.Services;
using KaloriTakip.Enums;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakip
{
    public partial class Calculator : Form
    {
        private User user;

        public Calculator()
        {
            InitializeComponent();
        }
        MealEntryService mealEntryService;
        EntryDetailService entryDetailService;
        public Calculator(User user)
        {
            InitializeComponent();
            this.user = user;
            mealEntryService = new MealEntryService();
            entryDetailService = new EntryDetailService();
        }
        decimal calorieNeed;
        decimal carbonhydratesNeed=2300;
        decimal proteinNeed=70;
        decimal fatNeed=50;
        decimal calorieCurrent = 0;
        decimal carbonhydratesCurrent = 0;
        decimal proteinCurrent = 0;
        decimal fatCurrent = 0;

        private void Calculator_Load(object sender, EventArgs e)
        {

            if (user.Gender)
            {
                calorieNeed = 66 + 13.7M * (user.Weight) + 1.8M * (user.Height) - 4.7M * (DateTime.Now.Year - user.BirthDate.Year);
            }
            else
            {
                calorieNeed = 66 + 13.7M * (user.Weight) + 1.8M * (user.Height) - 4.7M * (DateTime.Now.Year - user.BirthDate.Year);
            }

            #region DBCreating
            if (user.isActivate == false)
            {

                List<FoodCategories> foodCategoriesList = new List<FoodCategories>();
                foodCategoriesList.Add(new FoodCategories { CategoryName = "Atıştırmalık", Description = "AburCubur" });
                foodCategoriesList.Add(new FoodCategories { CategoryName = "Çorba", Description = "Sımsıcak" });
                foodCategoriesList.Add(new FoodCategories { CategoryName = "Sebze", Description = "Taze sebze topraktan." });
                foodCategoriesList.Add(new FoodCategories { CategoryName = "İçecek", Description = "LıkırLıkır" });

                List<Food> foodList = new List<Food>();
                foodList.Add(new Food() { FoodName = "Cips", Carbonhydrates = 56, Protein = 0.7M, Fat = 0.5M, CalorieForService = 58, Service = ServiceType.Quantity, FoodCategoriesID = 1 });
                foodList.Add(new Food() { FoodName = "Çikolata", Carbonhydrates = 45, Protein = 0.6M, Fat = 0.4M, CalorieForService = 65, Service = ServiceType.Quantity, FoodCategoriesID = 1 });
                foodList.Add(new Food() { FoodName = "Ezogelin", Carbonhydrates = 23, Protein = 0.8M, Fat = 0.3M, CalorieForService = 45, Service = ServiceType.Cup, FoodCategoriesID = 2 });
                foodList.Add(new Food() { FoodName = "Lahana", Carbonhydrates = 78, Protein = 0.2M, Fat = 0.1M, CalorieForService = 27, Service = ServiceType.Gram, FoodCategoriesID = 3 });
                foodList.Add(new Food() { FoodName = "Kola", Carbonhydrates = 64, Protein = 0.3M, Fat = 0.4M, CalorieForService = 74, Service = ServiceType.Cup, FoodCategoriesID = 4 });
                foodList.Add(new Food() { FoodName = "Gazoz", Carbonhydrates = 12, Protein = 0.8M, Fat = 0.3M, CalorieForService = 41, Service = ServiceType.Cup, FoodCategoriesID = 4 });

                List<MealsOfDay> mealsOfDaysList = new List<MealsOfDay>();
                mealsOfDaysList.Add(new MealsOfDay() { MealName = "Kahvaltı" });
                mealsOfDaysList.Add(new MealsOfDay() { MealName = "Öğle" });
                mealsOfDaysList.Add(new MealsOfDay() { MealName = "Akşam" });

                Deneme deneme = new Deneme();
                deneme.AddCategories(foodCategoriesList); //Kategorileri DB'ye toplu basan metot
                deneme.AddFoods(foodList); //Food'ları DB'ye toplu basan metot
                deneme.AddMealsOfDay(mealsOfDaysList);
            }
            #endregion

            List<MealEntry> mealEntriesList= mealEntryService.GetUserMealEntries(dtpDate.Value.Date,user.UserID);

            List<EntryDetails> entryDetailsList= entryDetailService.GetEntryDetails(mealEntriesList);

            foreach (var item in entryDetailsList)
            {
                calorieCurrent += item.TotalCalorie;
                carbonhydratesCurrent += item.TotalCarbonhydrates;
                proteinCurrent += item.TotalProtein;
                fatCurrent += item.TotalFat;
            }
            int i = 0;
            foreach (var item in mealEntriesList)
            {
                int mealofId = item.MealsOfDayID;
                foreach (var item2 in entryDetailsList)
                {
                    i += 40;
                    switch (mealofId)
                    {
                        case 1:
                            panel1.Controls.Add(new Label { Text=item2.FoodID.ToString(), Left=i+40});  //TODO: Yeni label'lar sıralı eklenecek
                            break;
                    }
                    //GetFoodById(item2.FoodID);
                }
            }

            lblCalorie.Text = $"{calorieCurrent.ToString()} / {calorieNeed.ToString()}";
            pbarCalorie.Value = Convert.ToInt32((calorieCurrent / calorieNeed) * 100);
            pbarCarbon.Value = Convert.ToInt32((carbonhydratesCurrent / carbonhydratesNeed) * 100);
            pbarPro.Value = Convert.ToInt32((proteinCurrent / proteinNeed) * 100);
            pbarFat.Value = Convert.ToInt32((fatCurrent / fatNeed) * 100);

            

        }
        Food food;
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Deneme ProgressBars
            //MealEntry mealEntry = new MealEntry()
            //{
            //    UserID = user.UserID,
            //    EntryDate = dtpDate.Value,
            //    UpdateDate = DateTime.Now,
            //    MealsOfDayID = 1
            //};
            //EntryDetails entryDetails = new EntryDetails()
            //{
            //    ServiceValue = Convert.ToInt32(nudSerValue.Value),
            //    TotalCalorie = Convert.ToInt32(nudSerValue.Value) * food.CalorieForService,
            //    TotalCarbonhydrates = Convert.ToInt32(nudSerValue.Value) * food.Carbonhydrates,
            //    TotalProtein = Convert.ToInt32(nudSerValue.Value) * food.Protein,
            //    TotalFat = Convert.ToInt32(nudSerValue.Value) * food.Fat,

            //    FoodID = 1
            //};
            //bool check = entryService.Insert(entryDetails, mealEntry);
            //MessageBox.Show(check == true ? "Öğün girildi" : "Öğün giriş başarısız");
            //calorieCurrent = entryDetails.TotalCalorie;
            //carbonhydratesCurrent = entryDetails.TotalCarbonhydrates;
            //proteinCurrent = entryDetails.TotalProtein;
            //fatCurrent = entryDetails.TotalFat;

            //pbarCalorie.Value = Convert.ToInt32((calorieCurrent / calorieNeed) * 100);
            //pbarCarbon.Value = Convert.ToInt32((carbonhydratesCurrent / carbonhydratesNeed) * 100);
            //pbarPro.Value = Convert.ToInt32((proteinCurrent / proteinNeed) * 100);
            //pbarFat.Value = Convert.ToInt32((fatCurrent / fatNeed) * 100);
            //lblCalorie.Text = $"{calorieCurrent.ToString()} / {calorieNeed.ToString()}";
            #endregion

            //TODO:onay butonu ile sepet db'ye gönderilecek, oradan calculator'da user verileri güncellenecek
            //TODO:Metot ile kişinin datetimepicker'a göre bilgiler gelecek

            //TODO:Food tablosuna pickerpath eklenecek (Foto için)
        }
        UserService userService = new UserService();
        MealEntry newEntry = new MealEntry();
        private void button1_Click(object sender, EventArgs e)
        {
            AddMeal(Convert.ToInt32(btnBreakfeast.Tag));
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            AddMeal(Convert.ToInt32(btnLunch.Tag));
        }
        private void AddMeal(int btnTag)
        {
            newEntry.UserID = user.UserID;
            newEntry.MealsOfDayID = btnTag; //buton'un tag'inden gelecek
            newEntry.EntryDate = dtpDate.Value.Date;
            newEntry.UpdateDate = DateTime.Now;

            MealAdd mealAdd = new MealAdd(newEntry);
            this.Hide();
            mealAdd.ShowDialog();
            userService.Activite(user.UserID);
        }

        
    }
}
