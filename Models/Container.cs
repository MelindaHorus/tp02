using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


public class Container
{
    [Key]
    public int ContainerId { get; set; }

    [Required]
    public string NumeroContainer { get; set; }

    public string Tipo { get; set; }

    public string Tamanho { get; set; }

    // Chave estrangeira
    [ForeignKey("BL")]
    public int BLId { get; set; }

    public virtual BL BL { get; set; }
}
