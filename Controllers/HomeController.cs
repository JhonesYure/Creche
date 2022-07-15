using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Creche.Models;

namespace Creche.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Informacao cad)
        {
            try
            {
                CrecheService cs = new CrecheService();
                cs.CadastrarInformacao(cad);

                return Json(new {status="OK"});
            } 
            catch (Exception e)
            {
               _logger.LogError("Erro ao enviar para banco de dados"+e.Message);

               return Json(new{status="Erro", mensagem="Falha ao envio"});
            }
        }
    }
}
