using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaodeFrota.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestaodeFrota.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly SeguroService _seguroService;
        private readonly ApoliceService _apoliceService;
        private readonly AutomovelService _automovelService;
        private readonly AbastecimentoService _abastecimentoService;
        private readonly ManutencaoService _manutencaoService;
        private readonly MotoristaService _motoristaService;
        private readonly MultaService _multaService;
        private readonly OficinaService _oficinaService;
        private readonly PostoService _postoService;
        private readonly ViagemService _viagemService;

        
        public ConsultasController(SeguroService seguroService, ApoliceService apoliceService, AutomovelService automovelService, AbastecimentoService abastecimentoService, ManutencaoService manutencaoService, MotoristaService motoristaService, MultaService multaService, OficinaService oficinaService, PostoService postoService, ViagemService viagemService)
        {
            _seguroService = seguroService;
            _apoliceService = apoliceService;
            _automovelService = automovelService;
            _abastecimentoService = abastecimentoService;
            _manutencaoService = manutencaoService;
            _motoristaService = motoristaService;
            _multaService = multaService;
            _oficinaService = oficinaService;
            _postoService = postoService;
            _viagemService = viagemService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SelectMotorista()
        {
           
            var list = _motoristaService.FindAll();
            return View(list);
        }

        public IActionResult SelectAutomovel()
        {
            var list = _automovelService.FindAll();
            return View(list);
        }

        public IActionResult SelectViagem()
        {
            
            var list = _viagemService.FindAll();
            return View(list);
        }

        public IActionResult SelectAbastecimento()
        {
            
            var list = _abastecimentoService.FindAll();
            return View(list);
        }

        public IActionResult SelectPosto()
        {
           
            var list = _postoService.FindAll();
            return View(list);
        }

        public IActionResult SelectMulta()
        {
            
            var list = _multaService.FindAll();
            return View(list);
        }

        public IActionResult SelectSeguro()
        {
            var list = _seguroService.FindAll();
            return View(list);
        }
        public IActionResult SelectApolice()
        {
            var list = _apoliceService.FindAll();
            return View(list);
        }

        public IActionResult SelectManutencao()
        {
            
            var list = _manutencaoService.FindAll();
            return View(list);
        }

        public IActionResult SelectOficina()
        {
           
            var list = _oficinaService.FindAll();
            return View(list);
        }
    }
}