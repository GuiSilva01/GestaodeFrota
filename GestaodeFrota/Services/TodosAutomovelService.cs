using GestaodeFrota.Data;
using GestaodeFrota.Models;
using GestaodeFrota.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Services
{
    public class TodosAutomovelService
    {
        private readonly ApplicationDbContext _context;


        public TodosAutomovelService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Busca os automoveis Disponiveis do banco
        public List<Automovel> FindAll()
        {
            return _context.Automovel.OrderBy(x => x.Ano).ToList();
        }

        // Metodo de buscar Automovel por Id Utilizando o LINQ
        public Automovel FindById(int id)
        {
            return _context.Automovel.Include(obj => obj.Apolice).FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Automovel por ID
        public void Remove(int id)
        {
            var obj = _context.Automovel.Find(id);
            _context.Automovel.Remove(obj);
            _context.SaveChanges();
        }

        //Metodo de Editar um Automovel po ID
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
