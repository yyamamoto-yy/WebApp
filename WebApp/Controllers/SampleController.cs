using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    public class SampleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new WebApp.Models.SampleModel();
            model.Text = "Hello, World!";
            return View(model);
        }

        public IActionResult GetGrid(WebApp.Models.SampleModel model)
        {
            model.Text = "こんにちは、世界！";
            return PartialView("Grid", model);
        }
              
    }
}
