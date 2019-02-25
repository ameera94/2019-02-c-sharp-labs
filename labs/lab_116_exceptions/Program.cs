using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_116_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = 0; 

            try
            {
                try
                {
                    throw new Exception("Phil's special exception");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Data);
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally
                {
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nThey - thrown exception has been caught at an upper level\n");
            }
            finally
            {
                Console.WriteLine("\nAll Done");
            }

            try
            {
                Console.WriteLine(x / y);
            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("\n\n\n\nDivision of {0} by zero.", x);
            }
            finally
            {
                Console.WriteLine("\nDone");
            }
        }
    }
}


