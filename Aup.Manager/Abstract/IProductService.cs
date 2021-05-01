using Aup.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aup.Manager.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
