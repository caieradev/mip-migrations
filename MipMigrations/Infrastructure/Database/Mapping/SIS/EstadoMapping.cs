using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class EstadoMapping : IEntityTypeConfiguration<EstadoEntity>
{
    public void Configure(EntityTypeBuilder<EstadoEntity> builder)
    {
        builder.ToTable("SIS011_ESTADO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS011_ESTADO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS011_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS011_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS011_DATA_ATUALIZACAO");

        builder.Property(x => x.Nome)
            .HasColumnName("SIS011_NOME");

        builder.Property(x => x.Sigla)
            .HasColumnName("SIS011_SIGLA");

        builder.Property(x => x.CodigoIbge)
            .HasColumnName("SIS011_CODIGO_IBGE");
    }
}
