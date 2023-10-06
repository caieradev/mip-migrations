using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class CnaeMapping : IEntityTypeConfiguration<CnaeEntity>
{
    public void Configure(EntityTypeBuilder<CnaeEntity> builder)
    {
        builder.ToTable("SIS017_CNAE");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS017_CNAE_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS017_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS017_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS017_DATA_ATUALIZACAO");

        builder.Property(x => x.Codigo)
            .HasColumnName("SIS017_CODIGO");
    }
}
