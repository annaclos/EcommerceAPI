using ecommerceApi.src.Base.DataBase;
using ecommerceApi.src.Base.Ioc;
using ecommerceApi.src.Base.Middleware;
using ecommerceApi.src.Contracts.Repository;
using ecommerceApi.src.Contracts.Service;
using ecommerceApi.src.Repository;
using ecommerceApi.src.Service;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AppSettings.LoadSettings(builder.Configuration);
Ioc.DependenceInjection(builder.Services);
builder.Services.AddDbContext<DataContext>(x => x.UseNpgsql(AppSettings.ConnectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
