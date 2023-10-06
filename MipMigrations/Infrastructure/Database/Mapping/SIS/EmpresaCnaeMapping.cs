using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class EmpresaCnaeMapping : IEntityTypeConfiguration<EmpresaCnaeEntity>
{
    public void Configure(EntityTypeBuilder<EmpresaCnaeEntity> builder)
    {
        builder.ToTable("SIS018_EMPRESA_CNAE");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS018_EMPRESA_CNAE_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS018_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS018_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS018_DATA_ATUALIZACAO");

        builder.Property(x => x.CnaePrincipal)
            .HasDefaultValue(false)
            .HasColumnName("SIS018_CNAE_PRINCIPAL");

        builder.Property(x => x.EmpresaId)
            .HasColumnName("SIS002_EMPRESA_ID");
        builder.HasOne(x => x.Empresa)
            .WithMany(x => x.EmpresaCnaesSecundarios)
            .HasForeignKey(x => x.EmpresaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.CnaeId)
            .HasColumnName("SIS017_CNAE_ID");
        builder.HasOne(x => x.Cnae)
            .WithMany(x => x.EmpresaCnaes)
            .HasForeignKey(x => x.CnaeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
