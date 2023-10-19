using MipMigrations.SIS.Domain.Application.Enums;
using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class EmpresaEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string RazaoSocial { get; set; } = null!;
    public string? NomeFantasia { get; set; }
    public string Cnpj { get; set; } = null!;
    public string? InscricaoEstadual { get; set; }
    public bool IsentoInscricaoEstadual { get; set; }
    public string? InscricaoMunicipal { get; set; }
    public string AtividadePrincipal { get; set; } = null!;
    public string? DescricaoAtividade { get; set; }

    public RegimeTributarioEnum RegimeTributario { get; set; }
    public TamanhoEmpresaEnum TamanhoEmpresa { get; set; }
    public FaturamentoUltimoAnoEnum FaturamentoUltimoAno { get; set; }
    public NumeroFuncionariosEnum NumeroFuncionarios { get; set; }

    public Guid EnderecoFiscalId { get; set; }
    public EnderecoEntity EnderecoFiscal { get; set; } = null!;

    public Guid ContatoId { get; set; }
    public ContatoEntity Contato { get; set; } = null!;

    public Guid TenantId { get; set; }
    public TenantEntity Tenant { get; set; } = null!;

    public ICollection<EmpresaSegmentoEntity> EmpresaSegmentos { get; set; } = new List<EmpresaSegmentoEntity>();
    public ICollection<EmpresaCnaeEntity> EmpresaCnaesSecundarios { get; set; } = new List<EmpresaCnaeEntity>();
    public ICollection<EmpresaImagemEntity> EmpresaImagens { get; set; } = new List<EmpresaImagemEntity>();
    public ICollection<EmpresaPessoaEntity> EmpresaPessoas { get; set; } = new List<EmpresaPessoaEntity>();
}