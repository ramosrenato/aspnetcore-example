using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetapp.Models;

namespace aspnetapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

             // Creates a model and passes it on to the view.
            Employee[] model =
            {
                new Employee { Name = "Fulano", Title = "Manager" },
                new Employee { Name = "Beltrano", Title = "Accountant" }
            };

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
