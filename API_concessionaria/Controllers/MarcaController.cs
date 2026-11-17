using API_concessionaria.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_concessionaria.Controllers
{
    [Route("api/[controller]")]   // rota: api/marca
    [ApiController]
    public class MarcaController : ControllerBase
    {
        // O garçom guarda o cardápio (o acesso à cozinha).
        private readonly IMarcaRepository _marcaRepository;

        // Injeção de dependência: a API entrega o MarcaRepository
        // (por causa do AddScoped do passo 11).
        public MarcaController(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        // GET api/marca
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_marcaRepository.ListarTodos());   // 200 + lista em JSON
        }
    }
}