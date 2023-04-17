using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class UsuariosRoles
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int RolId { get; set; }
    public Rol Rol { get; set; }
}
