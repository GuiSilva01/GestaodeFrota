using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaodeFrota.Models
{
    public class Posto
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Posto")]
        public string NomePosto { get; set; }
        [Display(Name = "Endereco do Posto")]
        public string EnderecoPosto { get; set; }
        public ICollection<Abastecimento> Abastecimento { get; set; } = new List<Abastecimento>();

        public Posto()
        {
        }

        public Posto(int id, string nomePosto, string enderecoPosto)
        {
            this.Id = id;
            this.NomePosto = nomePosto;
            this.EnderecoPosto = enderecoPosto;
        }
        //Metodo para adicionar um abastecimento
        public void AddAbastecimento(Abastecimento abt)
        {
            Abastecimento.Add(abt);
        }


    }
}