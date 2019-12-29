using ABC.Northwind.Business.Abstract;
using ABC.Northwind.Business.Concrete;
using ABC.Northwind.DataAccess.Concrete.EntityFramework;
using ABC.Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Northwind.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(_productService.GetAll());
        }
    }
}