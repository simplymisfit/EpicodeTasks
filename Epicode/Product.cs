using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Value { get; set; }

        public Product(int id, DateTime expirationDate, int value)
        {
            Id = id;
            ExpirationDate = expirationDate;
            Value = value;
        }


        

        public override string ToString()
        {
            return "Product: " + Id + " " + ExpirationDate + " " + Value;
        }
    }
}
