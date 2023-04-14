using Core.Entities;
namespace Core.Interfaces;

public interface IProductoRepository : IGenericRepository<Producto>
{
    Task<IEnumerable<Producto>> GetProductosMasCaros(int cantidad);
}
