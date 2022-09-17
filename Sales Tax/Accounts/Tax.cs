using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public static class Tax
    {
        public static double ApplyImportDutyOnSalesTax(int ItemCount, double SaleAmount,string ItemName)
        {
            double SaleAmountWithAppliedTax = 0.00;

            if (ItemName.Contains("imported"))
            {
                SaleAmountWithAppliedTax = AppData._AppDataValues.ImportDutyTaxPercentage * (SaleAmount*ItemCount) / 100;
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToFifthHundredths(SaleAmountWithAppliedTax);
            }
            else
            {
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToFifthHundredths(SaleAmountWithAppliedTax);
            }

            return SaleAmountWithAppliedTax;
        }


        public static double ApplyBasicSalesTax(int ItemCount,double SaleAmount, string ProductType)
        {
            double SaleAmountWithAppliedTax = 0.00;

            if (ProductType.Equals("food", StringComparison.OrdinalIgnoreCase)
            || ProductType.Equals("books", StringComparison.OrdinalIgnoreCase)
            || ProductType.Equals("medical product", StringComparison.OrdinalIgnoreCase))
            {
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToFifthHundredths(SaleAmountWithAppliedTax);
            }
            else
            {
                SaleAmountWithAppliedTax = AppData._AppDataValues.BasicSalesTaxPercentage * (SaleAmount*ItemCount) / 100;
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToFifthHundredths(SaleAmountWithAppliedTax);
            }
            return SaleAmountWithAppliedTax;
        }
    }
}
