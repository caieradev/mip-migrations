using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class NodoServicoMapping : IEntityTypeConfiguration<NodoServicoEntity>
{
    public void Configure(EntityTypeBuilder<NodoServicoEntity> builder)
    {
        builder.ToTable("SIS010_NODO_SERVICO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS010_NODO_SERVICO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS010_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS010_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS010_DATA_ATUALIZACAO");

        builder.Property(x => x.Tail)
            .HasColumnName("SIS010_TAIL");

        builder.Property(x => x.Root)
            .HasColumnName("SIS010_ROOT");

        builder.Property(x => x.ServicoId)
            .HasColumnName("SIS009_SERVICO_ID");
        builder.HasOne(x => x.Servico)
            .WithMany(x => x.NodoServicos)
            .HasForeignKey(x => x.ServicoId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.ServicoPaiId)
            .HasColumnName("SIS009_SERVICO_PAI_ID");
        builder.HasOne(x => x.ServicoPai)
            .WithMany(x => x.ServicosFilhos)
            .HasForeignKey(x => x.ServicoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
