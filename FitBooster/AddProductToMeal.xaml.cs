using System;
using System.Windows;
using System.Collections.Generic;
using FitBoosterLibrary;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for AddProductToMeal.xaml
    /// </summary>
    public partial class AddProductToMeal : Window
    {
        private IFoodDiaryWindow diary;
        private List<Product> products;
        private string mealType;

        public AddProductToMeal(IFoodDiaryWindow diary, string mealType)
        {
            InitializeComponent();
            this.diary = diary;
            this.mealType = mealType;

            IProductsProvider provider = new SampleProductsProvider();
            products = provider.GetAllProducts();

            foreach (Product p in products)
                ProductInput.Items.Add(p.Name);
        }

        private void AP_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = ProductInput.SelectedIndex;
                int amount = int.Parse(AmountInput.Text);

                DietProduct product = new DietProduct(products[i], amount);
                diary.AddProductToList(product, mealType);
            }
            catch (FormatException)
            {
                MessageBox.Show("Cannot add product to meal! Invalid data!");
            }
        }
    }
}
