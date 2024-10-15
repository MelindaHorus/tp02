using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class BL
{
    [Key]
    public int BLId { get; set; }

    [Required]
    public string NumeroBL { get; set; }

    public DateTime DataEmissao { get; set; }

    public string Destinatario { get; set; }

    public string Origem { get; set; }

    public string Destino { get; set; }

    // Relacionamento: 1 BL pode ter muitos Containers
    public virtual ICollection<Container> Containers { get; set; }
}

