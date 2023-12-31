using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class CidadeEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string CodigoIbge { get; set; } = null!;
    public string Nome { get; set; } = null!;

    public Guid EstadoId { get; set; }
    public EstadoEntity Estado { get; set; } = null!;

    public ICollection<EnderecoEntity> Enderecos { get; set; } = new List<EnderecoEntity>();
}
