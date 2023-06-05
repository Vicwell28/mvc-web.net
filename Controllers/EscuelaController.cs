using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_web.Models;

namespace mvc_web.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            Escuela escuela = new Escuela()
            {
                EscuelaId = Guid.NewGuid().ToString(),
                Nombre = "Platzi",
                Fundacion = 2000
            };
            
            return View(escuela);
        }
    }
}