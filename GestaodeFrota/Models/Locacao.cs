using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public double ValorLocacao { get; set; }
        public Boolean Devolvido { get; set; }
        public Automovel Automovel { get; set; }

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