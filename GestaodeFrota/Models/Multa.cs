using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Multa
    {
        public int Id { get; set; }
        public string LocalMulta { get; set; }
        public DateTime DataMulta { get; set; }
        public string Gravidade { get; set; }
        public int Pontos { get; set; }
        public string CodIfracao { get; set; }
        public double Valor { get; set; }
        public Automovel Automovel { get; set; }

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