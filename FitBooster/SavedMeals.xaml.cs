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
    /// Interaction logic for SavedMeals.xaml
    /// </summary>
    public partial class SavedMeals : Window
    {
        public SavedMeals()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MP_Button_Click(object sender, RoutedEventArgs e)
        {
            MyProducts objMPWindow = new MyProducts();
            this.Visibility = Visibility.Hidden;
            objMPWindow.Top = 0;
            objMPWindow.Left = 300;
            objMPWindow.Show();
        }

        private void FD_Button_Click(object sender, RoutedEventArgs e)
        {
            FoodDiary objFDWindow = new FoodDiary();
            this.Visibility = Visibility.Hidden;
            objFDWindow.Top = 0;
            objFDWindow.Left = 300;
            objFDWindow.Show();
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
