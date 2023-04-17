using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces;

public interface IUnitOfWork
{
    IProductoRepository Productos { get; }
    IMarcaRepository Marcas { get; }
    ICategoriaRepository Categorias { get; }
    IRolRepository Roles { get; }
    IUsuarioRepository Usuarios { get; }


    Task<int> SaveAsync();
}



