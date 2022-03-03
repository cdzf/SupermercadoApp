internal class Invoice
{
    public List<Product> Products { get; set; }

    public Invoice()
    {
        Products = new List<Product>();
    }

    internal void AddProduct(Product product)
    {
        Products.Add(product);
    }

    internal void ShowAll()
    {
        decimal priceTotal = 0;
        
        foreach(Product product in Products)
        {
            product.ShowProduct();
            priceTotal += product.Price;
        }

        Console.WriteLine("                        ===========");
        Console.WriteLine($"TOTAL:                  {priceTotal:C2}");
    }
}