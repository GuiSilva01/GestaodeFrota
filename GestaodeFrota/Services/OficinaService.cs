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

        //Inserindo Um Oficina no banco de dados
        public void Insert(Oficina obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        // Metodo de buscar Oficina por Id Utilizando o LINQ
        public Oficina FindById(int id)
        {
            return _context.Oficina.FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Oficina por ID
        public void Remove(int id)
        {
            var obj = _context.Oficina.Find(id);
            _context.Oficina.Remove(obj);
            _context.SaveChanges();
        }

        //Metodo de Editar um Oficina po ID
        public void Update(Oficina obj)
        {
            if (!_context.Oficina.Any(x => x.Id == obj.Id))
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