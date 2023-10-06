using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class TipoUsuarioEntity : ITipoEntity
{
    public ICollection<UsuarioEntity> Usuarios { get; set; } = new List<UsuarioEntity>();
}
