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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            FoodDiary objFoodDiaryWindow = new FoodDiary();
            this.Visibility = Visibility.Hidden;
            objFoodDiaryWindow.Show();
        }

        private void Calc_btn_Click(object sender, RoutedEventArgs e)
        {
            Calculators objCalculatorsWindow = new Calculators();
            this.Visibility = Visibility.Hidden;
            objCalculatorsWindow.Show();
        }
    }
}
