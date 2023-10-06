using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class EmpresaMapping : IEntityTypeConfiguration<EmpresaEntity>
{
    public void Configure(EntityTypeBuilder<EmpresaEntity> builder)
    {
        builder.ToTable("SIS002_EMPRESA");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS002_EMPRESA_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS002_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS002_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS002_DATA_ATUALIZACAO");

        builder.Property(x => x.RazaoSocial)
            .HasColumnName("SIS002_RAZAO_SOCIAL");

        builder.Property(x => x.NomeFantasia)
            .HasColumnName("SIS002_NOME_FANTASIA");

        builder.Property(x => x.Cnpj)
            .HasColumnName("SIS002_CNPJ");

        builder.Property(x => x.InscricaoEstadual)
            .HasColumnName("SIS002_INSCRICAO_ESTADUAL");

        builder.Property(x => x.IsentoInscricaoEstadual)
            .HasColumnName("SIS002_ISENTO_INSCRICAO_ESTADUAL");

        builder.Property(x => x.InscricaoMunicipal)
            .HasColumnName("SIS002_INSCRICAO_MUNICIPAL");

        builder.Property(x => x.AtividadePrincipal)
            .HasColumnName("SIS002_ATIVIDADE_PRINCIPAL");

        builder.Property(x => x.DescricaoAtividade)
            .HasColumnName("SIS002_DESCRICAO_ATIVIDADE");

        builder.Property(x => x.RegimeTributario)
            .HasColumnName("SIS002_REGIME_TRIBUTARIO");

        builder.Property(x => x.TamanhoEmpresa)
            .HasColumnName("SIS002_TAMANHO_EMPRESA");

        builder.Property(x => x.FaturamentoUltimoAno)
            .HasColumnName("SIS002_FATURAMENTO_ULTIMO_ANO");

        builder.Property(x => x.NumeroFuncionarios)
            .HasColumnName("SIS002_NUMERO_FUNCIONARIOS");

        builder.Property(x => x.EnderecoFiscalId)
            .HasColumnName("SIS013_ENDERECO_FISCAL_ID");
        builder.HasOne(x => x.EnderecoFiscal)
            .WithOne(x => x.Empresa)
            .HasForeignKey<EnderecoEntity>(x => x.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.ContatoId)
            .HasColumnName("SIS014_CONTATO_ID");
        builder.HasOne(x => x.Contato)
            .WithOne(x => x.Empresa)
            .HasForeignKey<ContatoEntity>(x => x.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.TenantId)
            .HasColumnName("SIS001_TENANT_ID");
        builder.HasOne(x => x.Tenant)
            .WithMany(x => x.Empresas)
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
