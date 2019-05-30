using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoWebAppMVC.Models
{
    public class Colaborador
    {
        public int Id
        {
            get; set;
        }
        public string Nome
        {
            get; set;
        }
        public string Cpf
        {
            get; set;
        }
        abstract public Colaborador()
        {
        }

        public Colaborador(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }
    }
}
