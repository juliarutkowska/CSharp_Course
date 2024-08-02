using ClassLibrary1;

namespace FieldsExample;

public class Sample
{
    static void Main()
    {
        const string developerName = "Julia";
        
        Product product1, product2, product3;

        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        product1.ProductId = 1001;
        product1.ProductName = "Mobile";
        product1.Cost = 20000;
        product1.QuantityInStock = 1200;
        
        product2.ProductId = 1002;
        product2.ProductName = "Laptop";
        product2.Cost = 45000;
        product2.QuantityInStock = 3400;
        
        product3.ProductId = 1003;
        product3.ProductName = "Speakers";
        product3.Cost = 36000;
        product3.QuantityInStock = 800;
        
        var q = 9.2;
        product1.CalculateTax(percentage: in q);

        //out
        var p = 5.6;
        product2.CalculateTax(in p);
        Console.WriteLine("p is " + p);

        product3.CalculateTax(10000, 3.4);
        
        Console.WriteLine(developerName);
        
        Console.WriteLine("Product 1:");
        Console.WriteLine("Product ID: " + product1.ProductId);
        Console.WriteLine("Product Name: " + product1.ProductName);
        Console.WriteLine("Cost: " + product1.Cost);
        Console.WriteLine("Quantity in Stock: " + product1.QuantityInStock);
        Console.WriteLine("Date of Purchase: " + product1.DateOfPurchase);
        Console.WriteLine("Tax: " + product1.Tax);
        
        Console.WriteLine("\nProduct 2:");
        Console.WriteLine("Product ID: " + product2.ProductId);
        Console.WriteLine("Product Name: " + product2.ProductName);
        Console.WriteLine("Cost: " + product2.Cost);
        Console.WriteLine("Quantity in Stock: " + product2.QuantityInStock);
        Console.WriteLine("Date of Purchase: " + product2.DateOfPurchase);
        Console.WriteLine("Tax: " + product2.Tax);
        
        Console.WriteLine("\nProduct 3:");
        Console.WriteLine("Product ID: " + product3.ProductId);
        Console.WriteLine("Product Name: " + product3.ProductName);
        Console.WriteLine("Cost: " + product3.Cost);
        Console.WriteLine("Quantity in Stock: " + product3.QuantityInStock);
        Console.WriteLine("Date of Purchase: " + product3.DateOfPurchase);
        Console.WriteLine("Tax: " + product3.Tax);


        var totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
        
        Console.WriteLine("Total Quantity: " + totalQuantity);
        Console.WriteLine("Total no. of products: " + Product.TotalNoProducts); 
        Console.WriteLine("Category of products: " + Product.CategoryName);
    }
}