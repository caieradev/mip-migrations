using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class PessoaMapping : IEntityTypeConfiguration<PessoaEntity>
{
    public void Configure(EntityTypeBuilder<PessoaEntity> builder)
    {
        builder.ToTable("SIS003_PESSOA");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS003_PESSOA_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS003_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS003_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS003_DATA_ATUALIZACAO");

        builder.Property(x => x.Nome)
            .HasColumnName("SIS003_NOME");

        builder.Property(x => x.DataNascimento)
            .HasColumnName("SIS003_DATA_NASCIMENTO");

        builder.Property(x => x.Cpf)
            .HasColumnName("SIS003_CPF");

        builder.Property(x => x.TenantId)
            .HasColumnName("SIS001_TENANT_ID");
        builder.HasOne(x => x.Tenant)
            .WithMany(x => x.Pessoas)
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.ContatoId)
            .HasColumnName("SIS014_CONTATO_ID");
        builder.HasOne(x => x.Contato)
            .WithOne(x => x.Pessoa)
            .HasForeignKey<PessoaEntity>(x => x.ContatoId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.UsuarioId)
            .HasColumnName("SIS005_USUARIO_ID");
        builder.HasOne(x => x.Usuario)
            .WithOne(x => x.Pessoa)
            .HasForeignKey<PessoaEntity>(x => x.UsuarioId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
