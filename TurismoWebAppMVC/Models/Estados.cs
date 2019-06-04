using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TurismoWebAppMVC.Models.Enums;

namespace TurismoWebAppMVC.Models
{
    public class Estados
    {
        [Key]
        public int Id
        {
            get; set;
        }

        [Required, MaxLength(2)]
        public string UF
        {
            get; set;
        }

        public string Descricao
        {
            get; set;
        }

        public Estados()
        {
        }

        public Estados(int id, string uF, string descricao)
        {
            Id = id;
            UF = uF;
            Descricao = descricao;
        }
    }
