using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppBD.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppBD.Controllers
{
    public class LoginController : Controller
    {
        public VIDEOTECContext _context;

        public LoginController(VIDEOTECContext master)
        {
            _context = master;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Correo, string Password)
        {
            
            //DbSet<Usuario> Usuario
            var usuario = _context.Usuario.Where(s => s.Correo == Correo && s.Password == Password);
            if (usuario.Any())
            {
                if (usuario.Where(s => s.Correo == Correo && s.Password == Password).Any())
                {
                    return Json(new { status = true, message = "Bienvenido a VideoTec" });
                }
                else
                {
                    return Json(new { status = false, message = "Clave incorrecta" });
                }
            }
            else
            {
                return Json(new { Status = false, message = "Usuario incorrecto" });
            }
        }
    }
}
