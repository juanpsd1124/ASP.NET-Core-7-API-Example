using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class Producto : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Nombre { get; set; }

    public decimal Precio { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int CategoriaId { get; set; }

    public int MarcaId { get; set; }

    public Categoria Categoria { get; set; }

    public Marca Marca { get; set; }
}

