using Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Product : IProduct
    {
        public int Id { get ; set; }
        public string Name { get ; set ; }
        public decimal Price { get ; set ; }

        public string GetProductDetails()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
    }
}
