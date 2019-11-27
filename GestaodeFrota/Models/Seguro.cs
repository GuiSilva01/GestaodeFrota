using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Seguro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorSeguro { get; set; }
        public DateTime Validade { get; set; }

        public ICollection<Apolice> Apolice { get; set; } = new List<Apolice>();

        public Seguro()
        {
        }

        public Seguro(int id, string nome, double valorSeguro, DateTime validade)
        {
            this.Id = id;
            this.Nome = nome;
            this.ValorSeguro = valorSeguro;
            this.Validade = validade;
        }

        public void AddApolice(Apolice ap)
        {
            Apolice.Add(ap);
        }

        public void RemoveApolice(Apolice ap)
        {
            Apolice.Remove(ap);
        }
    }
}