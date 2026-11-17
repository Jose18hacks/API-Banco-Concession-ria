
using Microsoft.EntityFrameworkCore;
using API_concessionaria.Contexts;
using API_concessionaria.Interfaces;
using API_concessionaria.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ConcessionariaContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Concessionaria")));

builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
