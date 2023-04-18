using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class Rol : BaseEntity
{

    //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Nombre { get; set; }
    public ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();
    public ICollection<UsuariosRoles> UsuariosRoles { get; set; }
}
