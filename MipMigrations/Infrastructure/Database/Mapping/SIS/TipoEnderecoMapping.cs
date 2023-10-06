using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class TipoEnderecoMapping : IEntityTypeConfiguration<TipoEnderecoEntity>
{
    public void Configure(EntityTypeBuilder<TipoEnderecoEntity> builder)
    {
        builder.ToTable("SIS019_TIPO_ENDERECO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS019_TIPO_ENDERECO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS019_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS019_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS019_DATA_ATUALIZACAO");

        builder.Property(x => x.Descricao)
            .HasColumnName("SIS019_DESCRICAO");
    }
}
