using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infrastructure.Repositories;

public class MarcaRepository : GenericRepository<Marca>, IMarcaRepository
{
    public MarcaRepository(TiendaContext context) : base(context)
    {
    }
}
