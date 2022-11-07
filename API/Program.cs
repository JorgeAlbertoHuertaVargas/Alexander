using Data.DataContext;
using Data.Interfaces;
using LOGICA.CourseLogic;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>(opciones => {
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaconexion"));
});

//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICourseLogic, CourseLogic>();

var app = builder.Build();

//builder.Services.AddControllers().AddJsonOptions(x =>
//    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

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
