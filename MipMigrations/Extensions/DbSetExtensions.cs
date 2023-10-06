using System.Linq.Expressions;
using MipMigrations.Domain.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MipMigrations.Migrations.Extensions;
public static class DbSetExtensions
{
    public static IQueryable<T> Actives<T>(this DbSet<T> dbSet) where T : class, IEntity =>
        dbSet
            .Where(x => x.Active);

    public static async Task InsertOrUpdate<T>(this DbSet<T> dbSet, T entity) where T : class, IEntity
    {
        if (await dbSet.AnyAsync(x => x.Id == entity.Id))
            dbSet.Update(entity);
        else
            await dbSet.AddAsync(entity);
    }

    public static async Task DeactivateAsync<T>(this DbSet<T> dbSet, Expression<Func<T, bool>> predicate) where T : class, IEntity =>
        await dbSet
            .Where(predicate)
            .ExecuteUpdateAsync(s => s.SetProperty(x => x.Active, false));
}