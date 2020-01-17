﻿using System.Collections.Generic;
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
            this.Visibility = Visibility.Hidden;
            objMPWindow.Top = 0;
            objMPWindow.Left = 300;
            objMPWindow.Show();
        }

        private void FD_Button_Click(object sender, RoutedEventArgs e)
        {
            FoodDiary objFDWindow = new FoodDiary();
            this.Visibility = Visibility.Hidden;
            objFDWindow.Top = 0;
            objFDWindow.Left = 300;
            objFDWindow.Show();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Top = 0;
            objMainWindow.Left = 300;
            objMainWindow.Show();
        }

        public void AddDietsToList()
        {
            IDietsProvider provider = new SampleDietsProvider();
            List<Diet> diets = provider.GetAllDiets();

            foreach (Diet d in diets)
            {
                if (dietsList.Items.Contains(d)) return;
                dietsList.Items.Add(d);
            }
        }
    }
}
