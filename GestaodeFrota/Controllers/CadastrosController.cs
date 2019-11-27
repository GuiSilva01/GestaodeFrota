using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaodeFrota.Models;
using GestaodeFrota.Models.ViewModels;
using GestaodeFrota.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestaodeFrota.Controllers
{
    public class CadastrosController : Controller
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
        private readonly TodosAutomovelService _todosAutomovelService;
        private readonly TodosMotoristaService _todosMotoristaService;

        


        public CadastrosController(SeguroService seguroService, ApoliceService apoliceService, AutomovelService automovelService, AbastecimentoService abastecimentoService, ManutencaoService manutencaoService, MotoristaService motoristaService, MultaService multaService, OficinaService oficinaService, PostoService postoService, ViagemService viagemService, TodosAutomovelService todosAutmovelService, TodosMotoristaService todosMotoristaService)
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
            _todosAutomovelService = todosAutmovelService;
            _todosMotoristaService = todosMotoristaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateMotorista()
        {
            return View();
        }

        public IActionResult CreateAutomovel()
        {
            var apolices = _apoliceService.FindAll();
            var viewModel = new AutomovelFormViewModel { Apolices = apolices };
            return View(viewModel);
        }

        public IActionResult CreateViagem()
        {

            var automovels = _automovelService.FindAll();
            var motoristas = _motoristaService.FindAll();
            var viewModel = new ViagemFormViewModel { Automovels = automovels, Motoristas = motoristas };
            return View(viewModel);
        }

        public IActionResult CreateAbastecimento()
        {
            var automovels = _todosAutomovelService.FindAll();
            var postos = _postoService.FindAll();
            var viewModel = new AbastecimentoFormViewModel { Automovels = automovels, Postos = postos };
            return View(viewModel);
        }

        public IActionResult CreatePosto()
        {
            return View();
        }

        public IActionResult CreateMulta()
        {
            var automovels = _todosAutomovelService.FindAll();  
            var viewModel = new MultaFormViewModel { Automovels = automovels };
            return View(viewModel);
        }

        public IActionResult CreateSeguro()
        {
            return View();
        }

        public IActionResult CreateApolice()
        {
            var seguros = _seguroService.FindAll();
            var viewModel = new ApoliceFormViewModel { Seguros = seguros };
            return View(viewModel);
        }

        public IActionResult CreateManutencao()
        {
            var automovels = _todosAutomovelService.FindAll();
            var oficinas = _oficinaService.FindAll();
            var viewModel = new ManutencaoFormViewModel { Automovels = automovels, Oficinas = oficinas };
            return View(viewModel);
        }

        public IActionResult CreateOficina()
        {
            return View();
        }

        // Metodo POST para Inserir um Abastecimento no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAbastecimento(Abastecimento abastecimento)
        {
            _abastecimentoService.Insert(abastecimento);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir uma Apolice no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateApolice(Apolice apolice)
        {
            _apoliceService.Insert(apolice);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir um automovel no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAutomovel(Automovel automovel)
        {
            _automovelService.Insert(automovel);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir uma manutencao no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateManutencao(Manutencao manutencao)
        {
            _manutencaoService.Insert(manutencao);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir um Motorista no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMotorista(Motorista motorista)
        {
            _motoristaService.Insert(motorista);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir uma multa no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMulta(Multa multa)
        {
            _multaService.Insert(multa);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir uma oficina no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOficina(Oficina oficina)
        {
            _oficinaService.Insert(oficina);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir um posto no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePosto(Posto posto)
        {
            _postoService.Insert(posto);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir um seguro no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSeguro(Seguro seguro)
        {
            _seguroService.Insert(seguro);
            return RedirectToAction(nameof(Index));
        }

        // Metodo POST para Inserir uma viagem no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateViagem(Viagem viagem)
        {
            
            _viagemService.Insert(viagem);
            return RedirectToAction(nameof(Index));
        }
    }
}