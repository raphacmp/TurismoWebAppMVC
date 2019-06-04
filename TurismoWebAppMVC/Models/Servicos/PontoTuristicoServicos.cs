using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoWebAppMVC.Models.Servicos
{
    public class PontoTuristicoServicos
    {
        private readonly TurismoWebAppMVCContext _context;

        public PontoTuristicoServicos(TurismoWebAppMVCContext context)
        {
            _context = context;
        }

        public List<PontoTuristico> BuscarTodos()
        {
            return _context.PontoTuristico.ToList();
        }

        public void Inserir(PontoTuristico pontoTuristico)
        {
            _context.Add(pontoTuristico);
            _context.SaveChanges();
        }

    }
}
