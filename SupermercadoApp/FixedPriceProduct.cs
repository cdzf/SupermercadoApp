class FixedPriceProduct : Product
{
    public override void ShowProduct()
    {
        Console.WriteLine(Id + "  " + Description);
        Console.WriteLine($"      Price......:      {$"{Price:C}",10}");
        Console.WriteLine($"      Tax........:       {$"{Tax:P}", 10}");
        Console.WriteLine($"      Value......:      {$"{ValueToPay():C}",10}");
        
    }

    public override decimal ValueToPay()
    {
        return Price + Price * (decimal)Tax;
    }
}