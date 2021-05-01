using Aup.Data.Abstract;
using Aup.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aup.Data.Concrete.OrmDemo
{
    public class ProductDataAccessLayer : IProductDataAccessLayer
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Product",

                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Product 2",

                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Product 3",

                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Product 4",

                }
            };
        }
            
    }
}

