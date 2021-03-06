﻿using System;
using System.Windows;
using System.Windows.Controls;
using FitBoosterLibrary;
using System.Globalization;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for Calculators.xaml
    /// </summary>
    public partial class Calculators : Window
    {
        private Calculator calculator;
        // String that helps to control which calculator has been selected.
        private string selectedCalc;
        public Calculators()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Top = 0;
            objMainWindow.Left = 300;
            objMainWindow.Show();
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

            btnCalculate.Visibility = Visibility.Collapsed;

            CalcResult.Text = "";
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

            btnCalculate.Visibility = Visibility.Visible;

            selectedCalc = "BMI";
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

            btnCalculate.Visibility = Visibility.Visible;

            selectedCalc = "BMR";
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
         
            btnCalculate.Visibility = Visibility.Visible;

            selectedCalc = "AMR";
        }

        private void Calculate_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double weight = double.Parse(WeightInput.Text);
                double height = double.Parse(HeightInput.Text);

                if (selectedCalc.Equals("BMI"))
                {
                    CalcResult.Text = calculator.CalculateBMI(weight, height).ToString();
                    return;
                }

                int age = int.Parse(AgeInput.Text);
                string genderName = ((ComboBoxItem)GenderInput.SelectedItem).Content.ToString();
                Genders gender = (Genders)Enum.Parse(typeof(Genders), genderName);

                if (selectedCalc.Equals("BMR"))
                {
                    CalcResult.Text = calculator.CalculateBMR(weight, height, age, gender).ToString();
                    return;
                }

                // Get activity rate by using Tag property of combo box item.
                double activityLevel = double.Parse(((ComboBoxItem)ALInput.SelectedItem).Tag.ToString(), CultureInfo.InvariantCulture);

                if (selectedCalc.Equals("AMR"))
                {
                    CalcResult.Text = calculator.CalculateAMR(weight, height, age, gender, activityLevel).ToString();
                    return;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to fill every field!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
