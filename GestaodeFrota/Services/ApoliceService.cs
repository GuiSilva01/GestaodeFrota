using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Services
{
    public class ApoliceService
    {
        private readonly ApplicationDbContext _context;


        public ApoliceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Apolice> FindAll()
        {
            return _context.Apolice.ToList();
        }

        //Inserindo Um Apolice no banco de dados
        public void Insert(Apolice obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        // Metodo de buscar Apolice por Id Utilizando o LINQ
        public Apolice FindById(int id)
        {
            return _context.Apolice.FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Apolice por ID
        public void Remove(int id)
        {
            var obj = _context.Apolice.Find(id);
            _context.Apolice.Remove(obj);
            _context.SaveChanges();
        }

    }
}