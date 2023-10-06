using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class ServicoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Nome { get; set; } = null!;
    public string Descricao { get; set; } = null!;

    public ICollection<NodoServicoEntity> Nodos { get; set; } = new List<NodoServicoEntity>();
}