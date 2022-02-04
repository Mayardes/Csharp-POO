using System.Collections.Generic;
using System;
using System.Linq;

namespace _21_Delegate_Func
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
    class Program
    {
        public delegate Product DelegateFunc(Product product);
        public delegate bool DelegateResult(Product product);
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "iPhone",
                    Balance = 0
                },
                  new Product()
                {
                    Id = 2,
                    Name = "iPad",
                    Balance = 0
                },
                    new Product()
                {
                    Id = 3,
                    Name = "iPod",
                    Balance = 0
                }

            };

            Func<Product, bool> FuncDelegate = VerifyResult;
            Func<Product, Product> Tester = (delegate(Product product){ return product.Balance > 8 ? product : null;});

            var result = products.Select(Tester);
            var info = result.Any(FuncDelegate) ? "Have products" : "Don't have products";
            Console.WriteLine(info);
        }

        public static Product Test(Product prod)
        {
            var teste = prod.Balance > 8 ? prod : null;
            return teste;
        }

        public static bool VerifyResult(Product prod)
        {
            return false;
        }
    }
}
