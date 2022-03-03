Console.WriteLine("PRODUCTS");
Console.WriteLine("-------------------------------------------------");

Product product1 = new FixedPriceProduct()
{
    Description = "Vino Gato Negro",
    Id = 1010,
    Price = 46000M,
    Tax = 0.19F
};

Product product2 = new FixedPriceProduct()
{
    Description = "Pan Bimbo Artesanal",
    Id = 2020,
    Price = 1560M,
    Tax = 0.19F
};

Product product3 = new VariablePriceProduct()
{
    Description = "Queso Holandes",
    Id = 3030,
    Measurement = "Kilo",
    Price = 32000M,
    Quantity = 0.536F,
    Tax = 0.19F
};

Product product4 = new VariablePriceProduct()
{
    Description = "Cabano",
    Id = 4040,
    Measurement = "Kilo",
    Price = 18000M,
    Quantity = 0.389F,
    Tax = 0.19F
};

Product product5 = new ComposedProduct()
{
    Description = "Ancheta #1",
    Discount = 0.12F,
    Id = 5050,
    Products = new List<Product>() { product1, product2, product3, product4 }
};

product1.ShowProduct();
product2.ShowProduct();
product3.ShowProduct();
product4.ShowProduct();
product5.ShowProduct();

Console.WriteLine("RECEIPT");
Console.WriteLine("-------------------------------------------------");

Invoice invoice = new Invoice();

invoice.AddProduct(product1);
invoice.AddProduct(product3);
invoice.AddProduct(product5);

invoice.ShowAll();
