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
    public class TaxTests
    {
        [TestMethod()]
        
        public void ApplyImportDutyOnSalesTaxTest()
        {
            
            using (var sw = new StringWriter())
            {
                double Expected = 0.00;

                Console.SetOut(sw);
                double result = AccountsLibrary.Tax.ApplyImportDutyOnSalesTax(1,12.95,"local Good");

                var resultString = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod()]
        public void ApplyBasicSalesTaxTest()
        {
            using (var sw = new StringWriter())
            {
                double Expected = 0.00;

                Console.SetOut(sw);
                double result = AccountsLibrary.Tax.ApplyBasicSalesTax(1, 12.95, "food");

                var resultString = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}