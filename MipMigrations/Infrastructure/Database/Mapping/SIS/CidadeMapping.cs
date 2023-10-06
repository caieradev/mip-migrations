using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class CidadeMapping : IEntityTypeConfiguration<CidadeEntity>
{
    public void Configure(EntityTypeBuilder<CidadeEntity> builder)
    {
        builder.ToTable("SIS012_CIDADE");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS012_CIDADE_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS012_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS012_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS012_DATA_ATUALIZACAO");

        builder.Property(x => x.Nome)
            .HasColumnName("SIS012_NOME");

        builder.Property(x => x.CodigoIbge)
            .HasColumnName("SIS012_CODIGO_IBGE");

        builder.Property(x => x.EstadoId)
            .HasColumnName("SIS011_ESTADO_ID");
        builder.HasOne(x => x.Estado)
            .WithMany(x => x.Cidades)
            .HasForeignKey(x => x.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
