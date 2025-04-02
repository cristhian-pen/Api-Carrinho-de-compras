using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CarrinhoComprasAPI.Models;

public class CarrinhoCompra
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTransacao{ get; init;}
    public string? CdEmpresa{ get; set;}
    public string? TipPagamento {get; set;}
    public string? NmCartao{ get; set;}
    public string? QtdProduto{ get; set;}
    public string? VlTotal{ get; set;}

    [JsonIgnore]
    public Cliente ? Cliente { get; set; }

    [JsonIgnore]
    public ICollection<Produtos> ?Produtos {get; set;}
    
    [JsonIgnore]
    public ICollection<Logs> ?Logs {get; set;}

}