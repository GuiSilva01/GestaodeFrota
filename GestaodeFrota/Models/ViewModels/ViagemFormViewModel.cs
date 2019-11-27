using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models.ViewModels
{
    public class ViagemFormViewModel
    {
        public Viagem Viagem { get; set; }
        public ICollection<Automovel> Automovels { get; set; }
        public ICollection<Motorista> Motoristas { get; set; }
    }
}
