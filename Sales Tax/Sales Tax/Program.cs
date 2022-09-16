

// See https://aka.ms/new-console-template for more information
using AccountsLibrary;
using System.Runtime.CompilerServices;

Console.WriteLine("PROBLEM 2: SALES TAX Assessment");

//Set Tax Values
AppData._AppDataValues.ImportDutyTaxPercentage = 5;
AppData._AppDataValues.BasicSalesTaxPercentage = 10;

List<Products> _Basket1 = new List<Products>();
List<Products> _Basket2 = new List<Products>();
List<Products> _Basket3 = new List<Products>();

List<Products> _Basket1Receipt = new List<Products>();
List<Products> _Basket2Receipt = new List<Products>();
List<Products> _Basket3Receipt = new List<Products>();


// Clear Basket 1 First
_Basket1.Clear();
// Add Items to Basket 1
_Basket1.Add(new Products { ProductName = "book", ProductType = "books", SalesPrice = 12.49 });
_Basket1.Add(new Products { ProductName = "music CD", ProductType = "music", SalesPrice = 14.99 });
_Basket1.Add(new Products { ProductName = "chocolate bar", ProductType = "food", SalesPrice = 0.85 });

DisplayReceipt();


// Clear Basket 1 First
_Basket1.Clear();
// Add Items to Basket 1
_Basket1.Add(new Products { ProductName = "book", ProductType = "books", SalesPrice = 12.49 });
_Basket1.Add(new Products { ProductName = "music CD", ProductType = "music", SalesPrice = 14.99 });
_Basket1.Add(new Products { ProductName = "chocolate bar", ProductType = "food", SalesPrice = 0.85 });

DisplayReceipt();




void DisplayReceipt()
{

    foreach (var basketItem in _Basket1)
    {
        //Calculate tax for Each Item in Basket 1
        double ItemBasicTax = AccountsLibrary.Tax.ApplyBasicSalesTax(basketItem.SalesPrice, basketItem.ProductType);
        double ItemImportDutyTax = AccountsLibrary.Tax.ApplyImportDutyOnSalesTax(basketItem.SalesPrice, basketItem.ProductName);
        double TotalTaxForItem = ItemBasicTax + ItemImportDutyTax;

        // Build Receipt for Basket 1
        _Basket1Receipt.Add(new Products
        {
            ProductName = basketItem.ProductName,
            ProductType = basketItem.ProductType,
            ImportDutyTax = ItemImportDutyTax,
            BasicTax = ItemBasicTax,
            TotalTax = TotalTaxForItem,
            SalesPrice = basketItem.SalesPrice,
            ShelfPrice = AccountsLibrary.RoundFigures.RoundOffToHundredths(basketItem.SalesPrice + TotalTaxForItem)
        });
    }

    foreach (var receiptItem in _Basket1Receipt)
    {
        Console.WriteLine($"{receiptItem.ProductName}: {receiptItem.ShelfPrice}");
    }
    double SumBasketShelfPrice = _Basket1Receipt.Sum(item => item.ShelfPrice);
    double SumSalesTax = _Basket1Receipt.Sum(item => item.TotalTax);

    Console.WriteLine($"Sales Taxes: {SumSalesTax}");
    Console.WriteLine($"Total: {SumBasketShelfPrice}");
}



public class Products
{
    public string ProductName { get; set; }
    public string ProductType { get; set; }
    public double ImportDutyTax { get; set; }
    public double BasicTax { get; set; }
    public double TotalTax { get; set; }
    public double SalesPrice { get; set; }
    public double ShelfPrice { get; set; }
}

