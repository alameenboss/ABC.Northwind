using ABC.Northwind.Business.Abstract;
using ABC.Northwind.DataAccess.Abstract;
using ABC.Northwind.DataAccess.Concrete.EntityFramework;
using ABC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal; 

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productDal.GetList(x=>x.CategoryId == categoryId);
        }

        //public List<Product> GetProducts()
        //{
        //    //EfProductDal productDal = new EfProductDal();
        //    return _productDal.GetList();
        //}

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
