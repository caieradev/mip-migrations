using MipMigrations.SIS.Domain.Application.Enums;
using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class EnderecoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Cep { get; set; } = null!;
    public string Bairro { get; set; } = null!;
    public string Logradouro { get; set; } = null!;
    public string? Numero { get; set; }
    public string? Complemento { get; set; }

    public Guid CidadeId { get; set; }
    public CidadeEntity Cidade { get; set; } = null!;

    public Guid TipoEnderecoId { get; set; }
    public TipoEnderecoEntity TipoEndereco { get; set; } = null!;

    public Guid? EmpresaId { get; set; }
    public EmpresaEntity? Empresa { get; set; }

    public Guid? PessoaId { get; set; }
    public PessoaEntity? Pessoa { get; set; }
}