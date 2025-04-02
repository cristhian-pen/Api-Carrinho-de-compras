using CarrinhoComprasAPI.Data;
using CarrinhoComprasAPI.Models;
using CarrinhoComprasAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CarrinhoComprasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
       private readonly IClientes _clienteInterface;
        private readonly Db ? _context;

        public ClienteController(Db? context, IClientes clienteInterface)
        {
            _context = context;
            _clienteInterface = clienteInterface;
        }

        [HttpGet("ListarClientes")]
        public async Task<ActionResult<ResponseModel<List<Cliente>>>>ListarClientes()
        {
            var clientes = await _clienteInterface.ListarClientes();
            return Ok(clientes);
        }


        [HttpGet("BuscarClienteId/{idCliente}")]
        public async Task<ActionResult<ResponseModel<Cliente>>>BuscarClienteId(int idCliente, Logs log)
        {
            var cliente = await _clienteInterface.BuscarClienteId(idCliente);
            return Ok(cliente);
        } 

        [HttpPost("CadastrarCliente")]
        public async Task<ActionResult<Cliente>> CadastrarCliente([FromBody] Cliente cliente)
        {

            if (cliente == null)
            {
                return BadRequest();
            }

            var datetime = DateTime.UtcNow.ToString();

            await _context!.Cliente!.AddAsync(cliente);
            cliente.SetActive();
            cliente.GetDtCadastro(datetime);
            _context.SaveChanges();

            return Ok("Cliente Cadastrado");
        }

        
        [HttpPut("AtualizaCliente/{id:int}")]
        public async Task<ActionResult<Cliente>> AtualizarCliente( int id ,Cliente cliente)
        {
            
            var IdCliente  = await _context!.Cliente.FirstOrDefaultAsync(p=> p.CdUsuario == id);
            
            if(IdCliente is null)
            {
                return BadRequest("Cliente não encontrado");
            }

            _context!.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok("Dados Alterados");

        }

        [HttpDelete("DeletaCliente/{id:int}")]
        public async Task<ActionResult<Cliente>>DeletaCliente(int id, Cliente cliente)
        {
            var clienteBusca = await _context!.Cliente.FindAsync(id);

            if(clienteBusca == null)
            {
                return NotFound("Cliente não cadastrado");
            }

           clienteBusca.SetInactive();
           _context.SaveChanges();
           return Ok("Usuario Desativado");
        }
    }
}
