using DinnerMatcherNew;
using DinnerMatcherNew.DataContext;
using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Repositories;
using DinnerMatcherNew.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DinnerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DinnerMatcher")));
builder.Services.AddControllers();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.TryAddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.TryAddScoped<IUserRepository, UserRepository>();
builder.Services.TryAddScoped<IServiceRestaurant, ServiceRestaurant>();
builder.Services.TryAddScoped<IServiceGame, ServiceGame>();
builder.Services.TryAddScoped<IGameRepository, GameRepository>();
var app = builder.Build();


app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();    


