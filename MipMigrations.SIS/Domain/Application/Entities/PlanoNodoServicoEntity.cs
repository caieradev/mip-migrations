using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class PlanoNodoServicoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public Guid PlanoId { get; set; }
    public PlanoEntity Plano { get; set; } = null!;

    public Guid NodoServicoId { get; set; }
    public NodoServicoEntity NodoServico { get; set; } = null!;
}
