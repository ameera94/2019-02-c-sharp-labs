using System;
using Xunit;
using lab_16_NUnit_XUnit_Tests;

namespace lab_16_XUnit_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //ARRANGE
            var expected = 216;
            var testThis = new TestMeNow();

            //ACT 
            var actual = testThis.TestThisMethodWorks(2, 3, 3);

            //ASSERT 
            Assert.Equal(expected, actual);
        }
    }
}
