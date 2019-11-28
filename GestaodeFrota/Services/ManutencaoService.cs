using GestaodeFrota.Data;
using GestaodeFrota.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class ManutencaoService
    {
        private readonly ApplicationDbContext _context;


        public ManutencaoService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Busca um lista de manuencao ordenada por data
        public List<Manutencao> FindAll()
        {
            return _context.Manutencao.OrderBy(x => x.DataManutencao).ToList();
        }

        //Inserindo Um Manutencao no banco de dados
        public void Insert(Manutencao obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        // Metodo de buscar Manutencao por Id Utilizando o LINQ
        public Manutencao FindById(int id)
        {
            return _context.Manutencao.Include(obj => obj.Automovel).Include(obj => obj.Oficina).FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um Manutencao por ID
        public void Remove(int id)
        {
            var obj = _context.Manutencao.Find(id);
            _context.Manutencao.Remove(obj);
            _context.SaveChanges();
        }

    }
}