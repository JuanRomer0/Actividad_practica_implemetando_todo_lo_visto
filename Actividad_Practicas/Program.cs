using System.Reflection;
using CleanShop.Application.Abstractions;
using CleanShop.Application.Mappings;
using CleanShop.Infrastructure.Persistence;
using CleanShop.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// ✅ DbContext con PostgreSQL + NoTracking
builder.Services.AddDbContext<AppDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("Postgres")!;
    options.UseNpgsql(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());


var app = builder.Build();

// ✅ Aplicar migraciones automáticas al iniciar
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.UseRouting();
app.MapControllers();
app.Run();

