using NUnit.Framework;
using lab_16_NUnit_XUnit_Tests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           

        }
        //instead of hardcoding values and expected can make new test cases. 
        [TestCase(2,3,2, 36)]
        [TestCase(5, 2, 2, 100)]
        [TestCase(2, 2, 2, 16)]


        public void Test1(double x, double y, int p, double expected)
        {
            //ARRANGE
            var testThis = new TestMeNow();
            //ACT
            var actual = testThis.TestThisMethodWorks(x, y, p);
            //ASSERT
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
    }
}