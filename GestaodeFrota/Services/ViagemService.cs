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
    public class ViagemService
    {
        private readonly ApplicationDbContext _context;


        public ViagemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Viagem> FindAll()
        {
            return _context.Viagem.OrderBy(x => x.DataSaida).ToList();
        }

        //Inserindo Um Viagem no banco de dados
        public void Insert(Viagem obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


        // Metodo de buscar Viagem por Id Utilizando o LINQ
        public Viagem FindById(int id)
        {
            return _context.Viagem.Include(obj => obj.Motorista).Include(obj => obj.Automovel).FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Viagem por ID
        public void Remove(int id)
        {
            var obj = _context.Viagem.Find(id);
            _context.Viagem.Remove(obj);
            _context.SaveChanges();
        }

        //Metodo de Editar um Viagem po ID
        public void Update(Viagem obj)
        {
            if (!_context.Viagem.Any(x => x.Id == obj.Id))
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