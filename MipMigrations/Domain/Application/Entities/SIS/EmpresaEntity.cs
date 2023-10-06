using MipMigrations.Domain.Application.Enums;
using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class EmpresaEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string RazaoSocial { get; set; } = null!;
    public string? NomeFantasia { get; set; }
    public string Cnpj { get; set; } = null!;
    public string? InscricaoEstadual { get; set; }
    public bool IsentoInscricaoEstadual { get; set; }
    public string? InscricaoMunicipal { get; set; }
    public string Cnae { get; set; } = null!;
    public string AtividadePrincipal { get; set; } = null!;
    public string? DescricaoAtividade { get; set; }

    public RegimeTributarioEnum RegimeTributario { get; set; }
    public TamanhoEmpresaEnum TamanhoEmpresa { get; set; }
    public FaturamentoUltimoAnoEnum FaturamentoUltimoAno { get; set; }
    public NumeroFuncionariosEnum NumeroFuncionarios { get; set; }
    public ICollection<SegmentoEnum> Segmentos { get; set; } = new List<SegmentoEnum>();

    public Guid EnderecoFiscalId { get; set; }
    public EnderecoEntity EnderecoFiscal { get; set; } = null!;

    public Guid ContatoId { get; set; }
    public ContatoEntity Contato { get; set; } = null!;

    public Guid SocioId { get; set; }
    public EmpresaPessoaEntity Socio { get; set; } = null!;

    public ICollection<EmpresaImagemEntity> EmpresaImagens { get; set; } = new List<EmpresaImagemEntity>();
    public ICollection<EmpresaPessoaEntity> EmpresaPessoas { get; set; } = new List<EmpresaPessoaEntity>();
}