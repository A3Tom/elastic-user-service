using MediatR;
using UserService.Api.Extensions;
using UserService.Application.Queries.UseCases.Users.Handlers;
using UserService.Data.Abstract;
using UserService.Data.Contexts;
using UserService.Domain.Abstract;
using UserService.Domain.Settings;

var builder = WebApplication.CreateBuilder(args);

var appConfig = builder.Configuration
    .AddJsonFile("local.settings.json")
    .Build();
var userServiceSettings = appConfig
    .GetSection("UserService")
    .Get<UserServiceSettings>();

// Wire up Application Settings
builder.Services.AddSingleton<IElasticSearchSettings>(userServiceSettings);

// Add services to the container.
builder.Services.AddMediatR(typeof(SearchUsers));
builder.Services.AddTransient<IUserContext, UserContext>();

// Add Elastic Search
builder.Services.AddUserElasticSearch();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
