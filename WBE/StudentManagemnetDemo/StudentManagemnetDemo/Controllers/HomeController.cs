using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagemnetDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Messenger"] = "Chao cac ban den voi trang cua tao";
            ViewBag.Messenger1 = "Chao cac ban den voi trang cua may";
            TempData["msg"] = "abc";
            return View();
        }
    }
}
