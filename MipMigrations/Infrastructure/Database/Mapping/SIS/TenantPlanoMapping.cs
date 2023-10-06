using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class TenantPlanoMapping : IEntityTypeConfiguration<TenantPlanoEntity>
{
    public void Configure(EntityTypeBuilder<TenantPlanoEntity> builder)
    {
        builder.ToTable("SIS008_TENANT_PLANO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS008_TENANT_PLANO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS008_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS008_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS008_DATA_ATUALIZACAO");

        builder.Property(x => x.TenantId)
            .HasColumnName("SIS001_TENANT_ID");
        builder.HasOne(x => x.Tenant)
            .WithMany(x => x.TenantPlanos)
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.PlanoId)
            .HasColumnName("SIS007_PLANO_ID");
        builder.HasOne(x => x.Plano)
            .WithMany(x => x.TenantPlanos)
            .HasForeignKey(x => x.PlanoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
