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

        private void SMS_Button_Click(object sender, RoutedEventArgs e)
        {
            SavedMeals objCalculatorsWindow = new SavedMeals();
            this.Visibility = Visibility.Hidden;
            objCalculatorsWindow.Show();
        }
        
        private void MP_Button_Click(object sender, RoutedEventArgs e)
        {
            MyProducts objCalculatorsWindow = new MyProducts();
            this.Visibility = Visibility.Hidden;
            objCalculatorsWindow.Show();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objCalculatorsWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objCalculatorsWindow.Show();
        }

    }
}
