using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Ajax.Controllers
{
    public class AjaxUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
