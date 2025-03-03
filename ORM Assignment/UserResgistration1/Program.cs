using BusinessLayer1.Interface;
using BusinessLayer1.Service;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer1.Context;
using RepositoryLayer1.Interface;
using RepositoryLayer1.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRegistrationBL, UserRegistrationBL>();
builder.Services.AddScoped<IUserRegistrationRL, UserRegistrationRL>();

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString));


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
