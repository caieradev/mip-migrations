namespace MipMigrations.Domain.Application.Interfaces;
public interface IEntity
{
    Guid Id { get; set; }
    bool Active { get; set; }
    DateTimeOffset DataCadastro { get; set; }
    DateTimeOffset DataAtualizacao { get; set; }
}