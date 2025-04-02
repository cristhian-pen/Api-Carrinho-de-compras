using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CarrinhoComprasAPI.Models;

public class Endereco
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonIgnore]
    public int IdEndereco{ get; init;}
    public string? NmEndereco{ get; set;}
    public string? NmBairro {get; set;}
    public string? NmCidade{ get; set;}
    public string? NumCasa{ get; set;}
    public string? Uf{ get; set;}
    public string? CEP{ get; set;}

    [JsonIgnore]
    public int CdUsuario {get; set;}

}