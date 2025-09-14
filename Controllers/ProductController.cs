using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Context;
using Project.Models;

namespace Project.Controllers
{

    public class ProductController : Controller
    {
        MYContext db = new MYContext();


        [HttpGet]
        public IActionResult Index()
        {
            var products = db.Products.Include(e => e.Category);
            return View(products);
        }




        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = db.Products.Include(e => e.Category).FirstOrDefault(e => e.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");

            }
            return View(product);


        }





        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }



        [HttpPost]
        public IActionResult Create(Product product)
        {
            ModelState.Remove("Category");

            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

           
            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name");
            return View(product);
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = db.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null) return RedirectToAction("Index");

            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name", product.CategoryId);
            return View(product);
        }



        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ModelState.Remove("Category");

            if (ModelState.IsValid)
            {
                db.Products.Update(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name", product.CategoryId);
            return View(product);
        }


        


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
                return RedirectToAction("Index");

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }




    }

}