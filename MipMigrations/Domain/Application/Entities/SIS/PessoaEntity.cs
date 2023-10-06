using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class PessoaEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Nome { get; set; } = null!;
    public string PrimeiroNome => this.Nome.Split(' ')[0];
    public string UltimoNome => this.Nome.Split(' ')[^1];
    public DateTimeOffset DataNascimento { get; set; }
    public string Cpf { get; set; } = null!;

    public Guid TenantId { get; set; }
    public TenantEntity Tenant { get; set; } = null!;

    public Guid ContatoId { get; set; }
    public ContatoEntity Contato { get; set; } = null!;

    public Guid UsuarioId { get; set; }
    public UsuarioEntity Usuario { get; set; } = null!;

    public ICollection<EnderecoEntity> Enderecos { get; set; } = new List<EnderecoEntity>();
    public ICollection<EmpresaPessoaEntity> EmpresaPessoas { get; set; } = new List<EmpresaPessoaEntity>();
    public ICollection<PessoaImagemEntity> PessoaImagens { get; set; } = new List<PessoaImagemEntity>();
}