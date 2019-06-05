    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurismoWebAppMVC.Models.Servicos;


namespace TurismoWebAppMVC.Models.ViewModels
{
    public class PontoTuristicoViewModel
    {
        public PontoTuristicoViewModel()
        {
        }

        public PontoTuristicoViewModel(ICollection<Estado> estados)
        {
            Estados = estados;
        }

        public PontoTuristico PontoTuristico
        {
            get; set;
        }
        public ICollection<Estado> Estados
        {
            get; set;
        }
    }
}
