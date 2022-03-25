using Epicode;
public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>();
        Product product1 = new Product(1,DateTime.Now.AddDays(3), 15);
        Product product2 = new Product(2, DateTime.Now.AddDays(-4), 14);
        Product product3 = new Product(3, DateTime.Now.AddDays(-3), 13);
        Product product4 = new Product(4, DateTime.Now.AddDays(-2), 12);
        Product product5 = new Product(5, DateTime.Now.AddDays(-1), 11);
        Product product6 = new Product(6, DateTime.Now.AddDays(1), 11);
        Product product7 = new Product(7, DateTime.Now.AddDays(2), 11);


        //Find all
        Console.WriteLine("Find all");
        Magazine.FindAllProductsFromMagazine();
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);
        products.Add(product5);
        products.Add(product6);
        products.Add(product7);

        //Add products to Magazine
        Console.WriteLine("\nAdding products");
        Magazine.AddPackageToMagazine(products);

        Console.WriteLine("\nFind all");
        Magazine.FindAllProductsFromMagazine();

        //Remove product from Magazine
        Console.WriteLine("\nRemoving product");
        Magazine.RemoveProductFromMagazine(5);

        Console.WriteLine("\nFind all");
        Magazine.FindAllProductsFromMagazine();

        //Check how many products are in Magazine
        Console.WriteLine("\nProducts in magazine");
        Magazine.FindAllProductsFromMagazine();

        //Check if product is expired
        Console.WriteLine("\n");
        Magazine.CheckForExpirationDateOfId(4);

        //Check if products are expired
        Console.WriteLine("\n");
        Magazine.CheckForExpirationDate();

        Console.WriteLine("\nFind all");
        Magazine.FindAllProductsFromMagazine();

        //Removed all expired products
        Console.WriteLine("\n");
        Magazine.RemoveAllExpiredProducts();
        Console.WriteLine("\nFind all");
        Magazine.FindAllProductsFromMagazine();
    }
}