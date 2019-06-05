using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TurismoWebAppMVC.Models;
using TurismoWebAppMVC.Models.ViewModels;
using TurismoWebAppMVC.Models.Servicos;

namespace TurismoWebAppMVC.Controllers
{
    public class PontosTuristicosController : Controller
    {
        private readonly PontoTuristicoServicos _pontoTuristicoServicos;
        private readonly EstadoServicos _estadoServicos;

        public PontosTuristicosController(PontoTuristicoServicos pontoTuristicoServicos, EstadoServicos estadoServicos)
        {
            _pontoTuristicoServicos = pontoTuristicoServicos;
            _estadoServicos = estadoServicos;
        }

        public IActionResult Index()
        {
            var pontos = _pontoTuristicoServicos.BuscarTodos();
            return View(pontos);
        }

        public IActionResult Create()
        {
            var estados = _estadoServicos.BuscarTodos();
            var viewModel = new PontoTuristicoViewModel { Estados = estados };
            return View(viewModel);
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
