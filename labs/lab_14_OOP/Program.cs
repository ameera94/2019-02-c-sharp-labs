using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_14_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //b01 and h01 = objects // instantiation
            Blueprint b01 = new Blueprint();
            House h01 = new House();
            //can set properties.
            h01.Length = 3;
            h01.numFloors = 2;
            h01.numWindows = 10;
            

        }
    }

    class Blueprint
    {
        public string field01;
        public int field02;
    }

    //Instructions to build house 
    class House
    {
        public int numFloors;
        public int numWindows;
        public double Length { get; set; }
    }
}
