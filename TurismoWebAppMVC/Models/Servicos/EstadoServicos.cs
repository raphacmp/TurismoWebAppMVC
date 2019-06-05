using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TurismoWebAppMVC.Models.Servicos
{
    public class EstadoServicos
    {
        private readonly TurismoWebAppMVCContext _context;

        public EstadoServicos(TurismoWebAppMVCContext context)
        {
            _context = context;
        }

        public List<Estado> BuscarTodos()
        {
            return _context.Estado.ToList();
        }
    }
}
