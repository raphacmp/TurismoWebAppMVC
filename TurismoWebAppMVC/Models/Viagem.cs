using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoWebAppMVC.Models
{
    public class Viagem
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public string Guia
        {
            get; set;
        }
        public DateTime DataViagem
        {
            get; set;
        }

        public List<PontoTuristico> Pontos = new List<PontoTuristico>();

        public int PontoTuristicoId
        {
            get; set;
        }

        public Viagem()
        {
        }

        public Viagem(int id, string guia, DateTime dataViagem)
        {
            Id = id;
            DataViagem = dataViagem;
            Guia = guia;
        }
    }
}
