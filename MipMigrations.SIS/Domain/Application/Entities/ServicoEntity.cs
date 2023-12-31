using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class ServicoEntity : ITipoEntity
{
    public string Nome { get; set; } = null!;

    public ICollection<NodoServicoEntity> NodoServicos { get; set; } = new List<NodoServicoEntity>();
}