using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

public class Marca : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public ICollection<Producto> Productos { get; set; }
}

