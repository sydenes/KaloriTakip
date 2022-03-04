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
        private User user;
        FoodCategoryService foodCategoryService;
        FoodService foodService;
        public MealAdd()
        {
            InitializeComponent();
        }

        public MealAdd(User user)
        {
            InitializeComponent();
            this.user = user;
            foodCategoryService = new FoodCategoryService();
            foodService = new FoodService();
        }
        List<FoodCategories> foodCategoriesList;
        private void MealAdd_Load(object sender, EventArgs e)
        {
            foodCategoriesList=foodCategoryService.GetCategories();
            cmbCategories.DataSource = foodCategoriesList;

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "FoodCategoriesID";

            cmbCategories.SelectedIndex = -1;
        }
        List<Food> foodList;
        int selectedID;
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvFoods.Items.Clear();
            selectedID = Convert.ToInt32(cmbCategories.SelectedIndex + 1);
            foodList = foodService.GetFoods(selectedID);
            FillListView(foodList);
        }

        private void lstvFoods_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi = lstvFoods.SelectedItems[0];
            lblCalorie.Text = lvi.SubItems[1].Text;
            lblCarbonh.Text = lvi.SubItems[2].Text;
            lblPro.Text = lvi.SubItems[3].Text;
            lblFat.Text = lvi.SubItems[4].Text;
        }
        //ListViewItem lvi;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi2 = new ListViewItem();
            string foodName = lstvFoods.SelectedItems[0].Text;
            lvi2.Text = foodName;
            lvi2.SubItems.Add(nudSerValue.Value.ToString());
            lstvAddedFoods.Items.Add(lvi2);
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
                foodList = foodService.GetFoodsBySearch(searchTxt);
                FillListView(foodList);
            }
            else
            {
                // foodList = foodService.GetFoodsBySearchWithCategory(searchTxt,selectedID);
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
    }
}
