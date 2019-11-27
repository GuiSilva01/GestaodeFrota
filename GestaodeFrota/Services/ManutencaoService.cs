using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class ManutencaoService
    {
        private readonly ApplicationDbContext _context;


        public ManutencaoService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Busca um lista de manuencao ordenada por data
        public List<Manutencao> FindAll()
        {
            return _context.Manutencao.OrderBy(x => x.DataManutencao).ToList();
        }

        //Inserindo Um Manutencao no banco de dados
        public void Insert(Manutencao obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}