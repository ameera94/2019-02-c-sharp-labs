using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_118_encryptions;

namespace lab_118_encryption_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_RomanEncryption()
        {
            var SomeTests = new SomeTests();
            
            Assert.AreEqual("", SomeTests.RomanEncryption("", 13));
            Assert.AreEqual("Uryyb", SomeTests.RomanEncryption("Hello", 13));
            Assert.AreEqual("Guvf vf n frperg pbqr 1209654930", SomeTests.RomanEncryption("This is a secret code 1209654930", 13));
            Assert.AreEqual("V'ir eha bhg bs vqrnf", SomeTests.RomanEncryption("I've run out of ideas", 13));
        }

        [TestMethod]
        public void Check_RomanDecryption()
        {

            Assert.AreEqual("", SomeTests.RomanDecryption("", 13));
            Assert.AreEqual("Hello", SomeTests.RomanDecryption("Uryyb", 13));
            Assert.AreEqual("This is a secret code 1209654930", SomeTests.RomanDecryption("Guvf vf n frperg pbqr 1209654930", 13));
            Assert.AreEqual("I've run out of ideas", SomeTests.RomanDecryption("V'ir eha bhg bs vqrnf", 13));
        }

    }
}
