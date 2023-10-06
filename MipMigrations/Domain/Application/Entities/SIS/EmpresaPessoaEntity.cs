using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class EmpresaPessoaEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public Guid EmpresaId { get; set; }
    public EmpresaEntity Empresa { get; set; } = null!;

    public Guid PessoaId { get; set; }
    public PessoaEntity Pessoa { get; set; } = null!;
}