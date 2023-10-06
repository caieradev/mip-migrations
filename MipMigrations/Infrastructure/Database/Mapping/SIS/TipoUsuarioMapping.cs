using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class TipoUsuarioMapping : IEntityTypeConfiguration<TipoUsuarioEntity>
{
    public void Configure(EntityTypeBuilder<TipoUsuarioEntity> builder)
    {
        builder.ToTable("SIS006_TIPO_USUARIO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS006_TIPO_USUARIO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS006_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS006_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS006_DATA_ATUALIZACAO");

        builder.Property(x => x.Descricao)
            .HasColumnName("SIS006_DESCRICAO");
    }
}
