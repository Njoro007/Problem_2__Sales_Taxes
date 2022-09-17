using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public class Products
    {
        public int ItemCount { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double ImportDutyTax { get; set; }
        public double BasicTax { get; set; }
        public double TotalTax { get; set; }
        public double SalesPrice { get; set; }
        public double ShelfPrice { get; set; }
    }

    public class AppData
    {
        public double BasicSalesTaxPercentage { get; set; }

        public double ImportDutyTaxPercentage { get; set; }


        //Below Contructor helps in Identifying/Calling above varible names from other External projects
        public static readonly AppData _AppDataValues = new AppData();
        private AppData()   // mark this private so that no other instances of DataImport can be created
        {
           
        }


    }
}
