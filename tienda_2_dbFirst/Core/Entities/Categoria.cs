using System;
using System.Collections.Generic;

namespace Core.Entities;

public class Categoria
{
    public Categoria(){
        Productos = new HashSet<Producto>();
    }

    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
