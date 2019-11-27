using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class TodosMotoristaService
    {
        private readonly ApplicationDbContext _context;


        public TodosMotoristaService(ApplicationDbContext context)
        {
            _context = context;
        }
        //Retornando o uma lista de motorista do banco de dados disponiveis
        public List<Motorista> FindAll()
        {
            return _context.Motorista.OrderBy(x => x.NomeMotorista).ToList();
        }

        // Metodo de buscar Motorista por Id Utilizando o LINQ
        public Motorista FindById(int id)
        {
            return _context.Motorista.FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Motorista por ID
        public void Remove(int id)
        {
            var obj = _context.Motorista.Find(id);
            _context.Motorista.Remove(obj);
            _context.SaveChanges();
        }
    }
}