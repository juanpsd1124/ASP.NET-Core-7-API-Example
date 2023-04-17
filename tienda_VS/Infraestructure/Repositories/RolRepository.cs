using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infrastructure.Repositories;

namespace Infraestructure.Repositories;

public class RolRepository : GenericRepository<Rol>, IRolRepository
{
    public RolRepository(TiendaContext context) : base(context)
    {
    }
}
