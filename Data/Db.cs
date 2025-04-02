using CarrinhoComprasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrinhoComprasAPI.Data;

public class Db : DbContext
{
    public DbSet<Cliente> Cliente {get; set;}
    public DbSet<Endereco> Endereco {get; set;}
    public DbSet<Fornecedor> Fornecedor {get; set;}
    public DbSet<Produtos> Produtos {get; set;}
    public DbSet<DadosPagamento> DadosPagamento {get; set;}
    public DbSet<CarrinhoCompra> CarrinhoCompra {get; set;}
    public DbSet<Logs> Logs {get; set;}
    public DbSet<Empresa> Empresa {get;set;}

    const string connectionString = " ";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString: connectionString, ServerVersion.AutoDetect(connectionString));
        base.OnConfiguring(optionsBuilder);
    }
}
