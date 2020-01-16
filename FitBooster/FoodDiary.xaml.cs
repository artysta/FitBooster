using System.Windows;
using System.Windows.Controls;
using FitBoosterLibrary;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for FoodDiary.xaml
    /// </summary>
    public partial class FoodDiary : Window, IFoodDiaryWindow
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

        }
        private void SMS_Button_Click(object sender, RoutedEventArgs e)
        {
            SavedMeals objSavedMealsWindow = new SavedMeals();
            this.Visibility = Visibility.Hidden;
            objSavedMealsWindow.Top = 0;
            objSavedMealsWindow.Left = 300;
            objSavedMealsWindow.Show();
        }
        
        private void MP_Button_Click(object sender, RoutedEventArgs e)
        {
            MyProducts objMyProductsWindow = new MyProducts();
            this.Visibility = Visibility.Hidden;
            objMyProductsWindow.Top = 0;
            objMyProductsWindow.Left = 300;
            objMyProductsWindow.Show();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
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

    }
}
