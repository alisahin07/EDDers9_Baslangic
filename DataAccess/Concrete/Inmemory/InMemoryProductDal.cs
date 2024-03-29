﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _product;

        public InMemoryProductDal()
        {
            _product = new List<Product> { 
             new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice=5, UnitsInStock=2 },
              new Product { ProductId = 2, CategoryId = 2, ProductName = "Kalem", UnitPrice=2, UnitsInStock=5 },
               new Product { ProductId = 3, CategoryId = 2, ProductName = "Silgi", UnitPrice=1, UnitsInStock=6 }


            };
        }

        public void Add(Product product)
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {
            var result = _product.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _product.Remove(result);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _product;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _product.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product Updateproduct = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            Updateproduct.ProductName = product.ProductName;
            Updateproduct.CategoryId = product.CategoryId;
            Updateproduct.UnitPrice = product.UnitPrice;
            Updateproduct.UnitsInStock = product.UnitsInStock;
        }
    }
}
