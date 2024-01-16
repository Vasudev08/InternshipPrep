using System.Text;
using System.Threading.Tasks;
using System;
using CSharpPractice.Classes;

namespace CSharpPractice

{
    class Program
    {
        static double numberTwo = 12.34;
        static void Main(string[] args)
        {

            double[] numbers = [1, 2, 4, 42, 4256];
            var result = SimpleMath.Add(numbers);
            Console.WriteLine(result);


            BankAccount bankAccount = new BankAccount(1000);//
            bankAccount.AddtoBalance(100);
            Console.WriteLine(bankAccount.Balance);


            ChildBankAccount childBankAccount = new ChildBankAccount();
            childBankAccount.AddtoBalance(10);
            Console.WriteLine(childBankAccount.Balance);

            Console.ReadLine();
            //bankAccount.AddtoBalance(numberTwo); // Bankaccount class isn't an static method so we have to declare or instnation it
        }
    }

    class SimpleMath
    {

        // static methods are methods which can be used without instantiating a class
        // for using these methods, 

        // Public, Private, Protected
        // Method Overloading
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        // method overloading - same method name but difference paramters
        public static double Add(double[] numbers )
        {
            double result = 0;
            foreach(double d in numbers)
            {
                result += d;
            }

            return result;

        }
    }


}