using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.ViewComponents
{
    public class SampleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(WebApp.Models.SampleModel model)
        {
            return View(model);
        }
    }
}
