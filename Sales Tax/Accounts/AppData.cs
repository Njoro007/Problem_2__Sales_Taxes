using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
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
