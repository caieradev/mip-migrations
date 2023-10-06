using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class ContatoMapping : IEntityTypeConfiguration<ContatoEntity>
{
    public void Configure(EntityTypeBuilder<ContatoEntity> builder)
    {
        builder.ToTable("SIS014_CONTATO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS014_CONTATO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS014_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS014_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS014_DATA_ATUALIZACAO");

        builder.Property(x => x.Descricao)
            .HasColumnName("SIS014_DESCRICAO");

        builder.Property(x => x.Telefone)
            .HasColumnName("SIS014_TELEFONE");

        builder.Property(x => x.Celular)
            .HasColumnName("SIS014_CELULAR");

        builder.Property(x => x.Email)
            .HasColumnName("SIS014_EMAIL");

        builder.Property(x => x.EmailCobranca)
            .HasColumnName("SIS014_EMAIL_COBRANCA");

        builder.Property(x => x.Site)
            .HasColumnName("SIS014_SITE");
    }
}
