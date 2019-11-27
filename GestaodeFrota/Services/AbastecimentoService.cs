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

        public List<Abastecimento> FindAll()
        {
            return _context.Abastecimento.ToList();
        }

    }
}