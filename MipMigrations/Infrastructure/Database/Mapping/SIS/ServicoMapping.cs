using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class ServicoMapping : IEntityTypeConfiguration<ServicoEntity>
{
    public void Configure(EntityTypeBuilder<ServicoEntity> builder)
    {
        builder.ToTable("SIS009_SERVICO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS009_SERVICO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS009_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS009_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS009_DATA_ATUALIZACAO");

        builder.Property(x => x.Descricao)
            .HasColumnName("SIS009_DESCRICAO");

        builder.Property(x => x.Nome)
            .HasColumnName("SIS009_NOME");
    }
}
