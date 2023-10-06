using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class EmpresaPessoaMapping : IEntityTypeConfiguration<EmpresaPessoaEntity>
{
    public void Configure(EntityTypeBuilder<EmpresaPessoaEntity> builder)
    {
        builder.ToTable("SIS004_EMPRESA_PESSOA");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS004_EMPRESA_PESSOA_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS004_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS004_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS004_DATA_ATUALIZACAO");

        builder.Property(x => x.Socio)
            .HasDefaultValue(false)
            .HasColumnName("SIS004_SOCIO");

        builder.Property(x => x.EmpresaId)
            .HasColumnName("SIS002_EMPRESA_ID");
        builder.HasOne(x => x.Empresa)
            .WithMany(x => x.EmpresaPessoas)
            .HasForeignKey(x => x.EmpresaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.PessoaId)
            .HasColumnName("SIS003_PESSOA_ID");
        builder.HasOne(x => x.Pessoa)
            .WithMany(x => x.EmpresaPessoas)
            .HasForeignKey(x => x.PessoaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
