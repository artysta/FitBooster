using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            AddProductToMeal objCalculatorsWindow = new AddProductToMeal();
            objCalculatorsWindow.Show();
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

    }
}
