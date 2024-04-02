using finalPOCService.database;
using finalPOCService.functionality;
using finalPOCService.service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();   // added by us
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddTransient<IAlumni, AlumniOperations>();
builder.Services.AddTransient<IUser,UserOperations>();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();    // to map the controller
app.UseCors(x => x       // cors
.AllowAnyHeader()
.AllowAnyMethod()
.AllowAnyOrigin()
);
app.Run();

