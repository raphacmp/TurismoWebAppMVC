using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoWebAppMVC.Models
{
    public class Guia : Colaborador
    {
        public string MatriculaNacional
        {
            get; set;
        }

        public Guia()
        {
        }

        public Guia(int id, string nome, string cpf, string matriculaNacional) : base(id, nome, cpf)
        {
            MatriculaNacional = matriculaNacional;
        }
    }
}
