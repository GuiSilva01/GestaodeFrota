using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Services
{
    public class TodosAutomovelService
    {
        private readonly ApplicationDbContext _context;


        public TodosAutomovelService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Busca os automoveis Disponiveis do banco
        public List<Automovel> FindAll()
        {
            return _context.Automovel.OrderBy(x => x.Ano).ToList();
        }
    }
}
