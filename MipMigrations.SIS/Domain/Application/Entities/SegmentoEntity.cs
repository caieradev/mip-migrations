using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class SegmentoEntity : ITipoEntity
{
    public ICollection<EmpresaSegmentoEntity> EmpresaSegmentos { get; set; } = new List<EmpresaSegmentoEntity>();
}