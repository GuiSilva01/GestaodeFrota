using GestaodeFrota.Data;
using GestaodeFrota.Models;
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
            return _context.Multa.FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Multa por ID
        public void Remove(int id)
        {
            var obj = _context.Multa.Find(id);
            _context.Multa.Remove(obj);
            _context.SaveChanges();
        }

    }
}