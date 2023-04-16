using Core.Interfaces;
using Infraestructure.Data;
using Infraestructure.Repositories;
using Infrastructure.Repositories;

namespace Infraestructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly TiendaContext _context;
    private IProductoRepository _productos;
    private IMarcaRepository _marcas;
    private ICategoriaRepository _categorias;

    public UnitOfWork(TiendaContext context)
    {
        _context = context;
    }

    public ICategoriaRepository Categorias
    {
        get
        {
            if (_categorias == null)
            {
                _categorias = new CategoriaRepository(_context);
            }
            return _categorias;
        }
    }

    public IMarcaRepository Marcas
    {
        get
        {
            if (_marcas == null)
            {
                _marcas = new MarcaRepository(_context);
            }
            return _marcas;
        }
    }

    public IProductoRepository Productos
    {
        get
        {
            if (_productos == null)
            {
                _productos = new ProductoRepository(_context);
            }
            return _productos;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}


