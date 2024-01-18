using System.Text;
using System.Threading.Tasks;
using System;
using CSharpPractice.Classes;
using CSharpPractice.Interfaces;

namespace CSharpPractice

{
    class Program
    {
        static double numberTwo = 12.34;
        static void Main(string[] args)
        {

            


            BankAccount bankAccount = new BankAccount(1000);//
            bankAccount.AddtoBalance(100);
            SimpleMath simpleMath = new SimpleMath();


            Console.WriteLine(Infromation(bankAccount));



            Console.ReadLine();
            //bankAccount.AddtoBalance(numberTwo); // Bankaccount class isn't an static method so we have to declare or instnation it
            // static methods don't need an class object to be.
            // static methods are mostly used in main functions.


            // interface impelement we don't have to worry about types
        }

        private static string Infromation(IInformation information)
        {
            return information.GetInformation();
            
        }
    }

    class SimpleMath : IInformation
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

        public string GetInformation()
        {
            return "Class that solves simple math.";
        }
    }


}