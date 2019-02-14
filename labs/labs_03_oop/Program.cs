using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_03_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent("Bill");
            var p02 = new Parent("Bill", 22);
            var p03 = new Parent(age: 22, name: "Bill"); //named parameters
            p01.Name = "Bill"; //messy .. 
            //'new' calls constructor once 
        }

        class Parent
        {
            //property - usually uppercase 
            public string Name { get; set; } //any property which is PUBLIC 
            public int Age { get; set; }
            //default constructor present anyway
            public Parent() { } // default constructor. Can't have a new constructor without default. 
            public Parent(string name)
            {
                this.Name = name;
            }
            //overloading - 3 methods of same name but different input parameters. Can use any .. as seen above in main. 
            public Parent(string name, int age)
            {
                this.Age = age;
                this.Name = name;
            }
        }
    }
}
