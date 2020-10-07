using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppBD.Controllers
{
    public class forgotPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
