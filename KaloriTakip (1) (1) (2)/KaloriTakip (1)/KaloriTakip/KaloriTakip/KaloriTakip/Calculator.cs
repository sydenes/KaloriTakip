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

        public Calculator(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        decimal calorieNeed;
        decimal carbonhydratesNeed=230;
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
            lblCalorie.Text =$"{calorieCurrent.ToString()} / {calorieNeed.ToString()}" ;
            pbarCalorie.Value = Convert.ToInt32((calorieCurrent / calorieNeed)*100);


            FoodCategories foodCategories = new FoodCategories()
            { CategoryName = "Meyve", Description = "Taze meyve dalından." };
            FoodCategories foodCategories2 = new FoodCategories()
            { CategoryName = "Sebze", Description = "Taze sebze topraktan." };

            food = new Food()
            {
                FoodName="Armut",
                Carbonhydrates=14,
                Protein=0.3M,
                Fat=0.2M,
                CalorieForService=47,
                Service=ServiceType.Quantity
            };
            MealsOfDay mealsOfDay = new MealsOfDay()
            {
                MealName = "Kahvaltı"
            };


            Deneme deneme = new Deneme();
            bool check = deneme.Deneme1(foodCategories2, food, mealsOfDay);
            MessageBox.Show(check == true ? "DB Değişti" : "DB başarısız");
        }
        Food food;
        EntryService entryService=new EntryService();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MealEntry mealEntry = new MealEntry()
            {
                UserID = user.UserID,
                EntryDate = dtpDate.Value,
                UpdateDate = DateTime.Now,
                MealsOfDayID = 1
            };
            EntryDetails entryDetails = new EntryDetails()
            {
                ServiceValue = Convert.ToInt32(nudSerValue.Value),
                TotalCalorie = Convert.ToInt32(nudSerValue.Value) * food.CalorieForService,
                TotalCarbonhydrates= Convert.ToInt32(nudSerValue.Value) * food.Carbonhydrates,
                TotalProtein = Convert.ToInt32(nudSerValue.Value) * food.Protein,
                TotalFat = Convert.ToInt32(nudSerValue.Value) * food.Fat,

                FoodID =1
            };
            bool check = entryService.Insert(entryDetails,mealEntry);
            MessageBox.Show(check == true ? "Öğün girildi" : "Öğün giriş başarısız");
            calorieCurrent = entryDetails.TotalCalorie;
            carbonhydratesCurrent = entryDetails.TotalCarbonhydrates;
            proteinCurrent = entryDetails.TotalProtein;
            fatCurrent = entryDetails.TotalFat;

            pbarCalorie.Value = Convert.ToInt32((calorieCurrent / calorieNeed) * 100);            
            pbarCarbon.Value = Convert.ToInt32((carbonhydratesCurrent / carbonhydratesNeed) * 100);
            pbarPro.Value = Convert.ToInt32((proteinCurrent / proteinNeed) * 100);
            pbarFat.Value = Convert.ToInt32((fatCurrent / fatNeed) * 100);
            lblCalorie.Text = $"{calorieCurrent.ToString()} / {calorieNeed.ToString()}";
            

            
            //TODO:onay butonu ile sepet db'ye gönderilecek, oradan calculator'da user verileri güncellenecek
            //TODO:FlowLayoutPanel: wrapcontext, autoscrool,dock (öğünler)
            //TODO:Metot ile kişinin datetimepicker'a göre bilgiler gelecek

            //TODO:Food tablosuna pickerpath eklenecek (Foto için)
        }
        UserService userService = new UserService();
        private void button1_Click(object sender, EventArgs e)
        {
            MealAdd mealAdd = new MealAdd(user);
            this.Hide();
            mealAdd.ShowDialog();
            userService.Activite(user.UserID);
        }
    }
}
