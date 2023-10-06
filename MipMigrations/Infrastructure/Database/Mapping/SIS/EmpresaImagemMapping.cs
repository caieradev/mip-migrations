using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MipMigrations.Infrastructure.Database.Mapping;
public class EmpresaImagemMapping : IEntityTypeConfiguration<EmpresaImagemEntity>
{
    public void Configure(EntityTypeBuilder<EmpresaImagemEntity> builder)
    {
        builder.ToTable("SIS015_EMPRESA_IMAGEM");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("SIS015_EMPRESA_IMAGEM_ID");

        builder.Property(x => x.Ativo)
            .HasColumnName("SIS015_ATIVO");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("SIS015_DATA_CADASTRO");

        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("SIS015_DATA_ATUALIZACAO");

        builder.Property(x => x.ImageId)
            .HasColumnName("SIS015_IMAGE_ID");

        builder.Property(x => x.FileName)
            .HasColumnName("SIS015_FILE_NAME");

        builder.Property(x => x.ContentType)
            .HasColumnName("SIS015_CONTENT_TYPE");

        builder.Property(x => x.FileSize)
            .HasColumnName("SIS015_FILE_SIZE");

        builder.Property(x => x.ThumbImageId)
            .HasColumnName("SIS015_THUMB_IMAGE_ID");

        builder.Property(x => x.ThumbContentType)
            .HasColumnName("SIS015_THUMB_CONTENT_TYPE");

        builder.Property(x => x.ThumbFileSize)
            .HasColumnName("SIS015_THUMB_FILE_SIZE");

        builder.Property(x => x.EmpresaId)
            .HasColumnName("SIS002_EMPRESA_ID");
        builder.HasOne(x => x.Empresa)
            .WithMany(x => x.EmpresaImagens)
            .HasForeignKey(x => x.EmpresaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
