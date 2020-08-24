using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{StatusCode}")]
        public ViewResult PageNotFound(int StatusCode)
        {
            ViewBag.ErrorMessage = $"Error {StatusCode}:Sorry the resourece you requested coud not be found ";
            return View();
        }
        [Route("Error")]
        public ViewResult Error()
        {
            return View("Exception");
        }
    }
}
