using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class PostoService
    {
        private readonly ApplicationDbContext _context;


        public PostoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Posto> FindAll()
        {
            return _context.Posto.ToList();
        }


        //Inserindo Um Posto no banco de dados
        public void Insert(Posto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        // Metodo de buscar Posto por Id Utilizando o LINQ
        public Posto FindById(int id)
        {
            return _context.Posto.FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Posto por ID
        public void Remove(int id)
        {
            var obj = _context.Posto.Find(id);
            _context.Posto.Remove(obj);
            _context.SaveChanges();
        }

    }
}