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
    /// Interaction logic for Calculators.xaml
    /// </summary>
    public partial class Calculators : Window
    {
        public Calculators()
        {
            InitializeComponent();
        }

        
        private void HideVisibility()
        {
            GenderInputLabel.Visibility = Visibility.Collapsed;
            GenderInput.Visibility = Visibility.Collapsed;

            AgeInputLabel.Visibility = Visibility.Collapsed;
            AgeInput.Visibility = Visibility.Collapsed;

            WeightInputLabel.Visibility = Visibility.Collapsed;
            WeightInput.Visibility = Visibility.Collapsed;

            HeightInputLabel.Visibility = Visibility.Collapsed;
            HeightInput.Visibility = Visibility.Collapsed;

            ALInputLabel.Visibility = Visibility.Collapsed;
            ALInput.Visibility = Visibility.Collapsed;

            CalcResultLabel.Visibility = Visibility.Collapsed;
            CalcResult.Visibility = Visibility.Collapsed;
        }
        private void BMI_btn_Click(object sender, RoutedEventArgs e)
        {
            HideVisibility();

            WeightInputLabel.Visibility = Visibility.Visible;
            WeightInput.Visibility = Visibility.Visible;

            HeightInputLabel.Visibility = Visibility.Visible;
            HeightInput.Visibility = Visibility.Visible;

            CalcResultLabel.Visibility = Visibility.Visible;
            CalcResult.Visibility = Visibility.Visible;
        }

        private void BMR_btn_Click(object sender, RoutedEventArgs e)
        {
            HideVisibility();

            GenderInputLabel.Visibility = Visibility.Visible;
            GenderInput.Visibility = Visibility.Visible;

            AgeInputLabel.Visibility = Visibility.Visible;
            AgeInput.Visibility = Visibility.Visible;

            WeightInputLabel.Visibility = Visibility.Visible;
            WeightInput.Visibility = Visibility.Visible;

            HeightInputLabel.Visibility = Visibility.Visible;
            HeightInput.Visibility = Visibility.Visible;

            CalcResultLabel.Visibility = Visibility.Visible;
            CalcResult.Visibility = Visibility.Visible;
        }

        private void AMR_btn_Click(object sender, RoutedEventArgs e)
        {
            HideVisibility();

            GenderInputLabel.Visibility = Visibility.Visible;
            GenderInput.Visibility = Visibility.Visible;

            AgeInputLabel.Visibility = Visibility.Visible;
            AgeInput.Visibility = Visibility.Visible;

            WeightInputLabel.Visibility = Visibility.Visible;
            WeightInput.Visibility = Visibility.Visible;

            HeightInputLabel.Visibility = Visibility.Visible;
            HeightInput.Visibility = Visibility.Visible;

            ALInputLabel.Visibility = Visibility.Visible;
            ALInput.Visibility = Visibility.Visible;

            CalcResultLabel.Visibility = Visibility.Visible;
            CalcResult.Visibility = Visibility.Visible;
        }

        private void TER_btn_Click(object sender, RoutedEventArgs e)
        {
            HideVisibility();

            GenderInputLabel.Visibility = Visibility.Visible;
            GenderInput.Visibility = Visibility.Visible;

            AgeInputLabel.Visibility = Visibility.Visible;
            AgeInput.Visibility = Visibility.Visible;

            WeightInputLabel.Visibility = Visibility.Visible;
            WeightInput.Visibility = Visibility.Visible;

            HeightInputLabel.Visibility = Visibility.Visible;
            HeightInput.Visibility = Visibility.Visible;

            ALInputLabel.Visibility = Visibility.Visible;
            ALInput.Visibility = Visibility.Visible;

            CalcResultLabel.Visibility = Visibility.Visible;
            CalcResult.Visibility = Visibility.Visible;
        }
    }
}
