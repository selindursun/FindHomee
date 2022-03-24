using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindHome_UI.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
