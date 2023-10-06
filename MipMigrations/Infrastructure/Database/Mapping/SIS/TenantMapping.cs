using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class TenantMapping : IEntityTypeConfiguration<TenantEntity>
{
    public void Configure(EntityTypeBuilder<TenantEntity> builder)
    {
        builder.ToTable("SIS001_TENANT");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS001_TENANT_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS001_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS001_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS001_DATA_ATUALIZACAO");

        builder.Property(x => x.Nome)
            .HasColumnName("SIS001_NOME");

        builder.Property(x => x.CaieraDev)
            .HasDefaultValue(false)
            .HasColumnName("SIS001_CAIERA_DEV");
    }
}
