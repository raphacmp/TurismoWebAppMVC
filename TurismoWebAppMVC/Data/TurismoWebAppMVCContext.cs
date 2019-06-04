using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TurismoWebAppMVC.Models;

namespace TurismoWebAppMVC.Models
{
    public class TurismoWebAppMVCContext : DbContext
    {
        public TurismoWebAppMVCContext (DbContextOptions<TurismoWebAppMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TurismoWebAppMVC.Models.PontoTuristico> PontoTuristico { get; set; }

        public DbSet<TurismoWebAppMVC.Models.Viagem> Viagem { get; set; }

        public DbSet<TurismoWebAppMVC.Models.Guia> Guia { get; set; }
    }
}
