using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.Northwind.Business.Abstract;
using ABC.Northwind.Business.Concrete;
using ABC.Northwind.DataAccess.Concrete.EntityFramework;

namespace ABC.Northwind.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDal());

            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();
        }
    }
}