using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace khaosat_LDTB_HP.Controllers
{
    public class adminController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Confirm()
        {
            return View();
        }
    }
}