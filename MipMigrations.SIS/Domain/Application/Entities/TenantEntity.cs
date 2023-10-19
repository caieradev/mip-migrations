using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class TenantEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Nome { get; set; } = null!;
    public bool CaieraDev { get; set; } = false;

    public ICollection<TenantPlanoEntity> TenantPlanos { get; set; } = null!;
    public ICollection<EmpresaEntity> Empresas { get; set; } = new List<EmpresaEntity>();
    public ICollection<PessoaEntity> Pessoas { get; set; } = new List<PessoaEntity>();
}