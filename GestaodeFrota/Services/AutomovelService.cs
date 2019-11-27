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

        public List<Automovel> FindAll()
        {
            return _context.Automovel.ToList();
        }

    }
}