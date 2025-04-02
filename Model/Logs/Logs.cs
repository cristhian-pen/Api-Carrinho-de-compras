using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrinhoComprasAPI.Models;

public class Logs
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdLog{ get; init;}
    public string? DtLog{ get; set;}
    public string? HrLog{ get; set;}
    public string? Description{ get; set;}

    public CarrinhoCompra ? CarrinhoCompra { get; set; }

    public void LogsModel( string description )
    {
        DtLog = DateTime.Today.ToString("yyyy-mm-dd");
        HrLog = DateTime.Now.ToString();
        Description = description;
    }
}
