using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class SegmentoMapping : IEntityTypeConfiguration<SegmentoEntity>
{
    public void Configure(EntityTypeBuilder<SegmentoEntity> builder)
    {
        builder.ToTable("SIS020_SEGMENTO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS020_SEGMENTO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS020_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS020_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS020_DATA_ATUALIZACAO");

        builder.Property(x => x.Descricao)
            .HasColumnName("SIS020_DESCRICAO");
    }
}
