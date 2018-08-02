using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Operation.Models;

namespace Operation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(OparationViewModel model, string command)
        {
            if(command == "add")
            {
                model.Result = model.A + model.B;
            }
            if(command == "sub")
            {
                model.Result = model.A - model.B;
            }
            if(command == "mul")
            {
                model.Result = model.A * model.B;
            }
            if (command == "div")
            {
                model.Result = model.A / model.B;
            }
            return View(model);
        }
    }
}
