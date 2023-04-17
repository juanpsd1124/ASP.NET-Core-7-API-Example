using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class Usuario : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Nombres { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<UsuariosRoles> UsuariosRoles { get; set; }
}
