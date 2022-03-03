abstract class Product
{
    public string Description { get; set; }
    public int Id { get; set; }
    public decimal Price { get; set; }
    public float Tax { get; set; }

    public abstract decimal ValueToPay();
    public abstract void ShowProduct();

}