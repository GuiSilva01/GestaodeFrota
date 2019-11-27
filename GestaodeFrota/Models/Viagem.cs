using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Viagem
    {
        public int Id { get; set; }
        [Display(Name = "Data e Horario de Saída do Automovel")]
        public DateTime DataSaida { get; set; }
        [Display(Name = "Data e Horario de Chegada do Automovel ")]
        public DateTime DataChegada { get; set; }
        [Display(Name = "Odometro de Saída")]
        public int OdometroSaida { get; set; }
        [Display(Name = "Odometro de Chegada")]
        public int OdodmetroChegada { get; set; }
        [Display(Name = "Destino de Saída")]
        public string DestinoSaida { get; set; }
        [Display(Name = "Destino de Chegada")]
        public string DestinoChegada { get; set; }
        [Display(Name = "Descrição da Viagem")]
        public string DescriçaoViagem { get; set; }
        public Automovel Automovel { get; set; }
        [Display(Name = "Automoveis Disponíveis")]
        public int AutomovelId { get; set; }
        public Motorista Motorista { get; set; }
        [Display(Name = "Motoristas Disponíveis")]
        public int MotoristaId { get; set; }

        public Viagem()
        {
        }

        public Viagem(int id, DateTime dataSaida, DateTime dataChegada, int odometroSaida, int ododmetroChegada, string destinoSaida, string destinoChegada, string descriçaoViagem, Automovel automovel, Motorista motorista)
        {
            this.Id = id;
            this.DataSaida = dataSaida;
            this.DataChegada = dataChegada;
            this.OdometroSaida = odometroSaida;
            this.OdodmetroChegada = ododmetroChegada;
            this.DestinoSaida = destinoSaida;
            this.DestinoChegada = destinoChegada;
            this.DescriçaoViagem = descriçaoViagem;
            this.Automovel = automovel;
            this.Motorista = motorista;
        }
    }
}