using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookHouse.Models.IEntinities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BookHouse.Controllers
{
    public class ChuyenNganhController : Controller
    {
        private readonly IChuyenNganh chuyenNganh;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ChuyenNganhController(IChuyenNganh chuyenNganh, IWebHostEnvironment webHostEnvironment)
        {
            this.chuyenNganh = chuyenNganh;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var chuyenNganhs = chuyenNganh.Gets();
            return View(chuyenNganhs);
        }
    }
}
