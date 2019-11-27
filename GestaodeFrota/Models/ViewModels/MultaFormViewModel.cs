using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models.ViewModels
{
    public class MultaFormViewModel
    {
        public Multa Multa { get; set; }
        public ICollection<Automovel> Automovels { get; set; }
    }
}
