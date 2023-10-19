using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class EmpresaSegmentoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public Guid EmpresaId { get; set; }
    public EmpresaEntity Empresa { get; set; } = null!;

    public Guid SegmentoId { get; set; }
    public SegmentoEntity Segmento { get; set; } = null!;
}
