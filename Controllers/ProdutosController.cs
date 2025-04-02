using CarrinhoComprasAPI.Data;
using CarrinhoComprasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarrinhoComprasAPI.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly Db ? _context;

        public ProdutosController(Db ? context)
        {
            _context = context;
        }

        [HttpGet("/retornaProdutos")]
        public async Task<ActionResult<Produtos>> GetProdutos(Produtos produtos)
        {
            var produto = await _context!.Produtos.FindAsync(produtos);

            if (produto == null)
            {
                return BadRequest("Produtos não cadastrados!");
            }

            return Ok(produto);
        }
    } 
}