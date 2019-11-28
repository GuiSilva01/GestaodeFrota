using GestaodeFrota.Data;
using GestaodeFrota.Models;
using GestaodeFrota.Services.Exceptions;
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


        // Metodo de buscar Seguro por Id Utilizando o LINQ
        public Seguro FindById(int id)
        {
            return _context.Seguro.FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Seguro por ID
        public void Remove(int id)
        {
            var obj = _context.Seguro.Find(id);
            _context.Seguro.Remove(obj);
            _context.SaveChanges();
        }

        //Metodo de Editar um Seguro po ID
        public void Update(Seguro obj)
        {
            if (!_context.Seguro.Any(x => x.Id == obj.Id))
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