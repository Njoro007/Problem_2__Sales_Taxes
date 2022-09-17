// See https://aka.ms/new-console-template for more information
using AccountsLibrary;

Console.WriteLine("PROBLEM 2: SALES TAX Assessment");
Console.WriteLine("");

//Set Tax Values
AppData._AppDataValues.ImportDutyTaxPercentage = 5;
AppData._AppDataValues.BasicSalesTaxPercentage = 10;

List<Products> Basket = new List<Products>();
List<Products> BasketReceipt = new List<Products>();


// Clear Basket First
Basket.Clear();
// Clear Receipt First
BasketReceipt.Clear();
// Add Items to Basket 
Basket.Add(new Products { ItemCount = 1, ProductName = "book", ProductType = "books", SalesPrice = 12.49 });
Basket.Add(new Products { ItemCount = 1, ProductName = "music CD", ProductType = "music", SalesPrice = 14.99 });
Basket.Add(new Products { ItemCount = 1, ProductName = "chocolate bar", ProductType = "food", SalesPrice = 0.85 });
DisplayReceipt();



Console.WriteLine("");



// Clear Basket First
Basket.Clear();
// Clear Receipt First
BasketReceipt.Clear();
// Add Items to Basket 
Basket.Add(new Products { ItemCount = 1, ProductName = "imported box of Chocolate", ProductType = "food", SalesPrice = 10.00 });
Basket.Add(new Products { ItemCount = 1, ProductName = "imported bottle of perfume", ProductType = "perfume", SalesPrice = 47.50 });
DisplayReceipt();



Console.WriteLine("");



// Clear Basket First
Basket.Clear();
// Clear Receipt First
BasketReceipt.Clear();
// Add Items to Basket 
Basket.Add(new Products { ItemCount = 1, ProductName = "imported bottle of perfume", ProductType = "perfume", SalesPrice = 27.99 });
Basket.Add(new Products { ItemCount = 1, ProductName = "bottle of perfume", ProductType = "perfume", SalesPrice = 18.99 });
Basket.Add(new Products { ItemCount = 1, ProductName = "Packet of Headache Pills", ProductType = "medical product", SalesPrice = 9.75 });
Basket.Add(new Products { ItemCount = 1, ProductName = "imported Chocolates", ProductType = "food", SalesPrice = 11.25 });
DisplayReceipt();


Console.ReadLine();


void DisplayReceipt()
{
    foreach (var basketItem in Basket)
    {
        //Calculate tax for Each Item in Basket 
        double ItemBasicTax = AccountsLibrary.Tax.ApplyBasicSalesTax(basketItem.ItemCount, basketItem.SalesPrice, basketItem.ProductType);
        double ItemImportDutyTax = AccountsLibrary.Tax.ApplyImportDutyOnSalesTax(basketItem.ItemCount, basketItem.SalesPrice, basketItem.ProductName);
        double TotalTaxForItem = AccountsLibrary.RoundFigures.RoundOffToFifthHundredths(ItemBasicTax + ItemImportDutyTax);

        // Build Receipt for Basket 1
        BasketReceipt.Add(new Products
        {
            ProductName = basketItem.ProductName,
            ProductType = basketItem.ProductType,
            ImportDutyTax = ItemImportDutyTax,
            BasicTax = ItemBasicTax,
            TotalTax = TotalTaxForItem,
            SalesPrice = basketItem.SalesPrice,
            ShelfPrice = AccountsLibrary.RoundFigures.RoundOffToHundredths( basketItem.SalesPrice + TotalTaxForItem)
        });
    }

    var SumBasketShelfPrice = BasketReceipt.Sum(item => item.ShelfPrice);
    var SumSalesTax = BasketReceipt.Sum(item => item.TotalTax);

    foreach (var receiptItem in BasketReceipt)
    {
        Console.WriteLine($"{receiptItem.ProductName}: {receiptItem.ShelfPrice}");
    }
    Console.WriteLine($"Sales Taxes: {SumSalesTax}");
    Console.WriteLine($"Total: {SumBasketShelfPrice}");
}





