﻿using ABC.Core.DataAccess.EntityFramework;
using ABC.Northwind.DataAccess.Abstract;
using ABC.Northwind.DataAccess.Concrete.EntityFramework.Context;
using ABC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Northwind.DataAccess.Concrete.EntityFramework
{
    //public class EfProductDal : IProductDal
    //{
    //    public List<Product> GetList()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    
    //public class EfProductDal : IProductDal
    //{
    //    public Product Add(Product entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Product entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Get(Expression<Func<Product, bool>> filter)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Update(Product entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {
        
    }
}
