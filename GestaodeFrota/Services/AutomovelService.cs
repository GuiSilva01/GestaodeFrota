using GestaodeFrota.Data;
using GestaodeFrota.Models;
using GestaodeFrota.Services.Exceptions;
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

        //Busca os automoveis Disponiveis do banco
        public List<Automovel> FindAll()
        {
            return _context.Automovel.Where(model => model.Disponivel == true).ToList();
        }

        //Inserindo Um Automovel no banco de dados
        public void Insert(Automovel obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Automovel obj)
        {
            if (!_context.Automovel.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id nao existe");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }


    }
}