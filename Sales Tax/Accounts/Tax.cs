using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public static class Tax
    {
        /// <summary>
        /// This Function calculates Import Duty tax to be applied on the Item/Goods that are only imported
        /// </summary>
        /// <param name="ItemCount">number of similar basket items</param>
        /// <param name="SaleAmount">Amount of single Basket Item</param>
        /// <param name="ItemName"> Product name to identify if produt is imported</param>
        /// <returns>Returns a double i.e Amount of import duty tax to be applied on the basket item</returns>
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


        /// <summary>
        /// This Function calculates Basic Sales tax to be applied on the Item/Goods exempting food,books and medical product
        /// </summary>
        /// <param name="ItemCount"> number of similar basket items</param>
        /// <param name="SaleAmount">Amount of single Basket Item</param>
        /// <param name="ProductType">nature of product e.g food, medical products</param>
        /// <returns>Returns a double i.e Amount of Basic Sales tax to be applied on the bascet item</returns>
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
