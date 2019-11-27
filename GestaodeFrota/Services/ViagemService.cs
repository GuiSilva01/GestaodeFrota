using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class ViagemService
    {
        private readonly ApplicationDbContext _context;


        public ViagemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Viagem> FindAll()
        {
            return _context.Viagem.OrderBy(x => x.DataSaida).ToList();
        }

        //Inserindo Um Viagem no banco de dados
        public void Insert(Viagem obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}