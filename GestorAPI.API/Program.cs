using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Application.Services;
using GestionAPI.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("sqlServerConnection");
builder.Services.AddDbContext<GestionDbContext>(options =>
    options.UseSqlServer(connectionString));

//Repositories
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
