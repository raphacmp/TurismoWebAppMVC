using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoWebAppMVC.Models.Servicos
{
    public class GuiaServicos
    {
        private readonly TurismoWebAppMVCContext _context;

        public GuiaServicos(TurismoWebAppMVCContext context)
        {
            _context = context;
        }

        public List<Guia> BuscarTodos()
        {
            return _context.Guia.ToList();
        }

        public void Inserir(Guia guia)
        {
            _context.Add(guia);
            _context.SaveChanges();
        }
    }
}
