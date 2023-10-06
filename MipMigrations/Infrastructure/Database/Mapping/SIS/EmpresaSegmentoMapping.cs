using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class EmpresaSegmentoMapping : IEntityTypeConfiguration<EmpresaSegmentoEntity>
{
    public void Configure(EntityTypeBuilder<EmpresaSegmentoEntity> builder)
    {
        builder.ToTable("SIS022_EMPRESA_SEGMENTO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS022_EMPRESA_SEGMENTO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS022_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS022_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS022_DATA_ATUALIZACAO");

        builder.Property(x => x.EmpresaId)
            .HasColumnName("SIS002_EMPRESA_ID");
        builder.HasOne(x => x.Empresa)
            .WithMany(x => x.EmpresaSegmentos)
            .HasForeignKey(x => x.EmpresaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.SegmentoId)
            .HasColumnName("SIS020_SEGMENTO_ID");
        builder.HasOne(x => x.Segmento)
            .WithMany(x => x.EmpresaSegmentos)
            .HasForeignKey(x => x.SegmentoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
