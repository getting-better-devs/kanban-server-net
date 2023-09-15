using Application;
using Infrastructure;
using Infrastructure.Swagger;
using Presentation;
using Web.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddApplicationPart(typeof(Presentation.Bootstrapper).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services
    .AddInfrastructure()
    .AddApplication()
    .AddPresentation()
    .AddSwagger();

builder.Services.AddMvc(option => { option.Filters.Add(typeof(ExceptionFilter)); });

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