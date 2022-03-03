internal class VariablePriceProduct : Product
{
    public string Measurement { get; set; }
    public float Quantity { get; set; }

    public override void ShowProduct()
    {
        
        Console.WriteLine(Id + "  " + Description);
        Console.WriteLine("      Measurement:       " + $"{Measurement, 10}");
        Console.WriteLine($"      Quantity...:       {$"{Quantity:F2}",10}");
        Console.WriteLine($"      Price......:      {$"{Price:C}",10}");
        Console.WriteLine($"      Tax........:       {$"{Tax:P}",10}");
        Console.WriteLine($"      Value......:       {$"{ValueToPay():C}",10}");
    }

    public override decimal ValueToPay()
    {
        return ((decimal)Quantity * Price) + ((decimal)Quantity * Price) * (decimal)Tax;
    }
}