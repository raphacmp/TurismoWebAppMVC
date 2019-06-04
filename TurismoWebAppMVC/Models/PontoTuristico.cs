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
        public string Bairro
        {
            get; set;
        }
        public string Uf
        {
            get; set;
        }
        public string Descricao
        {
            get; set;
        }

        public PontoTuristico()
        {
        }

        public PontoTuristico(int id, string nome, string bairro, string uf, string descricao)
        {
            Id = id;
            Nome = nome;
            Bairro = bairro;
            Uf = uf;
            Descricao = descricao;
        }
    }
}
