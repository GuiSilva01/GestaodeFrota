using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Multa
    {
        public int Id { get; set; }
        [Display(Name = "Local da Multa")]
        public string LocalMulta { get; set; }
        [Display(Name = "Data da Multa")]
        [DataType(DataType.Date)]
        public DateTime DataMulta { get; set; }
        public string Gravidade { get; set; }
        public int Pontos { get; set; }
        [Display(Name = "Codigo de Infração da Multa")]
        public string CodIfracao { get; set; }
        [DisplayFormat(DataFormatString = "{0:f3}")]
        public double Valor { get; set; }
        public Automovel Automovel { get; set; }
        [Display(Name = "Automovel")]
        public int AutomovelId { get; set; }

        public Multa()
        {
        }

        public Multa(int id, string localMulta, DateTime dataMulta, string gravidade, int pontos, string codIfracao, double valor, Automovel automovel)
        {
            this.Id = id;
            this.LocalMulta = localMulta;
            this.DataMulta = dataMulta;
            this.Gravidade = gravidade;
            this.Pontos = pontos;
            this.CodIfracao = codIfracao;
            this.Valor = valor;
            this.Automovel = automovel;
        }
    }
}