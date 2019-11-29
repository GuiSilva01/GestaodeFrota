using GestaodeFrota.Data;
using GestaodeFrota.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Services
{
    public class CalcularAbastecimentoService
    {
        private readonly ApplicationDbContext _context;


        public CalcularAbastecimentoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Abastecimento>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Abastecimento select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataAbaste >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataAbaste <= maxDate.Value);
            }
            return await result
                .Include(x => x.Automovel)
                .OrderByDescending(x => x.DataAbaste)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Automovel,Abastecimento>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Abastecimento select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataAbaste >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataAbaste <= maxDate.Value);
            }
            return await result
                .Include(x => x.Automovel)
                .OrderByDescending(x => x.DataAbaste)
                .GroupBy(x => x.Automovel)
                .ToListAsync();
        }


    }
}
