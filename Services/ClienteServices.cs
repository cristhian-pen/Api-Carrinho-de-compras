using CarrinhoComprasAPI.Data;
using CarrinhoComprasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrinhoComprasAPI.Services;

public class ClienteServices : IClientes
{   
    public readonly Db _context;

    public ClienteServices(Db context)
    {
        _context = context;
    }
    public async Task<ResponseModel<Cliente>> BuscarClienteId(int idCliente)
    {
        ResponseModel<Cliente> response = new ResponseModel<Cliente>();

        try
        {
            var cliente = await _context.Cliente.FirstOrDefaultAsync(clienteBanco => clienteBanco.CdUsuario == idCliente);

            if(cliente == null)
            {
                response.Mensagem = "Cliente não encontrado";
                return response;
            }
            response.Dados = cliente;
            response.Mensagem = "Cliente Localizado!";

            return response;
        }
        catch (Exception ex)
        {
            response.Mensagem = ex.Message;
            response.Status = false;
            return response;
        }

    }

    public async Task<ResponseModel<List<Cliente>>> ListarClientes()
    {
        ResponseModel<List<Cliente>> response = new ResponseModel<List<Cliente>>();
        try
        {
            var cliente = await _context.Cliente.ToListAsync();
            
            response.Dados = cliente;

            return response;
        }
        catch (Exception ex)
        {
            response.Mensagem = ex.Message;
            response.Status = false;
            return response;
        }
    }
}