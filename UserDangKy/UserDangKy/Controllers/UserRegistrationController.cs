using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDangKy.Models;

namespace UserDangKy.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly ApplicationUser applicationUser;
        public UserRegistrationController(ApplicationUser au)
        {
            applicationUser = au;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserClass userClass)
        {
            applicationUser.Add(userClass);
            applicationUser.SaveChanges();
            ViewBag.messenger = "Tạo tài khoản thành công";
            return View();

        }
    }
}
