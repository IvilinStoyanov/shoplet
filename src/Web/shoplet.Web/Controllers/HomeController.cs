using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shoplet.Data.Common.Repository.Contracts;
using shoplet.Data.Models;
using shoplet.Web.Models;

namespace shoplet.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<ShopletUser> userRepository;

        public HomeController(IRepository<ShopletUser> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = $"Application users : {this.userRepository.All().Count()}";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
