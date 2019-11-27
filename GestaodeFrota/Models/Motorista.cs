using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Motorista
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Motorista")]
        public string NomeMotorista { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }
        public string CNH { get; set; }
        [Display(Name = "Validade da CNH")]
        [DataType(DataType.Date)]
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
