using Aup.Data.Concrete.OrmDemo;
using Aup.Manager.Abstract;
using Aup.Manager.Concrete;
using System;

namespace Aup.ConsoleUI
{
    class Program
    {
        /// <summary>
        /// not IoC only autofac, ninject
        /// </summary>
        static void Main(string[] args)
        {
            IProductService productService = new ProductService(new ProductDataAccessLayer());
            foreach (var item in productService.GetAll())
            {
                Console.WriteLine("Product Title: " + item.Title);
                Console.WriteLine("Product Id: " + item.Id);
            }
            Console.ReadLine();
        }

    }
}
