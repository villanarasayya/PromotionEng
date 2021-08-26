using Domain;
using System;
using System.Collections.Generic;

namespace ProductService
{
    public interface IProductService
    {
        void GetPriceByType(Product product);
        int GetTotalPrice(List<Product> products);
    }
}
