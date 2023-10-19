using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.SIS.Domain.Application.Entities;

public class PlanoEntity : ITipoEntity
{
    public string Nome { get; set; } = null!;
    public double Valor { get; set; }
    public string ValorFormatado => $"R$ {Valor:N2}";

    public ICollection<TenantPlanoEntity> TenantPlanos { get; set; } = new List<TenantPlanoEntity>();
    public ICollection<PlanoNodoServicoEntity> PlanoNodoServicos { get; set; } = new List<PlanoNodoServicoEntity>();
}