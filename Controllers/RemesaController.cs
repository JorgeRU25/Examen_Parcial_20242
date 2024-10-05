using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Examen_Parcial_20242.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Examen_Parcial_20242.Models;

namespace Examen_Parcial_20242.Controllers
{
    public class RemesaController : Controller
    {
        private readonly ILogger<RemesaController> _logger;

        private readonly ApplicationDbContext _context;

        public RemesaController(ILogger<RemesaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var listarRemesas = _context.Remesas.ToList();
            return View(listarRemesas);
        }


        [HttpPost]
        public IActionResult Registrar(Remesa remesa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(remesa);
                _context.SaveChanges();
                ViewBag.Message = "Registro de Remesa creada con éxito.";
            }
            return View("Index", remesa);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}