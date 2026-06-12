using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal.Controllers
{
    public class InstrumentosController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AdicionarInstrumentos()
        {
            return View();
        }
        public IActionResult Orgao()
        {
            return View();
        }
        public IActionResult Madeiras()
        {
            return View();
        }
        public IActionResult Metais()
        {
            return View();
        }
        public IActionResult Cordas()
        {
            return View();
        }
        public IActionResult Teclas()
        {
            return View();
        }
        public IActionResult Percussao()
        {
            return View();
        }

    }
}
