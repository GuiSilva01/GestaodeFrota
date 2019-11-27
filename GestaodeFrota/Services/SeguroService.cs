using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class SeguroService
    {
        private readonly ApplicationDbContext _context;


        public SeguroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Seguro> FindAll()
        {
            return _context.Seguro.ToList();
        }

        //Inserindo Um Seguro no banco de dados
        public void Insert(Seguro obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}