using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models.ViewModels
{
    public class ApoliceFormViewModel
    {
        public Apolice Apolice { get; set; }
        public ICollection<Seguro> Seguros { get; set; }
    }
}
