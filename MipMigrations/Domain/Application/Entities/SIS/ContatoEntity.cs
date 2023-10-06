using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class ContatoEntity : ITipoEntity
{
    public string? Telefone { get; set; }
    public string? Celular { get; set; }
    public string Email { get; set; } = null!;
    public string? EmailCobranca { get; set; }
    public string? Site { get; set; }

    public Guid? EmpresaId { get; set; }
    public EmpresaEntity? Empresa { get; set; }
    public Guid? PessoaId { get; set; }
    public PessoaEntity? Pessoa { get; set; }
}
