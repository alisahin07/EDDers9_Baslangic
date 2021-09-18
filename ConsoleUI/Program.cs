using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager products = new ProductManager(new EfProductDal());

      
            foreach (var product in products.GetByUnitPrice(2,9))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
