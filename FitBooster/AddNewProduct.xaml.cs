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
                string description = DescriptionInput.Text;

                MeasurementUnits unit;
                double weight;

                if (UnitInput.SelectedIndex == 0)
                {
                    unit = MeasurementUnits.Grams;
                    weight = GetParsedDouble(WeightInput.Text.ToString());
                    
                }
                else
                {
                    unit = MeasurementUnits.Milliliters;
                    weight = GetParsedDouble(CapacityInput.Text.ToString());
                }
                    
                double calories = GetParsedDouble(CaloriesInput.Text.ToString());
                double carbs = GetParsedDouble(CarbsInput.Text.ToString());
                double proteins = GetParsedDouble(ProteinsInput.Text.ToString());
                double fat = GetParsedDouble(FatInput.Text.ToString());

                Product product = new Product(name, description, unit, weight, calories, fat, carbs, proteins);

                IProductsProvider provider = new XMLProductsParser();
                provider.AddProduct(product);

                MyProducts myProducts = new MyProducts();
                myProducts.Show();
                this.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to fill every field!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Cannot save new product! Invalid data!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong! :(");
            }

        }

        // Parses string to double.
        private double GetParsedDouble(string str)
        {
            Console.WriteLine(str);
            return double.Parse(str, CultureInfo.InvariantCulture);
        }

        private void UnitInput_DropDownClosed(object sender, EventArgs e)
        {

            if (UnitInput.SelectedIndex == 0)
            {
                WeightInputLabel.Visibility = Visibility.Visible;
                WeightInput.Visibility = Visibility.Visible;
                CapacityInputLabel.Visibility = Visibility.Collapsed;
                CapacityInput.Visibility = Visibility.Collapsed;
            }
            else if (UnitInput.SelectedIndex == 1)
            {
                WeightInputLabel.Visibility = Visibility.Collapsed;
                WeightInput.Visibility = Visibility.Collapsed;
                CapacityInputLabel.Visibility = Visibility.Visible;
                CapacityInput.Visibility = Visibility.Visible;
            }
        }
    }
}
