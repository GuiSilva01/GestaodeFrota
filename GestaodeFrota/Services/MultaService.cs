using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class MultaService
    {
        private readonly ApplicationDbContext _context;


        public MultaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Multa> FindAll()
        {
            return _context.Multa.ToList();
        }

    }
}