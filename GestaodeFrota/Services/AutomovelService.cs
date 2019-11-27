using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Services
{
    public class AutomovelService
    {
        private readonly ApplicationDbContext _context;


        public AutomovelService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Busca os automoveis Disponiveis do banco
        public List<Automovel> FindAll()
        {
            return _context.Automovel.Where(model => model.Disponivel == true).ToList();
        }

        //Inserindo Um Automovel no banco de dados
        public void Insert(Automovel obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        
    }
}