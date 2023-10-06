namespace MipMigrations.Domain.Application.Interfaces;
public interface IEntity
{
    Guid Id { get; set; }
    bool Ativo { get; set; }
    DateTimeOffset DataCadastro { get; set; }
    DateTimeOffset DataAtualizacao { get; set; }
}