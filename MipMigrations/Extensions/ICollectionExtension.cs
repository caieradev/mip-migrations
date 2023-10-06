using MipMigrations.Domain.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MipMigrations.Migrations.Extensions;
public static class ICollectionExtensions
{
    public static IQueryable<T> Actives<T>(this DbSet<T> entities) where T : class, IEntity =>
        entities
            .Where(x => x.Active);

    public static async Task DeactivateAsync<T>(this DbSet<T> entities, System.Linq.Expressions.Expression<Func<T, bool>> predicate) where T : class, IEntity =>
        await entities
            .Where(predicate)
            .ExecuteUpdateAsync(s => s.SetProperty(x => x.Active, false));

}