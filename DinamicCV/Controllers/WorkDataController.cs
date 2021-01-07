using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamicCV.Controllers
{
    public class WorkDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
