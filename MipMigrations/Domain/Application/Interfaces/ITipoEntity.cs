namespace MipMigrations.Domain.Application.Interfaces;
public abstract class ITipoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; }
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }
    public string Descricao { get; set; } = null!;
}