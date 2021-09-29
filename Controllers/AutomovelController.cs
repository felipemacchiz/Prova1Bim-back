using Microsoft.AspNetCore.Mvc;
using Prova1Bim_back.Data;
using Prova1Bim_back.Models;
using System.Linq;

namespace Prova1Bim_back.Controllers
{
    [ApiController]
    [Route("concessionaria/automovel")]
    public class AutomovelController : ControllerBase
    {
        private readonly DataContext _context;
        public AutomovelController(DataContext context) => _context = context;

        // POST : concessionaria/automovel/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Automovel automovel)
        {
            _context.Automoveis.Add(automovel);
            _context.SaveChanges();
            return Created(" ", automovel);
        }

        // POST : concessionaria/automovel/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Automoveis.ToList());
    }
}