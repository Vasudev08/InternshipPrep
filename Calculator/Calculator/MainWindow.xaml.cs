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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    // C# - simple, modern, object-oriented and type-safe
    // The evolution of C++
    // itself an evolution of C
    // ++++ = #
    // Familiar to C, C++ or Java developers
    // simplifies complexities of C++
    // async programming , c# two keywords to use async methods
    // often considered self-described
    // if provides powerful features such as nullable value types
    // enurmerations
    // delegates
    // lambda expression
    // Direct memory acess
    /*
     * encapsulation
     * inheritance
     * polymorphism
     * it features structs as lightweight classes
     * it supports generic methods and types
     * it requires keywords to avoid accidental changes

     */
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        public MainWindow()
        {
            InitializeComponent();

            // Event Handler --> direct way to using event handler
            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            percentageButton.Click += PercentageButton_Click;
            equalButton.Click += EqualButton_Click;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }

        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        //access modifier --> Private,  type --> void : not return any values, EventName(two argument or two values)
        // Methods are part of code that do the same thing

        private void OperationButton_Click(object sender, RoutedEventArgs e) 
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }


        }
        
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {

            int selectedValue = 0;

            if (sender == zeroButton)
                selectedValue = 0;
            if (sender == oneButton)
                selectedValue = 1;
            if (sender == twoButton)
                selectedValue = 2;
            if (sender == threeButton)
                selectedValue = 3;
            if (sender == fourButton)
                selectedValue = 4;
            if (sender == fiveButton)
                selectedValue = 5;
            if (sender == sixButton)
                selectedValue = 6;
            if (sender == sevenButton)
                selectedValue = 7;
            if (sender == eightButton)
                selectedValue = 8;
            if (sender == nineButton)
                selectedValue = 9;
            

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }

        }
    }
}