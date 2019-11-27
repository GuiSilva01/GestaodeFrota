using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace GestaodeFrota.Models
{
    public class Apolice
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public Seguro Seguro { get; set; }
        public ICollection<Automovel> Automovel { get; set; } = new List<Automovel>();

        public Apolice()
        {
        }

        public Apolice(int id, string tipo, string descricao, Seguro seguro)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Descricao = descricao;
            this.Seguro = seguro;
        }
        //Metodo para adicionar e remover um automovel
        public void AddAutomovel(Automovel atm)
        {
            Automovel.Add(atm);
        }

        public void RemoveAutomovel(Automovel atm)
        {
            Automovel.Remove(atm);
        }
    }
}