using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bicycles.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace bicycles.Controllers
{
    public class ListingController : Controller
    {
        private EntityContext _dbontext;

        public ListingController(EntityContext context)
        {
            _dbontext = context;
        }

        [HttpGet]
        [Route("/browse")]
        public IActionResult Dashboard()
        {
            return View("dashboard");
        }


    }
}
