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
    public class EstadosController : Controller
    {
        private readonly EstadoServicos _estadoServicos;

        public EstadosController(EstadoServicos estadoServicos)
        {
            _estadoServicos = estadoServicos;
        }
        public IActionResult Index()
        {
            var estados = _estadoServicos.BuscarTodos();
            return View(estados);
        }
    }
}
