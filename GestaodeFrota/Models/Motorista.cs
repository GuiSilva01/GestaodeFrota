using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Motorista
    {
        public int Id { get; set; }
        public string NomeMotorista { get; set; }
        public DateTime DataNasc { get; set; }
        public string CNH { get; set; }
        public DateTime ValidadeCNH { get; set; }
        public Boolean Disponivel { get; set; }

        public Motorista()
        {

        }

        public Motorista(int id, string nomeMotorista, DateTime dataNasc, string cNH, DateTime validadeCNH, Boolean disponivel)
        {
            Id = id;
            NomeMotorista = nomeMotorista;
            DataNasc = dataNasc;
            CNH = cNH;
            ValidadeCNH = validadeCNH;
            Disponivel = disponivel;
        }
    }
}
