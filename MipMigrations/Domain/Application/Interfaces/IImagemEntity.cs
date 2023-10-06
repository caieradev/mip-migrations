namespace MipMigrations.Domain.Application.Interfaces;

public interface IImagemEntity : IEntity
{
    // Image
    Guid ImageId { get; set; }
    string FileName { get; set; }
    string ContentType { get; set; }
    long FileSize { get; set; }

    // Thumb
    Guid? ThumbImageId { get; set; }
    string? ThumbContentType { get; set; }
    long? ThumbFileSize { get; set; }
}