using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrinhoComprasAPI.Models;

public class DadosPagamento
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CdCard{ get; init;}
    public string? NmCartao{ get; set;}
    public string? NumCard {get; set;}
    public string? DtValidade{ get; set;}
    public string? CVV{ get; set;}
    public string? ApelidoCartao{ get; set;}

    public Cliente ? Cliente { get; set; }

}