using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Enums;
public class TipoEnderecoEntity : IEntity
{
    public Guid Id { get; set; }
    public string Descricao { get; set; } = null!;
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }
}