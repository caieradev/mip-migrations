using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class PessoaImagemEntity : IImagemEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    // Image
    public Guid BannerId { get; set; }
    public string FileName { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public long FileSize { get; set; }
    // Thumb
    public Guid? ThumbBannerId { get; set; }
    public string? ThumbContentType { get; set; }
    public long? ThumbFileSize { get; set; }

    public Guid PessoaId { get; set; }
    public PessoaEntity Pessoa { get; set; } = null!;
}
