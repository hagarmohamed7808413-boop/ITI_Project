using Microsoft.AspNetCore.Mvc;
using Project.Context;
using Project.Models;

namespace Project.Controllers
{
    public class UserController : Controller
    {
        MYContext db = new MYContext();


   

            [HttpGet]
            public IActionResult Index()
            {
                var users = db.Users.ToList();
                return View(users);

            }



            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }



            [HttpPost]
            public IActionResult Create(User user)
            {
                if (ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(user);
            }




            [HttpGet]
            public IActionResult Register()
            {
                return View();
            }




            [HttpPost]
            public IActionResult Register(User user)
            {
                 
                if (db.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists");
                    return View(user);
                }

                if (ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                }
                return View(user);
            }




            [HttpGet]
            public IActionResult Login()
            {
                return View();
            }



            [HttpPost]
            public IActionResult Login(string email, string password)
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid Email or Password");
                    return View();
                }

                return RedirectToAction("Index", "Product");
            }
        
    }
}

