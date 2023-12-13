// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization; // shortcut for getting functions 


namespace Learning_CSharp // this is our name of the workspace
{
    class Program // inside the Leanring_CSharp
        // collection of objects and functions/methods
    {

        protected byte hByte;  // --> can be shared in the parent class
        // Only accesible withtin this class and any class that overrides it 
        private byte gigaByte;  // --> declaration, private 
        // Accessible only within Program (this class)
        public byte jByte; // anybody can access this variable
        private int Mybint;
        // above is a member to our class Program only
        
        // internal 

        public byte MyVariable { get; set; }
        // this is a property which can be acessbeiec by other classes
        // Protected Internal

        public Program()
        {
            this.MyVariable = 0;
        }
        
        public static void Main(string[] args) // This is a function and it's return nothing cuz void
        // inside the brackets is parameters, Main is the name of the function
        // static means it only belongs to the Class Program 
        // it wouldn't be shared to any other class
        {



            // accessing the Cclasses or creating new instance of Cclasses
            //Cclasses otherClass = new Cclasses();
            var otherClass = new Cclasses();



        
        
        }


        public void main2(string[] args) { }
    }

    class ClassB : Program
    {
        public ClassB()
        {
            Program a  = new Program();
            Program b = new Program();

            // a and b are the new instances of class Program
            
           
            
        }
    }
}