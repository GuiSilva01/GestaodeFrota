using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Viagem
    {
        public int Id { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataChegada { get; set; }
        public int OdometroSaida { get; set; }
        public int OdodmetroChegada { get; set; }
        public string DestinoSaida { get; set; }
        public string DestinoChegada { get; set; }
        public string DescriçaoViagem { get; set; }
        public Automovel Automovel { get; set; }
        public Motorista Motorista { get; set; }

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