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
        SelectedOperator selectedOperator;
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
            double newNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch(selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        result = SimpleMath.Subtraction(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiplication(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Division(lastNumber, newNumber);
                        break;


                }

                resultLabel.Content = result.ToString();
            }

        }

        // 50 + 5% (2.5) = 52.5
        // 80 + 10% (8) = (88)
        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            double tempNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out tempNumber))
            {
                tempNumber = tempNumber / 100;
                if (lastNumber != 0)
                {
                    tempNumber *= lastNumber;

                }


                resultLabel.Content = tempNumber.ToString();
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
            result = 0;
            lastNumber = 0;
        }

        //access modifier --> Private,  type --> void : not return any values, EventName(two argument or two values)
        // Methods are part of code that do the same thing

        private void OperationButton_Click(object sender, RoutedEventArgs e) 
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }

            if (sender == multiplicationButton)
            {
                selectedOperator = SelectedOperator.Multiplication;
            }
            if (sender == divisionButton)
            {
                selectedOperator = SelectedOperator.Division;
            }
            if (sender == additionButton)
            {
                selectedOperator = SelectedOperator.Addition;
            }
            if (sender == subtractionButton)
            {
                selectedOperator = SelectedOperator.Subtraction;
            }


        }
        
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            // Here, as we know that the sender object is a button we could
            // use that fact to our advantage and receive the sender as a button
            // recive its content as an int.
            // int because our buttons are numbered between 1 to 9. and there's
            // no decimal space
            int selectedValue = int.Parse((sender as Button).Content.ToString());
            

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }

        }
        // Custom Variable Type
        public enum SelectedOperator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division

        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains("."))
            {
                // Do nothing
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }

        }

        public class SimpleMath
        {
            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }

            public static double Subtraction(double n1, double n2)
            {
                return n1 - n2;
            }

            public static double Multiplication(double n1, double n2)
            {
                return n1 * n2;
            }

            public static double Division(double n1, double n2)
            {
                if(n2 == 0)
                {
                    MessageBox.Show("Division by 0 is not supported", "Wrong operation",MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                }

                return n1 / n2;
            }
        }
    }
}