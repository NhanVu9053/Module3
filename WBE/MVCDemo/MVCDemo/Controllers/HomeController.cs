using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVCDemo.Models;
using MVCDemo.ViewModels;

namespace MVCDemo.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;

        private IWebHostEnvironment WebHostEnvironment;

        public HomeController(IEmployeeRepository employeeRepository,IWebHostEnvironment WebHostEnvironment)
        {
            this.employeeRepository = employeeRepository;
            this.WebHostEnvironment = WebHostEnvironment;
        }
        //[Route("~/")]
        //[Route("Home")]
        //[Route("Home/Index")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            //ViewData["Employees"] = employeeRepository.Gets();
            //ViewBag.Employees = employeeRepository.Gets();
            var employees = employeeRepository.Gets();
            return View(employees);
        }
        public ViewResult Details(int? id)
        {
            try
            {
                int.Parse(id.Value.ToString());
                var employee = employeeRepository.Get(id.Value);
                if (employee == null)
                {

                    return View("~/Views/Error/EmployeeNotFound.cshtml", id.Value);
                }
                ViewBag.TitleName = "employee Details";
                var detailViewModel = new HomeDetailViewModel()
                {
                    Employee = employeeRepository.Get(id ?? 1),
                    TitleName = "Employee Detail"
                };
                return View(detailViewModel);
            }
            catch(Exception e)
            {
                throw e;
            }
          
        }
       
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Department = model.Department

                };
                var fileName = string.Empty;
                if(model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(WebHostEnvironment.WebRootPath, "images");
                    fileName =$"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using( var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                }
                employee.AvatarPath = $"{fileName}";
                var newEmp = employeeRepository.Create(employee);
                return RedirectToAction("Details", new { id = newEmp.Id });
            }
            return View();
            
        }
        
        public ViewResult Edit(int id)
        {
            var employee = employeeRepository.Get(id);
            
            if (employee == null)
            {

                return View("~/Views/Error/EmployeeNotFound.cshtml", id);
            }
            var empEdit = new HomeEditViewModel()
            {
                AvatarPath = employee.AvatarPath,
                FullName = employee.FullName,
                Email = employee.Email,
                Department = employee.Department,
                Id = employee.Id
            };
            return View(empEdit);
        }
      
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {

                var employee = new Employee()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Department = model.Department,
                    Id= model.Id,
                    AvatarPath= model.AvatarPath

                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(WebHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                    employee.AvatarPath = $"{fileName}";
                    if (!string.IsNullOrEmpty(model.AvatarPath))
                    {
                        string delFile = Path.Combine(WebHostEnvironment.WebRootPath, "images",model.AvatarPath);
                        System.IO.File.Delete(delFile);
                    }
                }
              
                var editEmp = employeeRepository.Edit(employee);
                if (editEmp != null)
                {
                    return RedirectToAction("Index", new { id = employee.Id });
                }
            }
           
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (employeeRepository.Delete(id))
            {
                return RedirectToAction("Index");
            };
            return View();

        }
    }
}
