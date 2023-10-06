using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class TenantPlanoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public Guid TenantId { get; set; }
    public TenantEntity Tenant { get; set; } = null!;

    public Guid PlanoId { get; set; }
    public PlanoEntity Plano { get; set; } = null!;
}
