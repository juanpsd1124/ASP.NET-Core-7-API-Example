using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

public class Categoria: BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]

    public string? Nombre { get; set; } 

    public ICollection<Producto> Productos { get; set; }
}

