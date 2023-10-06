using System.Linq.Expressions;
using MipMigrations.Domain.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using MipMigrations.Domain.Application.DTOs;

namespace MipMigrations.Migrations.Extensions;
public static class IQueryableExtensions
{
    public static IQueryable<T> Actives<T>(this IQueryable<T> query) where T : class, IEntity =>
        query
            .Where(x => x.Ativo);

    public static async Task DeactivateAsync<T>(this IQueryable<T> query, Expression<Func<T, bool>> predicate) where T : class, IEntity =>
        await query
            .Where(predicate)
            .ExecuteUpdateAsync(s => s.SetProperty(x => x.Ativo, false));

    public static IQueryable<T> ApplyPagination<T>(this IQueryable<T> query, PaginationDTO pagination, Expression<Func<T, bool>>? predicate = null)
    {
        if (pagination.cursor != null)
            return query.ApplyCursorPagination(pagination.pageSize, predicate ??
                throw new Exception("Cursor não nulo e predicate nulo no ApplyPagination do repositório."));

        return query.ApplyOffsetPagination(pagination.page, pagination.pageSize);
    }

    public static IQueryable<T> ApplyOffsetPagination<T>(this IQueryable<T> query, int page, int pageSize) =>
        query
            .Skip(page * pageSize)
            .Take(pageSize);

    public static IQueryable<T> ApplyCursorPagination<T>(this IQueryable<T> query, int pageSize, Expression<Func<T, bool>> predicate) =>
        query
            .Where(predicate)
            .Take(pageSize);
}