using System;
using System.Windows;
using System.Collections.Generic;
using FitBoosterLibrary;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for MyProducts.xaml
    /// </summary>
    public partial class MyProducts : Window
    {
        public MyProducts()
        {
            InitializeComponent();
            AddProductsToList();
        }

        public void AddProductsToList()
        {
            IProductsProvider provider = new SampleProductsProvider();
            List<Product> products = provider.GetAllProducts();

            foreach (Product p in products)
            {
                if (productsList.Items.Contains(p)) return;
                productsList.Items.Add(p);
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewProduct objCalculatorsWindow = new AddNewProduct();
            this.Close();
            objCalculatorsWindow.Show();
        }

        private void FD_Button_Click(object sender, RoutedEventArgs e)
        {
            FoodDiary objCalculatorsWindow = new FoodDiary();
            this.Close();
            objCalculatorsWindow.Show();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objCalculatorsWindow = new MainWindow();
            this.Close();
            objCalculatorsWindow.Show();
        }
    }
}
