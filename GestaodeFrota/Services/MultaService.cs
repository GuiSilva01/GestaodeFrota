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
    public class MultaService
    {
        private readonly ApplicationDbContext _context;


        public MultaService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Busca lista de multa Ordenada por 
        public List<Multa> FindAll()
        {
            return _context.Multa.OrderBy(x => x.DataMulta).ToList();
        }

        //Inserindo Um Multa no banco de dados
        public void Insert(Multa obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        // Metodo de buscar Multa por Id Utilizando o LINQ
        public Multa FindById(int id)
        {
            return _context.Multa.Include(obj => obj.Automovel).FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Multa por ID
        public void Remove(int id)
        {
            var obj = _context.Multa.Find(id);
            _context.Multa.Remove(obj);
            _context.SaveChanges();
        }

        //Metodo de Editar um Multa po ID
        public void Update(Multa obj)
        {
            if (!_context.Multa.Any(x => x.Id == obj.Id))
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