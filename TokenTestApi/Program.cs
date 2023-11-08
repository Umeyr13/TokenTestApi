using Microsoft.EntityFrameworkCore;
using DataAccessLayer;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//   DataBase

builder.Services.AddDbContext<DatabaseContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("StandartBaglanti")
    ,sqlServerOption => sqlServerOption.EnableRetryOnFailure() ));


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
