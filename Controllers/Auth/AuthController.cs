using CarrinhoComprasAPI.Data;
using CarrinhoComprasAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace CarrinhoComprasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public readonly Db ? _context;

        public AuthController(Db? context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Cliente>> AutenticaCliente( string email, string password, Cliente cliente)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return BadRequest("Cliente não encontrado");
            }

            var validaCliente = await _context!.Cliente.FirstOrDefaultAsync(c => c.Email == email && c.PassWd == password);

            if (validaCliente is null)
            {
                return BadRequest("Usuario ou senha invalidos!");
            }

            return Ok("Usuario autenticado");
        }
    }
}