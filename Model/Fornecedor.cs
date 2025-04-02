using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CarrinhoComprasAPI.Models;

public class Fornecedor
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IDFornecedor { get; init;}
    public string? NmFornecedor{ get; set;}
    public string? CtoFornecedor {get; set;}
    public string? CNPJ{ get; set;}
    public string? TipFornecedor{ get; set;}
    public string? DtCadastro{ get; set;}

    [JsonIgnore]
    [ForeignKey("IdEnderecos")]
    public Endereco ? Endereco { get; set; }

    public ICollection<Produtos> ?Produtos {get; set;}

}