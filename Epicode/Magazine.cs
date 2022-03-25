using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode
{
    public static class Magazine
    {
        public static int NumberOfProducts { get; set; }
        public static int Capacity { get; set; }
        public static int MaxCapacity { get; set; }

        public static List<Product> Products = new List<Product>();

        static Magazine()
        {
        }

        //umieszczenie dostawy produktów w magazynie
        public static void AddPackageToMagazine(List<Product> products)
        {
            if (MaxCapacity - Capacity < products.Count)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Capacity++;
                    Products.Add(products[i]);
                }

                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("There is no room for this package");
            }

        }

        //wyjecie danego produktu z magazynu
        public static void RemoveProductFromMagazine(int id)
        {
            foreach (var n in Products
            .Where(product => product.Id == id)
            .ToArray())
            {
                Products.Remove(n);
                Capacity--;
            }

            Console.WriteLine("Removed");
        }

        //sprawdzenie ile produktow znajduje sie obecnie w magazynie
        public static void FindAllProductsFromMagazine()
        {
            if (Capacity != 0)
            {
                foreach (var product in Products)
                {
                    Console.WriteLine(product);
                }
            } 
            else
            {
                Console.WriteLine("Magazine is empty");
            }

        }

        //sprawdzenie czy nie uplynal termin waznosci danego produktu
        public static void CheckForExpirationDateOfId(int id)
        {
            if (Products != null)
            {
                foreach (var product in Products
                    .Where(product => product.ExpirationDate < DateTime.Now && product.Id == id)
                    .ToArray())
                {
                    Console.WriteLine("Product is expired \n" + product);
                }
            }
            else
            {
                Console.WriteLine("Magazine is empty");
            }
        }

        public static void CheckForExpirationDate()
        {
            if (Products != null)
            {
                foreach (var product in Products
                    .Where(product => product.ExpirationDate < DateTime.Now)
                    .ToArray())
                {
                    Console.WriteLine("Product is expired \n" + product);
                }
            }
            else
            {
                Console.WriteLine("Magazine is empty");
            }
        }

        //wyczyszczenie magazynu z przeterminowanych produktow
        public static void RemoveAllExpiredProducts()
        {
            if (Products != null)
            {
                foreach (var n in Products
                    .Where(product => product.ExpirationDate < DateTime.Now)
                    .ToArray()) 
                {

                    Products.Remove(n);
                    Capacity--;
                }
                Console.WriteLine("Removed expired products");
            }
            else
            {
                Console.WriteLine("Magazine is empty");
            }
        }
    }
}
