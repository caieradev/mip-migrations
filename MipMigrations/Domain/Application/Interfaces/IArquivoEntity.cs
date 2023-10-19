namespace MipMigrations.Domain.Application.Interfaces;

public interface IArquivoEntity : IEntity
{
    // File
    Guid FileId { get; set; }
    string FileName { get; set; }
    string ContentType { get; set; }
    long FileSize { get; set; }

    // Thumb
    Guid? ThumbFileId { get; set; }
    string? ThumbContentType { get; set; }
    long? ThumbFileSize { get; set; }
}