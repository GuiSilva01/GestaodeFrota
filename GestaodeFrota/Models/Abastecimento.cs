using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Abastecimento
    {
        public int Id { get; set; }
        [Display(Name = "Litros Abastecido ")]
        public int Litros { get; set; }
        [Display(Name = "Valor Por Litro")]
        [DisplayFormat(DataFormatString = "{0:f3}")]
        public double ValorLitro { get; set; }
        [Display(Name = "Valor do Abastecimento")]
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public double ValorAbaste { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data do Abastecimento")]
        public DateTime DataAbaste { get; set; }
        public Automovel Automovel { get; set; }
        [Display(Name = "Automoveis")]
        public int AutomovelId { get; set; }
        public Posto Posto { get; set; }
        [Display(Name = "Postos de Abastecimento")]
        public int PostoId { get; set; }

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
