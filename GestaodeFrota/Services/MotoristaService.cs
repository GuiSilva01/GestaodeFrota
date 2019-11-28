using GestaodeFrota.Data;
using GestaodeFrota.Models;
using GestaodeFrota.Services.Exceptions;
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
        //Retornando o uma lista de motorista do banco de dados disponiveis
        public List<Motorista> FindAll()
        {
            return _context.Motorista.Where(model => model.Disponivel == true).ToList();
        }

        //Inserindo Um Motorista no banco de dados
        public void Insert(Motorista obj)
        {
            _context.Add(obj);        
            _context.SaveChanges();
        }

        //Metodo de Editar um Motorista po ID
        public void Update(Motorista obj)
        {
            if (!_context.Motorista.Any(x => x.Id == obj.Id))
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