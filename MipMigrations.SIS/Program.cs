using MipMigrations.SIS.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddDbContext<MipSisDbContext>(optionsBuilder =>
    optionsBuilder
        .UseSqlServer(config.GetConnectionString("MipSisDbContext")));

builder
    .Build()
    .Run();