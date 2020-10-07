using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;

namespace TestProject1
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void TestOnes()
        {
            var converter = new RomanConverter();
            int testnumber = 4;
            
            var actual = converter.ConvertNumber(testnumber);
            var expected = "IV";
            
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestTens()
        {
            var converter = new RomanConverter();
            int testnumber = 50;
            
            var actual = converter.ConvertNumber(testnumber);
            var expected = "L";
            
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestHundreds()
        {
            var converter = new RomanConverter();
            int testnumber = 621;
            
            var actual = converter.ConvertNumber(testnumber);
            var expected = "DCXXI";
            
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestThousands()
        {
            var converter = new RomanConverter();
            int testnumber = 3888;
            
            var actual = converter.ConvertNumber(testnumber);
            var expected = "MMMDCCCLXXXVIII";
            
            Assert.AreEqual(expected, actual);
        }
        
    }
}