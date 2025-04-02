using CarrinhoComprasAPI.Models;

namespace CarrinhoComprasAPI.Services;


public interface IClientes
{
    Task<ResponseModel<List<Cliente>>> ListarClientes();
    Task<ResponseModel<Cliente>> BuscarClienteId(int idCliente);
}