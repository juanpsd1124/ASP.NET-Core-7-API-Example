using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
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

    public override async Task<Producto> GetByIdAsync(int id)
    {
        return await _context.Productos
                        .Include(p => p.Marca)
                        .Include(p => p.Categoria)
                        .FirstOrDefaultAsync(p => p.Id == id);

    }

    public override async Task<IEnumerable<Producto>> GetAllAsync()
    {
        return await _context.Productos
                        .Include(u => u.Marca)
                        .Include(u => u.Categoria)
                        .ToListAsync();
    }

}
