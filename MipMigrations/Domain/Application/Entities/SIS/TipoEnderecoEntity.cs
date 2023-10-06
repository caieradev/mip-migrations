using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;
public class TipoEnderecoEntity : ITipoEntity
{
    public ICollection<EnderecoEntity> Enderecos { get; set; } = new List<EnderecoEntity>();
}