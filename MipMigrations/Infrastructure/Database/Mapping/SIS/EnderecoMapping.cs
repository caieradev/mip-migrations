using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class EnderecoMapping : IEntityTypeConfiguration<EnderecoEntity>
{
    public void Configure(EntityTypeBuilder<EnderecoEntity> builder)
    {
        builder.ToTable("SIS013_ENDERECO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS013_ENDERECO_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS013_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS013_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS013_DATA_ATUALIZACAO");

        builder.Property(x => x.Cep)
            .HasColumnName("SIS013_CEP");

        builder.Property(x => x.Logradouro)
            .HasColumnName("SIS013_LOGRADOURO");

        builder.Property(x => x.Numero)
            .HasColumnName("SIS013_NUMERO");

        builder.Property(x => x.Complemento)
            .HasColumnName("SIS013_COMPLEMENTO");

        builder.Property(x => x.Bairro)
            .HasColumnName("SIS013_BAIRRO");

        builder.Property(x => x.CidadeId)
            .HasColumnName("SIS012_CIDADE_ID");
        builder.HasOne(x => x.Cidade)
            .WithMany(x => x.Enderecos)
            .HasForeignKey(x => x.CidadeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.TipoEnderecoId)
            .HasColumnName("SIS019_TIPO_ENDERECO_ID");
        builder.HasOne(x => x.TipoEndereco)
            .WithMany(x => x.Enderecos)
            .HasForeignKey(x => x.TipoEnderecoId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.EmpresaId)
            .HasColumnName("SIS002_EMPRESA_ID");
        builder.HasOne(x => x.Empresa)
            .WithOne(x => x.EnderecoFiscal)
            .HasForeignKey<EmpresaEntity>(x => x.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.PessoaId)
            .HasColumnName("SIS003_PESSOA_ID");
        builder.HasOne(x => x.Pessoa)
            .WithMany(x => x.Enderecos)
            .HasForeignKey(x => x.PessoaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
