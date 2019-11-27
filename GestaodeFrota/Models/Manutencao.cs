using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Manutencao
    {
        public int Id { get; set; }
        [Display(Name = "Data da Manuteção")]
        [DataType(DataType.Date)]
        public DateTime DataManutencao { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Quando será a Proxima Manutenção")]
        public DateTime DataProxManu { get; set; }
        [Display(Name = "Qual Foi o Serviço Realizado")]
        public string Servico { get; set; }
        [Display(Name = "Que tipo de Manutenção (Corretiva / Precativa)")]
        public string Tipo { get; set; }
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public double Valor { get; set; }
        public Automovel Automovel { get; set; }
        [Display(Name = "Qual Automovel fez a Manutenção ")]
        public int AutomovelId { get; set; }
        public Oficina Oficina { get; set; }
        [Display(Name = "Qual Oficina Foi Realizado essa Manutenção  ")]
        public int OficinaId { get; set; }

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