using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bicycles.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace bicycles.Controllers
{
    public class HomeController : Controller
    {
        private EntityContext _dbontext;

        public HomeController(EntityContext context)
        {
            _dbontext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Register(RegisterViewModel user)
        {
            var checkEmail = _dbontext.users.SingleOrDefault(e => e.Email == user.Email);

            if(ModelState.IsValid)
            {
                if(checkEmail != null)
                {
                    TempData["error"] = "Email is already in use";
                    return View("Index");
                }

                User newUser = new User
                {
                    FN = user.FN,
                    LN = user.LN,
                    Email = user.Email,
                    Password = user.Password
                };

                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newUser.Password = 
            }
            _dbontext.users.Add(newUser);
            _dbontext.SaveChanges();
            return RedirectToAction("Dashboard", "Listing");
        }
        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
