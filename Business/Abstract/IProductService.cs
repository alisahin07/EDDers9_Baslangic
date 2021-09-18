using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product>GetAll(Expression<Func<Product, bool>> filter = null);
        List<Product> GetByCategoryId(int category);

        List<Product> GetByUnitPrice(decimal min,decimal max);
    }
}
