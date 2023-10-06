using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class PlanoNodoServicoMapping : IEntityTypeConfiguration<PlanoNodoServicoEntity>
{
    public void Configure(EntityTypeBuilder<PlanoNodoServicoEntity> builder)
    {
        builder.ToTable("SIS021_PLANO_NODO_SERVICO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS021_PLANO_NODO_SERVICO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS021_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS021_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS021_DATA_ATUALIZACAO");

        builder.Property(x => x.PlanoId)
            .HasColumnName("SIS007_PLANO_ID");
        builder.HasOne(x => x.Plano)
            .WithMany(x => x.PlanoNodoServicos)
            .HasForeignKey(x => x.PlanoId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.NodoServicoId)
            .HasColumnName("SIS010_NODO_SERVICO_ID");
        builder.HasOne(x => x.NodoServico)
            .WithMany(x => x.PlanoNodoServicos)
            .HasForeignKey(x => x.NodoServicoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
