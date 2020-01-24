using System.Windows;
using System.Windows.Input;
using FitBoosterLibrary;

namespace FitBooster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            XMLParametersParser parser = new XMLParametersParser();
            Parameter param = parser.GetLatestParameter();

            if (param == null) return;

            weigthLbl.Text = param.Weight.ToString();
            bmiLbl.Text = param.Bmi.ToString();
            targetBmiLbl.Text = param.TargetBmi.ToString();
            lastUpdatedLbl.Text = string.Format("{0:d/M/yyyy}", param.LastUpdated);
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            FoodDiary objFoodDiaryWindow = new FoodDiary();
            Close();
            objFoodDiaryWindow.Top = 0;
            objFoodDiaryWindow.Left = 300;
            objFoodDiaryWindow.Show();
        }

        private void Calc_btn_Click(object sender, RoutedEventArgs e)
        {
            Calculators objCalculatorsWindow = new Calculators();
            Close();
            objCalculatorsWindow.Top = 0;
            objCalculatorsWindow.Left = 300; 
            objCalculatorsWindow.Show();
        }

        private void UpdateBtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateParameters update = new UpdateParameters();
            update.Top = 0;
            update.Left = 400;
            update.Show();
            this.Close();
        }
    }
}
