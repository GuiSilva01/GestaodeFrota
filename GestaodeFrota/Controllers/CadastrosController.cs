using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GestaodeFrota.Controllers
{
    public class CadastrosController : Controller
    {
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
            return View();
        }

        public IActionResult CreateViagem()
        {
            return View();
        }

        public IActionResult CreateAbastecimento()
        {
            return View();
        }

        public IActionResult CreatePosto()
        {
            return View();
        }

        public IActionResult CreateMulta()
        {
            return View();
        }

        public IActionResult CreateSeguro()
        {
            return View();
        }

        public IActionResult CreateApolice()
        {
            return View();
        }

        public IActionResult CreateManutencao()
        {
            return View();
        }

        public IActionResult CreateOficina()
        {
            return View();
        }
    }
}