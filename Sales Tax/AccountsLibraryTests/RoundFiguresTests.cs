using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace AccountsLibrary.Tests
{
    [TestClass()]
    public class RoundFiguresTests
    {
        private const string Expected = "Hello World!";

        [TestMethod()]
        public void RoundOffToFifthHundredthsTest()
        {
            using (var sw = new StringWriter())
            {
                double Expected = 0.50;

                Console.SetOut(sw);
                double result = AccountsLibrary.RoundFigures.RoundOffToFifthHundredths(0.495);

                var resultString = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod()]
        public void RoundOffToHundredthsTest()
        {
            using (var sw = new StringWriter())
            {
                double Expected = 0.5;

                Console.SetOut(sw);
                double result = AccountsLibrary.RoundFigures.RoundOffToHundredths(0.495);

                var resultString = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}