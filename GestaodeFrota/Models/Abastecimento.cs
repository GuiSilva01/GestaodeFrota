using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Abastecimento
    {
        public int Id { get; set; }
        public int Litros { get; set; }
        public double ValorLitro { get; set; }
        public double ValorAbaste { get; set; }
        public DateTime DataAbaste { get; set; }
        public Automovel Automovel { get; set; }
        public Posto Posto { get; set; }

        public Abastecimento()
        {
        }

        public Abastecimento(int id, int litros, double valorLitro, double valorAbaste, DateTime dataAbaste, Automovel automovel, Posto posto)
        {
            this.Id = id;
            this.Litros = litros;
            this.ValorLitro = valorLitro;
            this.ValorAbaste = valorAbaste;
            this.DataAbaste = dataAbaste;
            this.Automovel = automovel;
            this.Posto = posto;
        }
    }
}
