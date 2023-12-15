using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class MyGenericClass<T>
    { 
    public T MyNumber { get; set; }
    }



    public class MyList<T>
    {
        private List<T> mNumbers = new List<T>();

        public void AddNumber(T number)
        {
            mNumbers.Add(number);

        }
        public T GetNumber(int i)
        {
            return mNumbers[i];

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var c = new MyGenericClass<int>();
            var c2 = new MyGenericClass<bool>();
            // why we need genericClass because what if we need to do same operation to mutiple data-type classes
            // GenericClass doesn't have a specific type as it's determined during compile-time

            var numbers = new MyList<int>();
            numbers.AddNumber(10);
            numbers.AddNumber(20);
            numbers.AddNumber(30);
            numbers.AddNumber(40);
            numbers.AddNumber(50);

            var list2 = new MyList<string>();
            list2.AddNumber("1");
            list2.AddNumber("4");


            Console.WriteLine(numbers.GetNumber(3));

        }
    }



    
}