using EventProjectWeb.DTO.Artist;
using EventProjectWeb.DTO.City;
using EventProjectWeb.DTO.Customer;
using EventProjectWeb.Model.ORM;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers().AddFluentValidation();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EventProjectContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddValidatorsFromAssemblyContaining<CreateArtistRequestDTO>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateArtistRequestDTO>();
builder.Services.AddValidatorsFromAssemblyContaining<CreateCityRequestDTO>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateCityRequestDTO>();
builder.Services.AddValidatorsFromAssemblyContaining<CreateCustomerRequestDTO>();

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
