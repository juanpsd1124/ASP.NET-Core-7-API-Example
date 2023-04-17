namespace Core.Interfaces;

using Core.Entities;
public interface IUsuarioRepository : IGenericRepository<Usuario> {
    Task<Usuario> GetByUsernameAsync(string username);

}
