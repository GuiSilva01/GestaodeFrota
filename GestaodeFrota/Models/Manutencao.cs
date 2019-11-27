using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Manutencao
    {
        public int Id { get; set; }
        public DateTime DataManutencao { get; set; }
        public DateTime DataProxManu { get; set; }
        public string Servico { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public Automovel Automovel { get; set; }
        public Oficina Oficina { get; set; }

        public Manutencao()
        {
        }

        public Manutencao(int id, DateTime dataManutencao, DateTime dataProxManu, string servico, string tipo, Automovel automovel, Oficina oficina, double valor)
        {
            this.Id = id;
            this.DataManutencao = dataManutencao;
            this.DataProxManu = dataProxManu;
            this.Servico = servico;
            this.Tipo = tipo;
            this.Automovel = automovel;
            this.Oficina = oficina;
            this.Valor = valor;
        }
    }
}