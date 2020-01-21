using System.Windows;
using System.Windows.Controls;
using FitBoosterLibrary;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for FoodDiary.xaml
    /// </summary>
    public partial class FoodDiary : Window
    {
        public FoodDiary()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            // Get tag of button.
            string mealType = ((Button)e.Source).Tag.ToString();
            AddProductToMeal addProductToMeal = new AddProductToMeal(this, mealType);
            addProductToMeal.Show();
        }
        
        private void SaveSet_Button_Click(object sender, RoutedEventArgs e)
        {
            if (AreListsEmpty()) return;

            Diet diet = new Diet("N/A", "N/A");

            for (int i = 0; i < breakfastProductsList.Items.Count; i++)
                diet.AddProduct((DietProduct)breakfastProductsList.Items[i]);

            for (int i = 0; i < lunchProductsList.Items.Count; i++)
                diet.AddProduct((DietProduct)lunchProductsList.Items[i]);

            for (int i = 0; i < dinnerProductsList.Items.Count; i++)
                diet.AddProduct((DietProduct)dinnerProductsList.Items[i]);

            IDietsProvider provider = new XMLDietsParser();

            provider.AddDiet(diet);

            MessageBox.Show("Set saved!");

            breakfastProductsList.Items.Clear();
            lunchProductsList.Items.Clear();
            dinnerProductsList.Items.Clear();
        }

        private void SMS_Button_Click(object sender, RoutedEventArgs e)
        {
            SavedMeals objSavedMealsWindow = new SavedMeals();
            if (!CloseDiary()) return;
            objSavedMealsWindow.Top = 0;
            objSavedMealsWindow.Left = 300;
            objSavedMealsWindow.Show();
        }
        
        private void MP_Button_Click(object sender, RoutedEventArgs e)
        {
            MyProducts objMyProductsWindow = new MyProducts();
            if (!CloseDiary()) return;
            objMyProductsWindow.Top = 0;
            objMyProductsWindow.Left = 300;
            objMyProductsWindow.Show();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            if (!CloseDiary()) return;
            objMainWindow.Top = 0;
            objMainWindow.Left = 300;
            objMainWindow.Show();
        }

        // Interface method.
        public void AddProductToList(DietProduct product, string mealType)
        {
            if (mealType.Equals("Breakfast"))
                breakfastProductsList.Items.Add(product);
            else if (mealType.Equals("Lunch"))
                lunchProductsList.Items.Add(product);
            else if (mealType.Equals("Dinner"))
                dinnerProductsList.Items.Add(product);
        }

        public bool CloseDiary()
        {
            // Close diary if the meal lists as empty.
            if (!AreListsEmpty())
                if (MessageBox.Show("You have unsaved meals! Do you really want to leave FoodDiary?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    return false;

            this.Close();
            return true;
        }

        public bool AreListsEmpty() =>
            breakfastProductsList.Items.Count == 0 &&
            lunchProductsList.Items.Count == 0 &&
            dinnerProductsList.Items.Count == 0;
    }
}
