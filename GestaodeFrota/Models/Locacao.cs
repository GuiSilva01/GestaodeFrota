using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        [Display(Name = "Data de Locacão do Automovel")]
        [DataType(DataType.Date)]
        public DateTime DataLocacao { get; set; }
        [Display(Name = "Data de Devolução do Automovel")]
        [DataType(DataType.Date)]
        public DateTime DataDevolucao { get; set; }
        [Display(Name = "Valor da Locação")]
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public double ValorLocacao { get; set; }
        public Boolean Devolvido { get; set; }
        public Automovel Automovel { get; set; }
        [Display(Name = "Automoveis Para Alugar")]
        public int AutomovelId { get; set; }

        public Locacao()
        {
        }

        public Locacao(int id, DateTime dataLocacao, DateTime dataDevolucao, double valorLocacao, bool devolvido, Automovel automovel)
        {
            this.Id = id;
            this.DataLocacao = dataLocacao;
            this.DataDevolucao = dataDevolucao;
            this.ValorLocacao = valorLocacao;
            this.Devolvido = devolvido;
            this.Automovel = automovel;
        }
    }
}