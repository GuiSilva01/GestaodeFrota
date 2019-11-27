using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class MotoristaService
    {
        private readonly ApplicationDbContext _context;


        public MotoristaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Motorista> FindAll()
        {
            return _context.Motorista.ToList();
        }

    }
}