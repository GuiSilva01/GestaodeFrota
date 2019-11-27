using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class LocacaoService
    {
        private readonly ApplicationDbContext _context;


        public LocacaoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Locacao> FindAll()
        {
            return _context.Locacao.OrderBy(x => x.DataLocacao).ToList();
        }

        //Inserindo Um Locacao no banco de dados
        public void Insert(Locacao obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}