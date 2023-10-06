using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class PlanoMapping : IEntityTypeConfiguration<PlanoEntity>
{
    public void Configure(EntityTypeBuilder<PlanoEntity> builder)
    {
        builder.ToTable("SIS007_PLANO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS007_PLANO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS007_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS007_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS007_DATA_ATUALIZACAO");

        builder.Property(x => x.Descricao)
            .HasColumnName("SIS007_DESCRICAO");

        builder.Property(x => x.Nome)
            .HasColumnName("SIS007_NOME");

        builder.Property(x => x.Valor)
            .HasColumnName("SIS007_VALOR");
    }
}
