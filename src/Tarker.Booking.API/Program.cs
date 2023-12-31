using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.API;
using Tarker.Booking.Application;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Common;
using Tarker.Booking.Domain.Entities.User;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;
using Tarker.Booking.Persistence.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

//inyectar todos los contenedores de dependencias.
builder.Services.AddWebApi()
                .AddCommon()
                .AddApplication()
                .AddExternal(builder.Configuration)
                .AddPersistence(builder.Configuration);


//// conexion a db.
//var connectionString = builder.Configuration.GetConnectionString("AZSQLConnectionString");

//builder.Services.AddDbContext<DBService>(opt => opt.UseSqlServer(connectionString));
////inyeccion de la interfaz
//builder.Services.AddScoped<IDBService, DBService>();


var app = builder.Build();

// Configure the HTTP request pipeline.



#region Minimal API para tertear rutas
//crear Minimal API para testear la API
//app.MapPost("/createTest", async (IDBService _dbService) =>
//{
//    var entity = new UserEntity
//    {
//        FirstName = "edwin",
//        LastName = "martinez",
//        UserName = "usuario01",
//        Password = "1206Samu"

//    };

//    await _dbService.User.AddAsync(entity);
//    await _dbService.SaveAsync();

//    return "create OK";
//});


//app.MapGet("/testGet", async (IDBService _dbService) =>
//{
//    var result = await _dbService.User.ToListAsync();
//    return result;
//});
#endregion


app.Run();

