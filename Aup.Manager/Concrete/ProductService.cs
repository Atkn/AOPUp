using Aup.Data.Abstract;
using Aup.Data.Concrete.OrmDemo;
using Aup.Domain.Concrete;
using Aup.Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aup.Manager.Concrete
{
    /// <summary>
    /// Bussines layer for extensions dataaccesslayer
    /// </summary>
    public class ProductService : IProductService
    {
        IProductDataAccessLayer _productDataAccessLayer;

       
        public ProductService(IProductDataAccessLayer productDataAccessLayer)
        {
            _productDataAccessLayer = productDataAccessLayer;
        }

        public List<Product> GetAll()
        {
            return _productDataAccessLayer.GetAll();
        }
    }
}
