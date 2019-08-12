using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace khaosat_LDTB_HP.Controllers
{
    public class CitizenController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}