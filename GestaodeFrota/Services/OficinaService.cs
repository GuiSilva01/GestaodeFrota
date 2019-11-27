using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class OficinaService
    {
        private readonly ApplicationDbContext _context;


        public OficinaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Oficina> FindAll()
        {
            return _context.Oficina.ToList();
        }

    }
}