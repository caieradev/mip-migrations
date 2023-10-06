using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class UsuarioMapping : IEntityTypeConfiguration<UsuarioEntity>
{
    public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
    {
        builder.ToTable("SIS005_USUARIO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS005_USUARIO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS005_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS005_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS005_DATA_ATUALIZACAO");

        builder.Property(x => x.Senha)
            .HasColumnName("SIS005_SENHA");

        builder.Property(x => x.Usuario)
            .HasColumnName("SIS005_USUARIO");

        builder.Property(x => x.PessoaId)
            .HasColumnName("SIS003_PESSOA_ID");
        builder.HasOne(x => x.Pessoa)
            .WithOne(x => x.Usuario)
            .HasForeignKey<UsuarioEntity>(x => x.PessoaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.TipoUsuarioId)
            .HasColumnName("SIS006_TIPO_USUARIO_ID");
        builder.HasOne(x => x.TipoUsuario)
            .WithMany(x => x.Usuarios)
            .HasForeignKey(x => x.TipoUsuarioId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
