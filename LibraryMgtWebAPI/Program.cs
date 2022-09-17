using LibraryMgt.Application;
using LibraryMgt.Infrastructure.Persistence;
using LibraryMgt.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
//builder.Services.AddDbContext();

/*builder.Services.AddDbContext<LibraryMgtDbContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("LibraryMgtDb"));
});*/

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
