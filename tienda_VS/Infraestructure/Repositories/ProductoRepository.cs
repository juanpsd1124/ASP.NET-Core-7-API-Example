using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories;

public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
{
    public ProductoRepository(TiendaContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Producto>> GetProductosMasCaros(int cantidad) =>
                    await _context.Productos
                        .OrderByDescending(p => p.Precio)
                        .Take(cantidad)
                        .ToListAsync();
}
