using System;
using System.Windows;
using System.Globalization;
using FitBoosterLibrary;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for AddNewProduct.xaml
    /// </summary>
    public partial class UpdateParameters : Window
    {
        public UpdateParameters()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                XMLParametersParser parser = new XMLParametersParser();
                Parameter parameter = new Parameter();

                parameter.Weight = double.Parse(WeightInput.Text, CultureInfo.InvariantCulture);
                parameter.Bmi = double.Parse(BMIInput.Text, CultureInfo.InvariantCulture);
                parameter.TargetBmi = double.Parse(TargetBMIInput.Text, CultureInfo.InvariantCulture);
                parameter.LastUpdated = DateTime.Today;

                parser.AddParameter(parameter);
                ShowMainWindow();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to fill every field!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Cannot update parameters! Invalid data!");
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

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            ShowMainWindow();
        }
    
        private void ShowMainWindow()
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
