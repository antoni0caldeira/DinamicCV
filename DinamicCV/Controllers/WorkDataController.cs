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
            int hour = DateTime.Now.Hour;
            string message;
            if (hour >= 7 && hour < 12)
            {
                message = "É de manhã";
            }
            else if (hour >= 12 && hour< 20)
            {
                message = "É de tarde";
            }
            else
            {
                message = "Estamos de noite";
            }
            ViewBag.Message = message;

            return View();
        }
    }
}
