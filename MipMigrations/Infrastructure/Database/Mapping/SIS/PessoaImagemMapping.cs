using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class PessoaImagemMapping : IEntityTypeConfiguration<PessoaImagemEntity>
{
    public void Configure(EntityTypeBuilder<PessoaImagemEntity> builder)
    {
        builder.ToTable("SIS016_PESSOA_IMAGEM");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS016_PESSOA_IMAGEM_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS016_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS016_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS016_DATA_ATUALIZACAO");

        builder.Property(x => x.ImageId)
            .HasColumnName("SIS016_IMAGE_ID");

        builder.Property(x => x.FileName)
            .HasColumnName("SIS016_FILE_NAME");

        builder.Property(x => x.ContentType)
            .HasColumnName("SIS016_CONTENT_TYPE");

        builder.Property(x => x.FileSize)
            .HasColumnName("SIS016_FILE_SIZE");

        builder.Property(x => x.ThumbImageId)
            .HasColumnName("SIS016_THUMB_IMAGE_ID");

        builder.Property(x => x.ThumbContentType)
            .HasColumnName("SIS016_THUMB_CONTENT_TYPE");

        builder.Property(x => x.ThumbFileSize)
            .HasColumnName("SIS016_THUMB_FILE_SIZE");

        builder.Property(x => x.PessoaId)
            .HasColumnName("SIS003_PESSOA_ID");
        builder.HasOne(x => x.Pessoa)
            .WithMany(x => x.PessoaImagens)
            .HasForeignKey(x => x.PessoaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
