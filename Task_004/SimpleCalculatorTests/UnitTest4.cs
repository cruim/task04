using System;
using System.Linq;
using Add_04;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new SimpleCalculator();
            Random random = new Random();
            int a = random.Next(0, 10000);
            int b = random.Next(0, 10000);
            var arr = new[] { b, a };
            int expected = arr.Sum();
            int result = calc.AddOfSomeNumbers(string.Join(",", arr.Select(n => n.ToString())));
            Assert.AreEqual(expected, result);
        }
    }
}
