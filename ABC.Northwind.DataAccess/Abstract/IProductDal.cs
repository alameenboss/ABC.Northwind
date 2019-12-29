using ABC.Core.DataAccess;
using ABC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Northwind.DataAccess.Abstract
{
    //public interface IProductDal
    //{
    //    List<Product> GetList();
    //}

    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
