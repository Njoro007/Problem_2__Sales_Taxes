using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public static class Tax
    {
        public static double ApplyImportDutyOnSalesTax(double SaleAmount,string ItemName)
        {
            double SaleAmountWithAppliedTax = 0.00;

            if (ItemName.Contains("imported"))
            {
                SaleAmountWithAppliedTax = AppData._AppDataValues.ImportDutyTaxPercentage * SaleAmount / 100;
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToHundredths(SaleAmountWithAppliedTax);
            }
            else
            {
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToHundredths(SaleAmountWithAppliedTax);
            }

            return SaleAmountWithAppliedTax;
        }


        public static double ApplyBasicSalesTax(double SaleAmount, string ProductType)
        {
            double SaleAmountWithAppliedTax = 0.00;

            if (ProductType.Equals("food", StringComparison.OrdinalIgnoreCase)
            || ProductType.Equals("books", StringComparison.OrdinalIgnoreCase)
            || ProductType.Equals("medical product", StringComparison.OrdinalIgnoreCase))
            {
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToHundredths(SaleAmountWithAppliedTax);
            }
            else
            {
                SaleAmountWithAppliedTax = AppData._AppDataValues.BasicSalesTaxPercentage * SaleAmount / 100;
                SaleAmountWithAppliedTax = RoundFigures.RoundOffToHundredths(SaleAmountWithAppliedTax);
            }
            return SaleAmountWithAppliedTax;
        }
    }
}
