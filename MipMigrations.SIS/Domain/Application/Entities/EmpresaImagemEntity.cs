using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class EmpresaImagemEntity : IArquivoEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    // File
    public Guid FileId { get; set; }
    public string FileName { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public long FileSize { get; set; }

    // Thumb
    public Guid? ThumbFileId { get; set; }
    public string? ThumbContentType { get; set; }
    public long? ThumbFileSize { get; set; }

    public Guid EmpresaId { get; set; }
    public EmpresaEntity Empresa { get; set; } = null!;
}
