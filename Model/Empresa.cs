using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrinhoComprasAPI.Models;

public class Empresa
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CdEmpresa {get; set;}
    public string ? NmEmpresa {get; set;}
    public string? CNPJ {get; set;}
    public string? DtCadastro {get; set;}
}