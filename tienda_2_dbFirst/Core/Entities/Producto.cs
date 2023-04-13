using System;
using System.Collections.Generic;

namespace Core.Entities;

public class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int CategoriaId { get; set; }

    public int MarcaId { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual Marca Marca { get; set; } = null!;
}
