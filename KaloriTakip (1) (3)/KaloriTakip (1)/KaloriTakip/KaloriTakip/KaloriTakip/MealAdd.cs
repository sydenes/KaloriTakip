using KaloriTakip.BLL.Services;
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
    public partial class MealAdd : Form
    {
        FoodCategoryService foodCategoryService;
        FoodService foodService;
        MealEntryService mealEntryService;
        EntryDetailService entryDetailService;
        public MealAdd()
        {
            InitializeComponent();
        }

        public MealAdd(MealEntry newEntry)
        {
            InitializeComponent();
            this.newEntry = newEntry;
            foodCategoryService = new FoodCategoryService();
            foodService = new FoodService();
            mealEntryService = new MealEntryService();
            entryDetailService = new EntryDetailService();
        }

        List<FoodCategories> foodCategoriesList;
        private void MealAdd_Load(object sender, EventArgs e)
        {
            foodCategoriesList=foodCategoryService.GetCategories();
            cmbCategories.DataSource = foodCategoriesList;

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "FoodCategoriesID";

            cmbCategories.SelectedIndex = -1;

            mealEntryService.InsertMealEntry(newEntry);
        }
        List<Food> foodList;
        int selectedID;
        private MealEntry newEntry;

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvFoods.Items.Clear();
            selectedID = Convert.ToInt32(cmbCategories.SelectedIndex + 1);
            foodList = foodService.GetFoods(selectedID);
            FillListView(foodList);
        }
        ListViewItem lviFood;
        private void lstvFoods_Click(object sender, EventArgs e)
        {
            lviFood = new ListViewItem();
            lviFood = lstvFoods.SelectedItems[0];
            lblCalorie.Text = lviFood.SubItems[1].Text;
            lblCarbonh.Text = lviFood.SubItems[2].Text;
            lblPro.Text = lviFood.SubItems[3].Text;
            lblFat.Text = lviFood.SubItems[4].Text;
        }
        EntryDetails entryDetails;
        List<EntryDetails> entryDetailsList = new List<EntryDetails>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Listview'e basma kısmı
            ListViewItem lvi2 = new ListViewItem();
            string foodName = lstvFoods.SelectedItems[0].Text;
            lvi2.Text = foodName;
            lvi2.SubItems.Add(nudSerValue.Value.ToString());
            lstvAddedFoods.Items.Add(lvi2);

            //EntryDetailsList'e basma kısmı
            int serValue = (int)nudSerValue.Value;
            entryDetails = new EntryDetails()
            {
                FoodID = (int)lstvFoods.SelectedItems[0].Tag,
                ServiceValue = serValue,
                TotalCalorie = serValue * Convert.ToDecimal(lviFood.SubItems[1].Text),
                TotalCarbonhydrates = serValue * Convert.ToDecimal(lviFood.SubItems[2].Text),
                TotalProtein = serValue * Convert.ToDecimal(lviFood.SubItems[3].Text),
                TotalFat = serValue * Convert.ToDecimal(lviFood.SubItems[4].Text),
                MealEntryID = newEntry.MealEntryID
            };
            entryDetailsList.Add(entryDetails);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstvAddedFoods.Items.Remove(lstvAddedFoods.SelectedItems[0]);
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            string searchTxt = txtSearchFood.Text;
            if (string.IsNullOrEmpty(cmbCategories.Text))
            {
                if (string.IsNullOrEmpty(searchTxt))
                {
                    lstvFoods.Items.Clear();
                }
                else
                {
                    foodList = foodService.GetFoodsBySearch(searchTxt);
                    FillListView(foodList);
                }
            }
            else
            {
                List<Food> newList = new List<Food>();
               foodList = foodService.GetFoods(selectedID);
                foreach (var item in foodList)
                {
                    if (item.FoodName.ToLower().Contains(searchTxt.ToLower()))
                    {
                        newList.Add(item);
                    }
                }
                FillListView(newList);
            };
        }

        private void FillListView(List<Food> newList)
        {
            lstvFoods.Items.Clear();
            ListViewItem lvi;
            foreach (var item in newList)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FoodName;
                lvi.SubItems.Add(item.CalorieForService.ToString());
                lvi.SubItems.Add(item.Carbonhydrates.ToString());
                lvi.SubItems.Add(item.Protein.ToString());
                lvi.SubItems.Add(item.Fat.ToString());
                lvi.SubItems.Add(item.Service.ToString());
                lvi.Tag = item.FoodID;

                lstvFoods.Items.Add(lvi);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            entryDetailService.Insert(entryDetailsList);
        }
    }
}
