using Aup.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aup.Data.Abstract
{
    public interface IProductDataAccessLayer
    {
        public List<Product> GetAll();
    }
}
