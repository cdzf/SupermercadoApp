
internal class ComposedProduct : Product
{    
    public float Discount { get; set; }
    public List<Product> Products { get; set; }

    public override void ShowProduct()
    {
        Console.WriteLine(Id + "  " + Description);
        Console.Write("      Products...:      ");

        foreach (Product product in Products)
        {
            Console.Write(" " + product.Description + ",");
        }
        
        Console.WriteLine();
        Console.WriteLine($"      Discount...:       {$"{Discount:P}",10}");
        Console.WriteLine($"      Value......:      {$"{ValueToPay():C}",10}");
    }
    
    public override decimal ValueToPay()
    {
        decimal priceProduct = 0;

        foreach (var product in Products)
        {
            priceProduct += product.Price;

        }

        return priceProduct - (priceProduct * (decimal)Discount);
    }
}