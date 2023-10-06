using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class EmpresaCnaeEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public bool CnaePrincipal { get; set; } = false;

    public Guid EmpresaId { get; set; }
    public EmpresaEntity Empresa { get; set; } = null!;

    public Guid CnaeId { get; set; }
    public CnaeEntity Cnae { get; set; } = null!;
}
