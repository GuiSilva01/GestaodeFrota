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
            return _context.Viagem.ToList();
        }

    }
}