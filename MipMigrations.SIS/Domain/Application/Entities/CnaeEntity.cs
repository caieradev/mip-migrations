using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class CnaeEntity : ITipoEntity
{
    public string Codigo { get; set; } = null!;

    public ICollection<EmpresaCnaeEntity> EmpresaCnaes { get; set; } = new List<EmpresaCnaeEntity>();
}
