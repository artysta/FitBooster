using System;
using System.Windows;
using System.Globalization;
using FitBoosterLibrary;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for AddNewProduct.xaml
    /// </summary>
    public partial class AddNewProduct : Window
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get informations about product.
                string name = NameInput.Text;
                string description = string.Empty;
                MeasurementUnits unit = MeasurementUnits.Grams;
                double weight = 0;
                double calories = 0;
                double carbs = double.Parse(CarbsInput.Text, CultureInfo.InvariantCulture);
                double proteins = double.Parse(ProteinsInput.Text, CultureInfo.InvariantCulture);
                double fat = double.Parse(FatInput.Text, CultureInfo.InvariantCulture);

                Product product = new Product(name, description, unit, weight, calories, carbs, proteins, fat);

                IProductsProvider provider = new SampleProductsProvider();
                provider.AddProduct(product);

                MyProducts myProducts = new MyProducts();
                myProducts.Show();

                // Close the window
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Cannot save new product! Invalid data!");
            }
        }
    }
}
