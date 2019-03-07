using NUnit.Framework;
using lab_119_hash_set_to_excel;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Start a stopwatch
        //Pass 3 numbers into an array
        //Double the numbers and pass to a LINKED LIST
        //Double numbers and pass to a HASH SET
        //Add 15, treble numbers and pass to a DICTIONARY
        //Stop the stopwatch
        //Return the test as a CUSTOM OBJECT CONTAINING
            //Elapsed time (integer, will be in milliseconds)
            //First number
            //Second number
            //Third number
        //Test passes if stopwatch time less than time passed in (4th variable) (set to 10 seconds) 
        //Not part of the test
        //Output all values to .csv text file and append to existing file. 
            //Input 4 parameters
            //Output 4 parameters
        //Finally launch excel to read this file using Process.Start 


        [TestCase (1000, 20, 30, 10)]
        public void HashSetExcelTest1(long time, int a, int b, int c)
        {
            //Arrange
            var hashTest = new HashSetToExcel();
            
            //Act
            var actual = hashTest.HashSetToExcelTest(a, b, c);


            //Assert
            Assert.Less(actual.Time, time);
            
        }
    }
}