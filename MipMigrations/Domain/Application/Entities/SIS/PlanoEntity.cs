using MipMigrations.Domain.Application.Interfaces;

namespace MipMigrations.Domain.Application.Entities;

public class PlanoEntity : IEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTimeOffset DataCadastro { get; set; }
    public DateTimeOffset DataAtualizacao { get; set; }

    public string Nome { get; set; } = null!;
    public string Descricao { get; set; } = null!;
    public double Valor { get; set; }
    public string ValorFormatado => $"R$ {Valor:N2}";

    public ICollection<NodoServicoEntity> NodoServicoEntities { get; set; } = new List<NodoServicoEntity>();
    public ICollection<TenantPlanoEntity> TenantPlanos { get; set; } = new List<TenantPlanoEntity>();
}