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

        public List<Manutencao> FindAll()
        {
            return _context.Manutencao.ToList();
        }

    }
}