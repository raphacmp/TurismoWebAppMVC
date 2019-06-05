using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoWebAppMVC.Models
{
    public class PontoTuristico
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public string Nome
        {
            get; set;
        }
        public string Descricao
        {
            get; set;
        }
        public Estado Estado
        {
            get; set;
        }
        public int EstadoId
        {
            get; set;
        }
        public PontoTuristico()
        {
        }

        public PontoTuristico(int id, string nome, string descricao, Estado estado)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Estado = estado;
        }
    }
}
