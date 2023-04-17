using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories;

public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(TiendaContext context) : base(context)
    {
    }

    public async Task<Usuario> GetByRefreshTokenAsync(string refreshToken)
    {
        return await _context.Usuarios
                            .Include(u => u.Roles)
                            .Include(u => u.RefreshTokens)
                            .FirstOrDefaultAsync(u => u.RefreshTokens.Any(t => t.Token == refreshToken ) );
    }


    public async Task<Usuario> GetByUsernameAsync(string username)
    { 
        return await _context.Usuarios
                            .Include(u => u.Roles)
                            .Include(u => u.RefreshTokens)
                            .FirstOrDefaultAsync(u => u.Username == username);
    }

}
