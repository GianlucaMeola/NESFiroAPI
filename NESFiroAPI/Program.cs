using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Data Source=localhost;Initial Catalog=NESfiro;Integrated Security=True;Encrypt=False;"; //builder.Configuration.GetConnectionString("SQLdatabase");

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApprovalsContext>(options =>
{
    options.UseSqlServer(connectionString);
});
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
