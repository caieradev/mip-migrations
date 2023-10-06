using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class UsuarioEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Senha { get; set; } = null!;
    public string Usuario { get; set; } = null!;

    public Guid PessoaId { get; set; }
    public PessoaEntity Pessoa { get; set; } = null!;

    public Guid TipoUsuarioId { get; set; }
    public TipoUsuarioEntity TipoUsuario { get; set; } = null!;
}