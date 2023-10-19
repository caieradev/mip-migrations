using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class EstadoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string CodigoIbge { get; set; } = null!;
    public string Nome { get; set; } = null!;
    public string Sigla { get; set; } = null!;

    public ICollection<CidadeEntity> Cidades { get; set; } = new List<CidadeEntity>();
}
