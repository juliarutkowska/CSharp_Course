namespace ClassLibrary1;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Cost { get; set; }
    public double Tax { get; set; }
    public int QuantityInStock { get; set; }
    public static int TotalNoProducts { get; set; }
    public const string CategoryName = "Electronics";
    public readonly string DateOfPurchase;
    
    public Product()
    {
        DateOfPurchase = DateTime.Now.ToShortDateString();
    }
    
    //CalculateTax method to calculate tax
    /*cost <= 20000  then  tax = 10%
    cost > 20000 then  tax = 12.5%*/
    public void CalculateTax(in double percentage)
    {
        //percentage = 10.45;

        //create local variable
        double t;

        //calculate tax
        if (Cost <= 20000)
        {
            t = Cost * 10 / 100;
        }
        else
        {
            t = Cost * percentage / 100;
        }
        Tax = t;
    }
    
    public void CalculateTax(double cost, double percentage)
    {
        //create local variable
        double t;

        //calculate tax
        if (cost <= 50000)
        {
            t = cost * 5 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }

        Tax = t;
    }
    
    
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        var total = product1.QuantityInStock + product2.QuantityInStock + product3.QuantityInStock;
        return total;
    }
}

