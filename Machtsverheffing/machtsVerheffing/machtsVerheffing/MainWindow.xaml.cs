using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace machtsVerheffing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            
            int number;
            string input = getalTextBox.Text;
            bool isValidInput = int.TryParse(input, out number);

            if (isValidInput)
            {
                getalTextBox.Text = number.ToString();
            }
             if (number > 84 || !isValidInput)
            {
                MessageBox.Show("Please write only numbers here until 84", "fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            StringBuilder machtBuilder = new StringBuilder();
            for (int i = 1; i < 11; i++)
            {
                double resultaatGet = Math.Pow(number, i);
                string result = $"Macht 0{i} van {number}  is {resultaatGet}";
                machtBuilder.AppendLine(result);
                
            }
            resultTextBox.Text = machtBuilder.ToString();

        }
    }
}