using System.Collections.Generic;
using System.Linq;
using System.Windows;
using FitBoosterLibrary;

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
            AddDietsToList();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MP_Button_Click(object sender, RoutedEventArgs e)
        {
            MyProducts objMPWindow = new MyProducts();
            Close();
            objMPWindow.Top = 0;
            objMPWindow.Left = 300;
            objMPWindow.Show();
        }

        private void FD_Button_Click(object sender, RoutedEventArgs e)
        {
            FoodDiary objFDWindow = new FoodDiary();
            Close();
            objFDWindow.Top = 0;
            objFDWindow.Left = 300;
            objFDWindow.Show();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            Close();
            objMainWindow.Top = 0;
            objMainWindow.Left = 300;
            objMainWindow.Show();
        }

        public void AddDietsToList()
        {
            IDietsProvider provider = new XMLDietsParser();
            List<Diet> diets = provider.GetAllDiets();

            if (diets == null) return;

            foreach (Diet d in diets)
            {
                if (dietsList.Items.Contains(d)) return;
                dietsList.Items.Add(d);
            }
        }

        private void dietsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Diet diet = (Diet)dietsList.SelectedItem;
            List<DietProduct> products = diet.Products;

            if (productsList.Items.Count != 0) productsList.Items.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                productsList.Items.Add(products[i]);
            }
        }
    }
}
