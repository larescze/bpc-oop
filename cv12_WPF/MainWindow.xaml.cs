using System;
using System.Net.Http;
using System.Windows;

namespace cv12_WPF
{
    /// <summary>
    /// Interractive logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double calcResult;

            try
            {
                CalculationData calcData = new CalculationData(operation.Text, Convert.ToDouble(number1.Text), Convert.ToDouble(number2.Text));

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7070/");
                HttpResponseMessage response = client.PostAsJsonAsync("values", calcData).Result;

                if (response.IsSuccessStatusCode)
                {
                    calcResult = response.Content.ReadAsAsync<double>().Result;
                }
                else
                {
                    calcResult = Double.NaN;
                }
            }
            catch (Exception)
            {
                calcResult = Double.NaN;
            }

            result.Text = calcResult.ToString();
        }
    }
}
