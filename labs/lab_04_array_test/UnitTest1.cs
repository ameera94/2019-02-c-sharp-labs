using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using labs_04_array;

namespace lab_04_array_test
{
    [TestClass] //[] = decorations/attributes - used above classes and methods for C# internal 
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Array_Sum()
        {
            //==3 Buzzwords for testing==
            //Arrange (setup)
            var arrayInstance = new labs_04_array.Array();
            var expectedOutput = 285; 

            //Act(Run code) 
            var actualOutput = arrayInstance.CreateArray(10);

            //Assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Check_Array_Sum_Variable_Size()
        {
            //Another test, different parameters
            //Arrange (setup)
            var arrayInstance = new labs_04_array.Array();
            var expectedOutput = 2470;

            //Act(Run code) 
            var actualOutput = arrayInstance.CreateArray(20);

            //Assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
