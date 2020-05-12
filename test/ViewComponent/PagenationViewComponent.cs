using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test.ViewComponents
{
    public class PagenationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(test.Models.SampleFormModel model)
        {
            return View(model);
        }
    }
}