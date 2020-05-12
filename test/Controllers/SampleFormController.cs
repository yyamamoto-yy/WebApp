using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class SampleFormController : Controller
    {
        public IActionResult Index()
        {
            var form = new test.Models.SampleFormModel();
            form.Text = "0";
            return View(form); //View("Index", form)と同じ
        }

        public IActionResult Submit(test.Models.SampleFormModel form)
        {
            form.Text = "12345";

            return View("Index", form);
        }
    }
}