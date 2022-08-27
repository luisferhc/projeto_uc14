using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projeto_uc14.Repositories;

namespace projeto_uc14.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRep)
        {
            _livroRepository = livroRep;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try {
                return Ok(_livroRepository.Listar());

            } catch (Exception e) {

                throw new Exception(e.Message);
            }
        }
    }
}
