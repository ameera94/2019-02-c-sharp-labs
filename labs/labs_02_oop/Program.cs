using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_02_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object - instanciating whatever is in the class. 
            var p01 = new Parent(); //syntactic sugar
            Parent p02 = new Parent(); //regular code 
            p01.Age = 10;


            dynamic x = 10; //an object that has no type until compile time.
        }

        class Parent
        {
            //field
            int X;
            //property 
            private string Y { get; set; } //shorthand
            private string ReadMeOnly { get; } //read only 
            private int age; //private by default
            public int Age
            {

                //gets the variable from private ^
                get
                {
                return this.age;
                }
                //sets value from main. 
                set
                {
                    if (value > 0)
                    {
                        this.age = value;
                    }
                }
            }
            //method
        }

        class Child : Parent
        {

        }
    }
}
