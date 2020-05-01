using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp3.Controllers
{
    public class SampleFormController : Controller
    {
        public IActionResult Index()
        {
            var form = new WebApp3.Models.SampleFormModel();
            return View(form); //View("Index", form)と同じ
        }

        public IActionResult Submit(WebApp3.Models.SampleFormModel form)
        {
            return View("Index", form);
        }
    }
}