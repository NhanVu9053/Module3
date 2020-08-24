using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoBTAnhKhoa.Models;


namespace DemoBTAnhKhoa.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            //ViewData
            ViewData["Employees"] = employeeRepository.Gets();
            return View();
        }
    }
}
