using Microsoft.EntityFrameworkCore;
using PermissionModels.Context;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using PermissionBl.Validators;
using PermissionBl.Repositories;
using PermissionModels.Entities;
using PermissionBl.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.EnableEndpointRouting = false;
}).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<PermissionTypeValidator>());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cors Register
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Ioc Register
builder.Services.AddBlRegistry();

// Database Register
builder.Services.AddDbContext<PermissionDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

