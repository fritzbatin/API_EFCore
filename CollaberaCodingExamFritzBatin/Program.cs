global using CollaberaCodingExamFritzBatin.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CollaberaDbContext>();
var app = builder.Build();

//var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<CollaberaDbContext>(options =>
//               options.UseSqlServer(connectionstring));

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
