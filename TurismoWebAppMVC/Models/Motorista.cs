using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoWebAppMVC.Models
{
    public class Motorista : Colaborador
    {
        public string Cnh
        {
            get; set;
        }

        public Motorista()
        {
        }

        public Motorista(int id, string nome, string cpf, string cnh) : base(id, nome, cpf)
        {
            Cnh = cnh;
        }
    }
}
