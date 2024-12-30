using Microsoft.EntityFrameworkCore;
using TechnicoApp.Domain.Context;
using TechnicoApp.Domain.Infrastructure.Repositories;
using TechnicoApp.Domain.Interfaces;
using TechnicoApp.Services;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add services to the container
builder.Services.AddDbContext<TechnicoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPropertyItemRepository, PropertyItemRepository>();
builder.Services.AddScoped<IPropertyItemService, PropertyItemService>();



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