using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models.ViewModels
{
    public class ManutencaoFormViewModel
    {
        public Manutencao Manutencao { get; set; }
        public ICollection<Automovel> Automovels { get; set; }
        public ICollection<Oficina> Oficinas { get; set; }
    }
}
