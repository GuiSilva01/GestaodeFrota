using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models.ViewModels
{
    public class AutomovelFormViewModel
    {
        public Automovel Automovel { get; set; }
        public ICollection<Apolice> Apolices { get; set; }
    }
}
