using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CarrinhoComprasAPI.Models;

public class Cliente
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonIgnore]
    public int CdUsuario{ get; init;}
    [Required]
    public string? NmUsuario{ get; set;}
    [Required]
    public string? DtNascimento {get; set;}
    [Required]
    public string? Email{ get; set;}
    [Required]
    public string? Telefone{ get; set;}
    [Required]
    public string? CPF{ get; set;}
    public string? CNPJ{ get; set;}
    [Required]
    public string? TipCliente{ get; set;}
    [Required]
    public string? PassWd{ get; set;}
    
    public string? TipUsuario{ get; set;}
    [JsonIgnore]
    public string? DtCadastro{ get; set;}
    [JsonIgnore]
    public string? ClienteActive{get; set;}

    [JsonIgnore]
    [ForeignKey("IdEndereco")]
    public Endereco ? Endereco {get; set; }

    [JsonIgnore]
    public ICollection<DadosPagamento>? DataCard {get; set;}

    public void SetInactive()
    {
            ClienteActive = "Inactive";
    }

    public void SetActive()
    {
        ClienteActive = "Active";
    }

    public void GetDtCadastro(string date)
    {
        DtCadastro = date;
    }
}