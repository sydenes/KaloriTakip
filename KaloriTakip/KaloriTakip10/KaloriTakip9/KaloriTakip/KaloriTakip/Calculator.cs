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
        //TODO: Update butonu
        //TODO: Try/Catch control
        //TODO: Activity, şifre değiştir


        private User user;

        MealEntryService mealEntryService;
        EntryDetailService entryDetailService;
        FoodService foodService;

        decimal calorieNeed=1600;
        decimal carbonhydratesNeed = 2300;
        decimal proteinNeed = 70;
        decimal fatNeed = 50;
        decimal calorieCurrent = 0;
        decimal carbonhydratesCurrent = 0;
        decimal proteinCurrent = 0;
        decimal fatCurrent = 0;

        List<MealEntry> mealEntriesList;
        List<EntryDetail> entryDetailsList;
        List<EntryDetail> breakfastList;
        List<EntryDetail> lunchList;
        List<EntryDetail> dinnerList;
        List<EntryDetail> firstSnackList;
        List<EntryDetail> secondSnackList;

        DateTime selectedDate;
        public Calculator()
        {
            InitializeComponent();
        }

        public Calculator(User user,DateTime date)
        {
            this.user = user;
            mealEntryService = new MealEntryService();
            entryDetailService = new EntryDetailService();
            foodService = new FoodService();
            InitializeComponent();
            selectedDate = date.Date;
        }

        public Calculator(User user)
        {
            InitializeComponent();
            this.user = user;
            mealEntryService = new MealEntryService();
            entryDetailService = new EntryDetailService();
            foodService = new FoodService();
            selectedDate = DateTime.Now;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            dtpDate.Value = selectedDate;
            LoadMethod();

        }

        private void LoadMethod()
        {
            
            if (user.Gender)
            {
                calorieNeed = 66 + 13.7M * (user.Weight) + 1.8M * (user.Height) - 4.7M * (DateTime.Now.Year - user.BirthDate.Year);
            }
            else
            {
                calorieNeed = 66 + 13.7M * (user.Weight) + 1.8M * (user.Height) - 4.7M * (DateTime.Now.Year - user.BirthDate.Year);
            }

            FillProgressBar();
        }


        UserService userService = new UserService();
        MealEntry newEntry = new MealEntry();

        private void btnBreakfeast_Click(object sender, EventArgs e)
        {
            AddMeal(Convert.ToInt32(btnBreakfeast.Tag), breakfastList);
        }
        private void btnFirstSnack_Click(object sender, EventArgs e)
        {
            AddMeal(Convert.ToInt32(btnFirstSnack.Tag), firstSnackList);
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            AddMeal(Convert.ToInt32(btnLunch.Tag), lunchList);
        }
        private void btnSecondSnack_Click(object sender, EventArgs e)
        {
            AddMeal(Convert.ToInt32(btnSecondSnack.Tag), secondSnackList);
        }
        private void btnDinner_Click(object sender, EventArgs e)
        {
            AddMeal(Convert.ToInt32(btnDinner.Tag), dinnerList);
        }
        private void AddMeal(int btnTag, List<EntryDetail> detailList)
        {
            newEntry.UserID = user.UserID;
            newEntry.MealsOfDayID = btnTag;
            newEntry.EntryDate = dtpDate.Value.Date;
            newEntry.UpdateDate = DateTime.Now;

            MealAdd mealAdd = new MealAdd(newEntry, detailList, user);
            this.Close();
            mealAdd.Show();
        }
        
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            FillProgressBar();
            ClearGroupBox();
        }

        private void FillProgressBar()
        {
            mealEntriesList = mealEntryService.GetUserMealEntries(dtpDate.Value.Date, user.UserID);
            entryDetailsList = entryDetailService.GetEntryDetails(mealEntriesList);

            breakfastList = new List<EntryDetail>();
            lunchList = new List<EntryDetail>();
            dinnerList = new List<EntryDetail>();
            firstSnackList = new List<EntryDetail>();
            secondSnackList = new List<EntryDetail>();
            calorieCurrent = 0;
            carbonhydratesCurrent = 0;
            proteinCurrent = 0;
            fatCurrent = 0;
            foreach (var item in entryDetailsList)
            {
                calorieCurrent += item.TotalCalorie;
                carbonhydratesCurrent += item.TotalCarbonhydrates;
                proteinCurrent += item.TotalProtein;
                fatCurrent += item.TotalFat;
            }
            lblCalorie.Text = $"{Convert.ToInt32(calorieCurrent).ToString()} / {Convert.ToInt32(calorieNeed).ToString()}";
            pbarCalorie.Value = Convert.ToInt32((calorieCurrent / calorieNeed) * 100);
            pbarCarbon.Value = Convert.ToInt32((carbonhydratesCurrent / carbonhydratesNeed) * 100);
            pbarPro.Value = Convert.ToInt32((proteinCurrent / proteinNeed) * 100);
            pbarFat.Value = Convert.ToInt32((fatCurrent / fatNeed) * 100);
            FillPanel();
        }

        private void ClearGroupBox()
        {
            List<GroupBox> groups = new List<GroupBox>();
            groups.Add(gbBF);
            groups.Add(gbD);
            groups.Add(gbFS);
            groups.Add(gbL);
            groups.Add(gbSS);
            foreach (var gb in groups)
            {
                gb.Controls[5].Text = "";
                gb.Controls[4].Text = "";
                gb.Controls[3].Text = "";
                gb.Controls[2].Text = "";
                gb.Controls[0].Text = "";
            }
        }

        private void FillPanel()
        {
            RemevoButtonFromPanel(pnlBreakfst);
            RemevoButtonFromPanel(pnlLunch);
            RemevoButtonFromPanel(pnlDinner);
            RemevoButtonFromPanel(pnlFirstSnack);
            RemevoButtonFromPanel(pnlSecondSnack);

            Button btn;
            int i = 0;
            foreach (var item in mealEntriesList)
            {
                int entryID = item.MealEntryID;
                foreach (var item2 in entryDetailsList)
                {
                    if (entryID == item2.MealEntryID)
                    {
                        int mealofId = item.MealsOfDayID;
                        btn = new Button();
                        //btn.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                        //btn.ForeColor = Color.Red;
                        btn.Text = foodService.GetFoodsById(item2.FoodID);
                        Dictionary<int, int> newDic = new Dictionary<int, int>();
                        newDic.Add(item2.EntryDetailID, item.MealsOfDayID);
                        btn.Tag = newDic;
                        
                        btn.Location = new Point(i, 20);
                        btn.Height = 60;
                        btn.Width = 80;
                        btn.Click += Button_Click;
                        btn.BackgroundImage= Image.FromFile("..\\..\\..\\KaloriTakip.Model\\Pictures\\"+ foodService.GetFoodsById(item2.FoodID)+".png");
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        switch (mealofId)
                        {
                            case 1:
                                pnlBreakfst.Controls.Add(btn);
                                breakfastList.Add(item2);
                                break;
                            case 2:
                                pnlFirstSnack.Controls.Add(btn);
                                firstSnackList.Add(item2);
                                break;

                            case 3:
                                pnlLunch.Controls.Add(btn);
                                lunchList.Add(item2);
                                break;
                            case 4:
                                pnlSecondSnack.Controls.Add(btn);
                                secondSnackList.Add(item2);
                                break;
                            case 5:
                                pnlDinner.Controls.Add(btn);
                                dinnerList.Add(item2);
                                break;

                        }
                        i += 80;
                    }
                }
                i = 0;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = new Button();
                btn = (Button)sender;
                Dictionary<int, int> newDic = btn.Tag as Dictionary<int, int>;
                //string foodName = btn.Text;
                int key = newDic.Keys.SingleOrDefault(); //DetailID
                int value = newDic.Values.SingleOrDefault(); //MealsofDayID

                foreach (var item in entryDetailsList)
                {
                    if (item.EntryDetailID == key)
                    {
                        switch (value)
                        {
                            case 1:
                                GroupBoxMethod(gbBF, item); //, foodName
                                return;
                            case 2:
                                GroupBoxMethod(gbFS, item);
                                return;
                            case 3:
                                GroupBoxMethod(gbL, item);
                                return;
                            case 4:
                                GroupBoxMethod(gbSS, item);
                                return;
                            case 5:
                                GroupBoxMethod(gbD, item);
                                return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GroupBoxMethod(GroupBox gb, EntryDetail detail) //,string fn
        {
            gb.Controls[5].Text = detail.ServiceValue.ToString(); ;
            gb.Controls[4].Text = detail.TotalCalorie.ToString(); ;
            gb.Controls[3].Text = detail.TotalCarbonhydrates.ToString();
            gb.Controls[2].Text = detail.TotalFat.ToString(); ;
            gb.Controls[0].Text = detail.TotalProtein.ToString(); ;
            //gb.Controls[8].Text = fn;
        }

        private void RemevoButtonFromPanel(Panel panel)
        {
            foreach (Button item in panel.Controls.OfType<Button>().ToList())
            {
                panel.Controls.Remove(item);
                item.Dispose();
            }
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings(user,dtpDate.Value.Date);
            this.Hide();
            userSettings.ShowDialog();
            LoadMethod();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailyReports totals = new DailyReports(dtpDate.Value.Date,user);
            this.Hide();
            totals.ShowDialog();
            LoadMethod();
            this.Show();

        }
    }
}
