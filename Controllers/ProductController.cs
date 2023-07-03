using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bath_Remodel;
using Bath_Remodel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);
            return View(product);
        }

        public IActionResult UpdateProduct(int id)
        {
            Product prod = repo.GetProduct(id);
            if (prod == null)
            {
                return View("ProductNotFound");
            }
            return View(prod);
        }

        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.idproduct });
        }

        public IActionResult InsertProduct()
        {
            var prod = repo.AssignCategory();
            return View(prod);
        }

        public IActionResult InsertProductToDatabase(Product productToInsert)
        {
            repo.InsertProduct(productToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(Product product)
        {
            repo.DeleteProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult BathRemod()
        {
            var products = repo.BathRem();
            return View(products);
        }

        public IActionResult BathRemodR026()
        {
            var products = repo.BathRemR026();
            return View(products);
        }

        public IActionResult BathRemodR015()
        {
            var products = repo.BathRemR015();
            return View(products);
        }
        public IActionResult BathRemodR040()
        {
            var products = repo.BathRemR040();
            return View(products);
        }
        public IActionResult BathRemodR004()
        {
            var products = repo.BathRemR004();
            return View(products);
        }
        public IActionResult BathRemodS026()
        {
            var products = repo.BathRemS026();
            return View(products);
        }
        public IActionResult BathRemodS015()
        {
            var products = repo.BathRemS015();
            return View(products);
        }
        public IActionResult BathRemodS040()
        {
            var products = repo.BathRemS040();
            return View(products);
        }
        public IActionResult BathRemodS004()
        {
            var products = repo.BathRemS004();
            return View(products);
        }
    }
}
