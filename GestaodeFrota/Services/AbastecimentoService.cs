using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class AbastecimentoService
    {
        private readonly ApplicationDbContext _context;


        public AbastecimentoService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Metodo para buscar um abastecimento do banco ordenado por data
        public List<Abastecimento> FindAll()
        {
            return _context.Abastecimento.OrderBy(x => x.DataAbaste).ToList();
        }

        //Inserindo Um abastecimento no banco de dados
        public void Insert(Abastecimento obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}