using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrinhoComprasAPI.Models;

public class Produtos
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdProduto{ get; init;}
    public string? NmProduto{ get; set;}
    public string? MarcaProduto {get; set;}
    public string? ModeloProduto{ get; set;}
    public int AnoProduto{ get; set;}
    public string? TipPeça{ get; set;}
    public double QntEstoque{ get; set;}
    public string? DtCadastro{ get; set;}
    public double PrecoProduto{ get; set;}

    public Produtos ? Produto { get; set; }

    public Cliente ? Cliente { get; set; }

    public ICollection<Produtos> ? CarrinhoCompra { get; set; }

}