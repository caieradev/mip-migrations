using MipMigrations.Domain.Application.Enums;
using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class EnderecoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Cep { get; set; } = null!;
    public string Bairro { get; set; } = null!;
    public string Endereco { get; set; } = null!;
    public string? Numero { get; set; }
    public bool SemNumero { get; set; }
    public string? Complemento { get; set; }

    public Guid CidadeId { get; set; }
    public CidadeEntity Cidade { get; set; } = null!;

    public Guid TipoEnderecoId { get; set; }
    public TipoEnderecoEntity TipoEndereco { get; set; } = null!;
}