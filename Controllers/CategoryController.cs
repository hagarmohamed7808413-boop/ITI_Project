using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Context;
using Project.Models;

namespace Project.Controllers
{
    public class CategoryController : Controller
    {
        
        MYContext db = new MYContext();

        [HttpGet]
        public IActionResult Index()
        {
            var categories = db.Categories;
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
            if (category == null) return RedirectToAction("Index");
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = db.Categories.Find(id);
            if (category == null) return RedirectToAction("Index");
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Update(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category); 
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = db.Categories.Find(id);
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
