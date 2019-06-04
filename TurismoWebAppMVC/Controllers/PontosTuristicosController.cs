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
    public class PontosTuristicosController : Controller
    {
        private readonly PontoTuristicoServicos _pontoTuristicoServicos;

        public PontosTuristicosController(PontoTuristicoServicos pontoTuristicoServicos)
        {
            _pontoTuristicoServicos = pontoTuristicoServicos;
        }

        public IActionResult Index()
        {
            var pontos = _pontoTuristicoServicos.BuscarTodos();
            return View(pontos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PontoTuristico pontoTuristico)
        {
            _pontoTuristicoServicos.Inserir(pontoTuristico);
            return RedirectToAction(nameof(Index));
        }
    }
}
