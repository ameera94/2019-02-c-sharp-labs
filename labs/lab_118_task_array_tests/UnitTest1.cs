using NUnit.Framework;
using lab_118_array_of_tests;

namespace Tests
{
    public class Tests
    {
        //Any setup code e.g. generate fresh database
        //Any initialisation before run any tests
        [SetUp]
        public void Setup()
        {
        }

        [TestCase (1000, 7000)]
        [TestCase (10000, 60000)]
        [TestCase (1000, 500)]
        public void Test1(int numberOfFiles, long maxTime)
        {
            //Arrange
            var instance = new FileOperationSynchronous();


            //Act
            long timetaken = instance.FileReadWrite(numberOfFiles);
            System.Console.WriteLine($"Time taken {timetaken} milliseconds");
  

            //Assert
            Assert.Less(timetaken, maxTime);
        }
    }
}