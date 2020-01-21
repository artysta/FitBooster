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
            IProductsProvider provider = new XMLProductsParser();
            List<Product> products = provider.GetAllProducts();

            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
                if (productsList.Items.Contains(p)) return;
                productsList.Items.Add(p);
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewProduct objANPWindow = new AddNewProduct();
            this.Close();
            objANPWindow.Top = 0;
            objANPWindow.Left = 300;
            objANPWindow.Show();
        }

        private void FD_Button_Click(object sender, RoutedEventArgs e)
        {
            FoodDiary objFDWindow = new FoodDiary();
            this.Close();
            objFDWindow.Top = 0;
            objFDWindow.Left = 300;
            objFDWindow.Show();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Close();
            objMainWindow.Top = 0;
            objMainWindow.Left = 300;
            objMainWindow.Show();
        }
    }
}
