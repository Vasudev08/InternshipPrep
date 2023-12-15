using System;

namespace Enums 
{

    // custom -defined constant values for custom use
    public enum MyEnums
    {
        Myvalue1,
        Myvalue2
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");


            // 1. What are enum's ?
            int i = 1;
            var a = MyEnums.Myvalue1;

            // 2. Different base types
            var myInt = (int)MyEnums.Myvalue2;


            // 3. Where to use them ?


            // 4. Casting to/from int / type


            // 5. Parsing from string name


            // 6. Enumerating the enum


            // 7. Flags
        }
    }
}
