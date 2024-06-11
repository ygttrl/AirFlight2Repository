using AirFlight2.Core.Repositories;
using AirFlight2.Core.Services;
using AirFlight2.Core.UnitOfWork;
using AirFlight2.Repository.Context;
using AirFlight2.Repository.Repositories;
using AirFlight2.Repository.UnitOfWork;
using AirFlight2.Service.Mapping;
using AirFlight2.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(_ =>
{
    _.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"), opt =>
    {
        opt.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});


builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IAirPortRepository, AirPortRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>(); 
builder.Services.AddScoped(typeof(IService<,>), typeof(Service<,>));


builder.Services.AddScoped<IAirPortService, AirPortService>();
builder.Services.AddScoped<ICountryService, CountryService>();



builder.Services.AddScoped<ISearchService, SearchService>();



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
