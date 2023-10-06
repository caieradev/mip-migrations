using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class ContatoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Nome { get; set; } = null!;
    public string? Telefone { get; set; }
    public string? Celular { get; set; }
    public string Email { get; set; } = null!;
    public string? EmailCobranca { get; set; }
    public string? Site { get; set; }
}
