using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_16_NUnit_XUnit_Tests;

namespace lab_16_MS_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var expected = 216;
            var instanceTestMeNow = new TestMeNow();

            //Act
            var actual = instanceTestMeNow.TestThisMethodWorks(2, 3, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
