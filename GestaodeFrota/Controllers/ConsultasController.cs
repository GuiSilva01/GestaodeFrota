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
        private readonly TodosMotoristaService _todosMotorstaService;
        private readonly TodosAutomovelService _todosAutomovelService;

        
        public ConsultasController(SeguroService seguroService, ApoliceService apoliceService, AutomovelService automovelService, AbastecimentoService abastecimentoService, ManutencaoService manutencaoService, MotoristaService motoristaService, MultaService multaService, OficinaService oficinaService, PostoService postoService, ViagemService viagemService, TodosMotoristaService todosMotoristaService, TodosAutomovelService todosAutomovelService)
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
            _todosMotorstaService = todosMotoristaService;
            _todosAutomovelService = todosAutomovelService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SelectMotorista()
        {

            var list = _todosMotorstaService.FindAll();
            return View(list);
        }

        public IActionResult SelectAutomovel()
        {
            var list = _todosAutomovelService.FindAll();
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

        //Metodo Delete
        public IActionResult DeleteAbastecimento(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _abastecimentoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeleteApolice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _apoliceService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeleteAutomovel(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _todosAutomovelService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeleteManutencao(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _manutencaoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        public IActionResult DeleteMotorista(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _todosMotorstaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeleteMulta(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _multaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeleteOficina(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _oficinaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeletePosto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _postoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeleteSeguro(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _seguroService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeleteViagem(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _viagemService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteAbastecimento(int id)
        {
            _abastecimentoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteApolice(int id)
        {
            _apoliceService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteAutomovel(int id)
        {
            _todosAutomovelService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteManutencao(int id)
        {
            _manutencaoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMotorista(int id)
        {
            _todosMotorstaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMulta(int id)
        {
            _multaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteOficina(int id)
        {
            _oficinaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePosto(int id)
        {
            _postoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSeguro(int id)
        {
            _seguroService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteViagem(int id)
        {
            _viagemService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Metodo de Detalhes do Objeto

        public IActionResult DetailsAbastecimento(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _abastecimentoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsApolice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _apoliceService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsAutomovel(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _todosAutomovelService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsManutencao(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _manutencaoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsMotorista(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _todosMotorstaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsMulta(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _multaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsOficina(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _oficinaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsPosto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _postoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsSeguro(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _seguroService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult DetailsViagem(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _viagemService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult EditAbastecimento(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _abastecimentoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Automovel> automovels = _todosAutomovelService.FindAll();
            List<Posto> postos = _postoService.FindAll();
            AbastecimentoFormViewModel viewModel = new AbastecimentoFormViewModel { Abastecimento = obj, Automovels = automovels, Postos = postos };
            return View(viewModel);
        }

        public IActionResult EditApolice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _apoliceService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Seguro> seguros = _seguroService.FindAll();
            ApoliceFormViewModel viewModel = new ApoliceFormViewModel { Apolice = obj, Seguros = seguros };
            return View(viewModel);
        }

        public IActionResult EditAutomovel(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _todosAutomovelService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Apolice> apolices = _apoliceService.FindAll();
            AutomovelFormViewModel viewModel = new AutomovelFormViewModel { Automovel = obj, Apolices = apolices };
            return View(viewModel);
        }

        public IActionResult EditManutencao(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _manutencaoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Automovel> automovels = _todosAutomovelService.FindAll();
            List<Oficina> oficinas = _oficinaService.FindAll();
            ManutencaoFormViewModel viewModel = new ManutencaoFormViewModel { Manutencao = obj, Automovels = automovels, Oficinas = oficinas  };
            return View(viewModel);
        }

        public IActionResult EditMotorista(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _todosMotorstaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            
            return View();
        }

        public IActionResult EditMulta(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _multaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Automovel> automovels = _todosAutomovelService.FindAll();
            MultaFormViewModel viewModel = new MultaFormViewModel { Multa = obj, Automovels = automovels };
            return View(viewModel);
        }

        public IActionResult EditOficina(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _oficinaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }


            return View();
        }

        public IActionResult EditPosto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _postoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }


            return View();
        }

        public IActionResult EditSeguro(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _seguroService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }


            return View();
        }

        public IActionResult EditViagem(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _viagemService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Automovel> automovels = _automovelService.FindAll();
            List<Motorista> motoristas = _motoristaService.FindAll();
            ViagemFormViewModel viewModel = new ViagemFormViewModel { Viagem = obj, Automovels = automovels, Motoristas = motoristas };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAbastecimento(int id, Abastecimento abastecimento)
        {
            if (id != abastecimento.Id)
            {
                return BadRequest();
            }
            _abastecimentoService.Update(abastecimento);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditApolice(int id, Apolice apolice)
        {
            if (id != apolice.Id)
            {
                return BadRequest();
            }
            _apoliceService.Update(apolice);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAutomovel(int id, Automovel automovel)
        {
            if (id != automovel.Id)
            {
                return BadRequest();
            }
            _todosAutomovelService.Update(automovel);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditManutencao(int id, Manutencao manutencao)
        {
            if (id != manutencao.Id)
            {
                return BadRequest();
            }
            _manutencaoService.Update(manutencao);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMulta(int id, Multa multa)
        {
            if (id != multa.Id)
            {
                return BadRequest();
            }
            _multaService.Update(multa);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditViagem(int id, Viagem viagem)
        {
            if (id != viagem.Id)
            {
                return BadRequest();
            }
            _viagemService.Update(viagem);
            return RedirectToAction(nameof(Index));
        }

    }
}