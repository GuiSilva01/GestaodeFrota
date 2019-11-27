using System.Collections.Generic;

namespace GestaodeFrota.Models.ViewModels
{
    public class AbastecimentoFormViewModel
    {
        public Abastecimento Abastecimento { get; set; }
        public ICollection<Automovel> Automovels { get; set; }
        public ICollection<Posto> Postos { get; set; }
    }
}
