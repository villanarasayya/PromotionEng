using Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductService;
using System.Collections.Generic;
using Xunit.Sdk;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTotalPriceTest()
        {
            var serviceProvider = new ServiceCollection()
           .AddSingleton<IProductService, ProductPrice>()
           .BuildServiceProvider();
            var service = serviceProvider.GetService<IProductService>();
            List<Product> products = new List<Product>();
            int a = 1;
            for (int i = 0; i < a; i++)
            {
                Product p = new Product();
                p.Id = "A";
                service.GetPriceByType(p);
                products.Add(p);
            }

            int totalPrice = service.GetTotalPrice(products);

            Assert.IsNotNull(totalPrice);
        }
    }
}
