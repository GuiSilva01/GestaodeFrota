using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models.ViewModels
{
    public class LocacaoFormViewModel
    {
        public Locacao Locacao { get; set; }
        public ICollection<Automovel> Automovels { get; set; }
    }
}
