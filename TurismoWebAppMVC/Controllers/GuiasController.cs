using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TurismoWebAppMVC.Models;
using TurismoWebAppMVC.Models.Servicos;

namespace TurismoWebAppMVC.Controllers
{
    public class GuiasController : Controller
    {
        private readonly GuiaServicos _guiaServicos;

        public GuiasController(GuiaServicos guiaServicos)
        {
            _guiaServicos = guiaServicos;
        }

        public IActionResult Index()
        {
            var guias = _guiaServicos.BuscarTodos();
            return View(guias);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Guia guia)
        {
            _guiaServicos.Inserir(guia);
            return RedirectToAction(nameof(Index));
        }
    }
}
