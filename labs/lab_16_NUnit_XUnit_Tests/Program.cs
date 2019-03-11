using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16_NUnit_XUnit_Tests
{
   
    
    class Program
    {
        
        static void Main(string[] args)
        {
            TestMeNow testNow = new TestMeNow();
            Console.WriteLine(testNow.TestThisMethodWorks(2, 3, 3));
            
        }


    }

    public class TestMeNow
    {
        public double TestThisMethodWorks(double x, double y, int p)
        {
            //2, 3, 3 ==> (2*3)=6 and raise this to power 3 i.e. 36*6=216
            Console.WriteLine($"Here is some data {x} {y} {p}");
            return Math.Pow((x * y), p);
        }
    }
}
