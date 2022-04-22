class Program
{
    static void Main(string[] args)
    { 
        Product product1 = new Product();
        product1.name = "Kek";
        product1.stock = 15;
        product1.unitPrice = 4;

        Product product2 = new Product();
        product2.name = "Elma";
        product2.stock = 50;
        product2.unitPrice = 1;

        Product product3 = new Product();
        product3.name = "Bardak";
        product3.stock = 2;
        product3.unitPrice = 6;

        Product product4 = new Product();
        product4.name = "Telefon";
        product4.stock = 78;
        product4.unitPrice = 4000;

        Product product5 = new Product();
        product5.name = "Laptop";
        product5.stock = 1;
        product5.unitPrice = 15000;

        Product[] products = new Product[] { product1, product2, product3, product4, product5 };
        foreach (Product product in products) {
            Console.WriteLine(product.name + " : " + product.stock + " : " + product.unitPrice);
        }
    }
}
class Product
{
    public string name { get; set; }
    public long stock { get; set; }
    public int unitPrice { get; set; }
}