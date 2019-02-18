using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_112_collections;


namespace Labs_Test
{
    [TestClass]
    public class LabsTest
    {
        [TestMethod]
        public void Lab112CollectionsTest1()
        {
            //ARRANGE
            var expected01 = 22400;            
            var instanceLab112Collection = new Collections();


            //ACT
            var actual01 = instanceLab112Collection.Collections20MinuteLab(10, 20, 30);
           

            //ASSERT
            Assert.AreEqual(expected01, actual01);

        }

        [TestMethod]
        public void Lab112CollectionsTest2()
        {
            //ARRANGE
            var expected02 = 6944;
            var instanceLab112Collection = new Collections();

            //ACT
            var actual02 = instanceLab112Collection.Collections20MinuteLab(11, 12, 13);

            //ASSERT
            Assert.AreEqual(expected02, actual02);

        }
    }
}
