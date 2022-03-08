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

        EntryDetail entryDetails;
        List<EntryDetail> entryDetailsList = new List<EntryDetail>();
        List<FoodCategorie> foodCategoriesList;
        List<Food> foodList;
        private MealEntry newEntry;

        int selectedID;
        ListViewItem lviFood;
        User user;
        public MealAdd()
        {
            InitializeComponent();
        }
        
        public MealAdd(MealEntry newEntry,List<EntryDetail> detailList,User user)
        {
            InitializeComponent();
            this.user = user;

            this.newEntry = newEntry;
            foodCategoryService = new FoodCategoryService();
            foodService = new FoodService();
            mealEntryService = new MealEntryService();
            entryDetailService = new EntryDetailService();
            entryDetailsList = detailList;
        }

        
        private void MealAdd_Load(object sender, EventArgs e)
        {
            foodCategoriesList=foodCategoryService.GetCategories();
            cmbCategories.DataSource = foodCategoriesList;

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "FoodCategorieID";

            cmbCategories.SelectedIndex = -1;

            mealEntryService.InsertMealEntry(newEntry,user.UserID);

            FillAddedListView();
        }

        private void FillAddedListView()
        {
            lstvAddedFoods.Items.Clear();
            ListViewItem lvi2;
            foreach (var item in entryDetailsList)
            {
                lvi2 = new ListViewItem();
                lvi2.Text = foodService.GetFoodsById(item.FoodID);
                lvi2.Tag = item.EntryDetailID;
                lvi2.SubItems.Add(item.ServiceValue.ToString());
                lstvAddedFoods.Items.Add(lvi2);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvFoods.Items.Clear();
            selectedID = Convert.ToInt32(cmbCategories.SelectedIndex + 1);
            foodList = foodService.GetFoods(selectedID);
            FillListView(foodList);
        }
        
        private void lstvFoods_Click(object sender, EventArgs e)
        {
            lviFood = new ListViewItem();
            lviFood = lstvFoods.SelectedItems[0];
            lblCalorie.Text = lviFood.SubItems[1].Text;
            lblCarbonh.Text = lviFood.SubItems[2].Text;
            lblPro.Text = lviFood.SubItems[3].Text;
            lblFat.Text = lviFood.SubItems[4].Text;
            pboxFoodImage.Image = Image.FromFile(lviFood.SubItems[6].Text);


            pboxFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = true;
            try
            {
                //EntryDetailsList'e basma kısmı
                int serValue;
                if ((int)nudSerValue.Value<0)
                {
                    throw new Exception("Servis değerini doğru giriniz");
                }
                else
                {

                     serValue= (int)nudSerValue.Value;
                }
                int foodId = (int)lstvFoods.SelectedItems[0].Tag;
                bool check = false;
                int index = 0;
                foreach (var item in entryDetailsList)
                {
                    if (item.FoodID == foodId)
                    {
                        check = true;
                        break;
                    }
                    index++;
                }
                if (check == false)
                {
                    entryDetails = new EntryDetail()
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
                else
                {
                    //UPDATE için bu kod direkt alınacak
                    entryDetailsList[index].ServiceValue += serValue;
                    serValue = entryDetailsList[index].ServiceValue;
                    entryDetailsList[index].TotalCalorie = serValue * Convert.ToDecimal(lviFood.SubItems[1].Text);
                    entryDetailsList[index].TotalCarbonhydrates = serValue * Convert.ToDecimal(lviFood.SubItems[2].Text);
                    entryDetailsList[index].TotalProtein = serValue * Convert.ToDecimal(lviFood.SubItems[3].Text);
                    entryDetailsList[index].TotalFat = serValue * Convert.ToDecimal(lviFood.SubItems[4].Text);
                }

                FillAddedListView(); //Listview'e basan metot
                ClearGroupBox();
                btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ClearGroupBox()
        {
            pboxFoodImage.Image=null;
            nudSerValue.Value = 0;
            lblCalorie.Text = "";
            lblCarbonh.Text = "";
            lblFat.Text = "";
            lblPro.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int deleteID = (int)lstvAddedFoods.SelectedItems[0].Tag;
            foreach (var item in entryDetailsList)
            {
                if (item.EntryDetailID == (int)lstvAddedFoods.SelectedItems[0].Tag)
                {
                    entryDetailService.Delete(deleteID);
                }
            }
            entryDetailsList.RemoveAt(lstvAddedFoods.SelectedItems[0].Index);
            lstvAddedFoods.Items.Remove(lstvAddedFoods.SelectedItems[0]);
            btnDelete.Enabled = false;
            btnConfirm.Enabled = true;
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
                lvi.SubItems.Add(item.PicturePath.ToString());
                lvi.Tag = item.FoodID;

                lstvFoods.Items.Add(lvi);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                entryDetailService.Insert(entryDetailsList);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstvAddedFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void MealAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Calculator calculator = new Calculator(user, newEntry.EntryDate);
            calculator.Show();
        }

        private void lstvFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }
    }
}
