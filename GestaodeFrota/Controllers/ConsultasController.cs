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
    }
}