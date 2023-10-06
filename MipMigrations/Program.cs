using MipMigrations.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddDbContext<MipDbContext>(optionsBuilder =>
    optionsBuilder
        .UseSqlServer(config.GetConnectionString("MipDbContext")));

builder
    .Build()
    .Run();