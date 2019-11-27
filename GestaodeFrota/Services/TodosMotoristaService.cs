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
    }
}