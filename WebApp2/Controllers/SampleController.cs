using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            var model = new WebApp2.Models.SampleModel();
            model.Text = "Hello, World!";
            return View(model);
        }
    }
}