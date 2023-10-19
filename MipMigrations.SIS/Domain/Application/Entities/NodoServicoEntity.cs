using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class NodoServicoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public bool Tail { get; set; }
    public bool Root { get; set; }

    public Guid? ServicoId { get; set; }
    public ServicoEntity? Servico { get; set; }

    public Guid? ServicoPaiId { get; set; }
    public NodoServicoEntity? ServicoPai { get; set; }

    public ICollection<NodoServicoEntity> ServicosFilhos { get; set; } = new List<NodoServicoEntity>();
    public ICollection<PlanoNodoServicoEntity> PlanoNodoServicos { get; set; } = new List<PlanoNodoServicoEntity>();
}
