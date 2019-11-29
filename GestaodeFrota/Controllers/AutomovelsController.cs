using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestaodeFrota.Services;

namespace GestaodeFrota.Controllers
{
    public class AutomovelsController : Controller
    {
        private readonly CalcularAbastecimentoService _calcularAbastecimentoService;

        public AutomovelsController(CalcularAbastecimentoService calcularAbastecimentoService)
        {
            _calcularAbastecimentoService = calcularAbastecimentoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!minDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-mm-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-mm-dd");
            var result = await _calcularAbastecimentoService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!minDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-mm-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-mm-dd");
            var result = await _calcularAbastecimentoService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }
    }
}