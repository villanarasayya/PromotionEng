using Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductService;
using System;
using System.Collections.Generic;

namespace PromotionProduct
{
    public class Program
    {
        private static IProductService _productService;

        public static void Main(string[] args)
        {
            Register();
            List<Product> products = new List<Product>();
            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product();
                p.Id = type;
                _productService.GetPriceByType(p);
                products.Add(p);
            }

            int totalPrice = _productService.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        public static void Register()
        {
            var serviceProvider = new ServiceCollection()
          .AddSingleton<IProductService, ProductPrice>()
          .BuildServiceProvider();
            _productService = serviceProvider.GetService<IProductService>();
        }
            
    }
    
}

