using CodeFirstSolo.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstSolo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly CadastroDeAnimaisDbContext _context;

        public AnimalController(CadastroDeAnimaisDbContext context)
        {
            _context = context;
        }

        [HttpPost()]
        public void Post([FromBody] Animais animais)
        {
            _context.Animal.Add(animais);
            _context.SaveChanges();
        }

        [HttpGet()]
        public async Task<List<Animais>> Get ()
        {
            return _context.Animal.ToList();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeletarCadastro(int id)
        {
            var DeletarCadastro = await _context.Animal.FindAsync(id);
            if (id == null)
            {
                return NotFound();
            }

            _context.Animal.Remove(DeletarCadastro);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
